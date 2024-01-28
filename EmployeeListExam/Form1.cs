using System;
using MySql.Data.MySqlClient;


namespace EmployeeListExam
{

    public partial class EmployeeList : Form
    {

        MySqlConnection db_connect;
        MySqlCommand cmd;
        MySqlDataReader dataRead;
        int i = 0;

        Dbconnection dbconn = new Dbconnection(); //dbconnection class
        Queries query = new Queries();


        public EmployeeList()
        {
            InitializeComponent();
            db_connect = new MySqlConnection(dbconn.dbconnect());
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadRecord();
            editButton.Enabled = false;
            deleteButton.Enabled = false;

        }


      
        private void LoadRecord()
        {
            try
            {
                db_connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            employeeRecordTable.Rows.Clear();
            cmd = new MySqlCommand(query.selectQuery(), db_connect);

            dataRead = cmd.ExecuteReader();
            DATAREAD();

            dataRead.Close();
            db_connect.Close();
        }



        public void clearForm()
        {
            employeeID.Clear();
            firstName.Clear();
            middleName.Clear();
            lastName.Clear();
            birthdayPicker.Value = DateTime.Now;
            addressUnitNum.Clear();
            addressBrgy.Clear();
            addressCity.Clear();
            employeePosition.Clear();
            employeeDepartment.Clear();
            employeeCompany.Clear();
            employeeDateJoined.Value = DateTime.Now;
            employeeDateLeft.Value = DateTime.Now;

            saveButton.Visible = true;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }


        //save and save the input data
        private void saveButton_Click(object sender, EventArgs e)
        {

            if (true)
            {
                DataValidation.AnyValuesAreNotValid(employeeID.Text, firstName.Text, middleName.Text, lastName.Text,
                                                    addressUnitNum.Text, addressBrgy.Text, addressCity.Text,
                                                    employeePosition.Text, employeeDepartment.Text, employeeCompany.Text);
            }
            else
            {

                db_connect.Open();
                cmd = new MySqlCommand(query.insertQuery(), db_connect);
                cmd.Parameters.Clear();

                SAVETODATABASE();

                if (i > 0)
                {

                    MessageBox.Show("Record Save Success!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Save Failed!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                db_connect.Close();
                LoadRecord();
                clearForm();
            }


        }




        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Enabled = true;

            cmd.Parameters.Clear();


            if ((employeeID.Text == string.Empty) ||
               (firstName.Text == string.Empty) ||
               (lastName.Text == string.Empty) ||
               (addressUnitNum.Text == string.Empty) ||
               (addressBrgy.Text == string.Empty) ||
               (addressCity.Text == string.Empty) ||
               (employeePosition.Text == string.Empty) ||
               (employeeDepartment.Text == string.Empty) ||
               (employeeCompany.Text == string.Empty))
            {
                MessageBox.Show("Warning: Fill Required Box!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                //cannot edit EmployeeID
                db_connect.Open();
                cmd = new MySqlCommand(query.updateQuery(), db_connect);
                SAVETODATABASE();

                if (i > 0)
                {
                    MessageBox.Show("Record Update Success!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Update Failed!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                db_connect.Close();
                LoadRecord();
                clearForm();
            }

        }


        private void deleteButton_Click(object sender, EventArgs e)
        {

            db_connect.Open();
            cmd = new MySqlCommand(query.deleteQuery(), db_connect);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID.Text); //get EmployeeIDText - input and run to query
                                                                             //delete if employeeID match   

            i = cmd.ExecuteNonQuery(); // execute mysqlcommand. checks if 'Column count match value count at row 1'

            if (i > 0)
            {
                MessageBox.Show("Record Delete Success!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record Delete Failed!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            db_connect.Close();
            LoadRecord();
            clearForm();


        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            employeeRecordTable.Rows.Clear();

            db_connect.Open();
            employeeRecordTable.Rows.Clear();
            cmd = new MySqlCommand(query.searchQuery(search.Text), db_connect);

            dataRead = cmd.ExecuteReader();
            DATAREAD();

            dataRead.Close();
            db_connect.Close();
        }


        

        private void employeeRecordTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            saveButton.Visible = false;
            editButton.Enabled = true;
            deleteButton.Enabled = true;

            employeeID.Text = employeeRecordTable.CurrentRow.Cells[1].Value.ToString();
            firstName.Text = employeeRecordTable.CurrentRow.Cells[2].Value.ToString();
            middleName.Text = employeeRecordTable.CurrentRow.Cells[3].Value.ToString();
            lastName.Text = employeeRecordTable.CurrentRow.Cells[4].Value.ToString();
            birthdayPicker.Text = employeeRecordTable.CurrentRow.Cells[5].Value.ToString();
            addressUnitNum.Text = employeeRecordTable.CurrentRow.Cells[6].Value.ToString();
            addressBrgy.Text = employeeRecordTable.CurrentRow.Cells[7].Value.ToString();
            addressCity.Text = employeeRecordTable.CurrentRow.Cells[8].Value.ToString();
            employeePosition.Text = employeeRecordTable.CurrentRow.Cells[9].Value.ToString();
            employeeDepartment.Text = employeeRecordTable.CurrentRow.Cells[10].Value.ToString();
            employeeCompany.Text = employeeRecordTable.CurrentRow.Cells[11].Value.ToString();
            employeeDateJoined.Text = employeeRecordTable.CurrentRow.Cells[12].Value.ToString();
            employeeDateLeft.Text = employeeRecordTable.CurrentRow.Cells[13].Value.ToString();

        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            clearForm();
            saveButton.Visible = true;
            saveButton.Enabled = true;
        }

        private void DATAREAD()
        {
            while (dataRead.Read())
            {
                employeeRecordTable.Rows.Add(employeeRecordTable.Rows.Count + 1, dataRead["EmployeeID"].ToString(),
                                                                     dataRead["FirstName"].ToString(),
                                                                     dataRead["MiddleName"].ToString(),
                                                                     dataRead["LastName"].ToString(),
                                                                     dataRead["birthday"],
                                                                     dataRead["addressUnitNum"].ToString(),
                                                                     dataRead["addressBrgy"].ToString(),
                                                                     dataRead["addressCity"].ToString(),
                                                                     dataRead["employeePosition"].ToString(),
                                                                     dataRead["employeeDepartment"].ToString(),
                                                                     dataRead["employeeCompany"].ToString(),
                                                                     dataRead["employeeDateJoined"],
                                                                     dataRead["employeeDateLeft"]);
            }
        }

        private void SAVETODATABASE()
        {

            string birthday = birthdayPicker.Value.ToString("yyyy-MM-dd");  //saves birthdayPicker string to birthday in MYSQl;
            string date_joined = employeeDateJoined.Value.ToString("yyyy-MM-dd");
            string date_left = employeeDateLeft.Value.ToString("yyyy-MM-dd");

            cmd.Parameters.AddWithValue("@EmployeeID", employeeID.Text);
            cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
            cmd.Parameters.AddWithValue("@MiddleName", middleName.Text);
            cmd.Parameters.AddWithValue("@LastName", lastName.Text);
            cmd.Parameters.AddWithValue("@birthday", birthday);
            cmd.Parameters.AddWithValue("@addressUnitNum", addressUnitNum.Text);
            cmd.Parameters.AddWithValue("@addressBrgy", addressBrgy.Text);
            cmd.Parameters.AddWithValue("@addressCity", addressCity.Text);
            cmd.Parameters.AddWithValue("@employeePosition", employeePosition.Text);
            cmd.Parameters.AddWithValue("@employeeDepartment", employeeDepartment.Text);
            cmd.Parameters.AddWithValue("@employeeCompany", employeeCompany.Text);
            cmd.Parameters.AddWithValue("@employeeDateJoined", date_joined);
            cmd.Parameters.AddWithValue("@employeeDateLeft", date_left);
            //EmployeeIDText - input

            i = cmd.ExecuteNonQuery();
        }


    }


    
    }

