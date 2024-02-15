using System;
using MySql.Data.MySqlClient;
namespace EmployeeListExam
{

    public partial class EmployeeList : Form
    {
        readonly MySqlConnection db_connect;
        MySqlCommand cmd;
        MySqlDataReader dataRead;
        int i = 0;

        readonly Dbconnection dbconn = new Dbconnection(); //dbconnection class

        public EmployeeList()
        {
            InitializeComponent();
            db_connect = new MySqlConnection(dbconn.dbconnect());
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadRecord();
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;

        }


      
        private void LoadRecord()
        {
            
            db_connect.Open();
           
            employeeRecordTable.Rows.Clear();
            cmd = new MySqlCommand(Queries.SelectQuery(), db_connect);

            dataRead = cmd.ExecuteReader();
            DATAREAD();

            dataRead.Close();
            db_connect.Close();
        }



        public void ClearForm()
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

            SaveButton.Visible = true;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
        }


        
        private void SaveButton_Click(object sender, EventArgs e)
        {

                if (DataValidation.CheckEmployeeIDExist(employeeID.Text))
                {
                    MessageBox.Show("Employee ID already exist. ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    employeeID.Clear();
                    return;
                }
                else if ((DataValidation.AnyValuesAreNotValid(employeeID.Text, firstName.Text, middleName.Text, lastName.Text,
                                                         addressUnitNum.Text, addressBrgy.Text, addressCity.Text,
                                                         employeePosition.Text, employeeDepartment.Text, employeeCompany.Text)) != "")
                {

                    MessageBox.Show(DataValidation.AnyValuesAreNotValid(employeeID.Text, firstName.Text, middleName.Text, lastName.Text,
                                                         addressUnitNum.Text, addressBrgy.Text, addressCity.Text,
                                                         employeePosition.Text, employeeDepartment.Text, employeeCompany.Text), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    db_connect.Open();
                    cmd = new MySqlCommand(Queries.InsertQuery(), db_connect);
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
                    ClearForm();
                }
          /*  
            catch (Exception ex)
            {
                MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }




        private void EditButton_Click(object sender, EventArgs e)
        {
            EditButton.Enabled = true;

            cmd.Parameters.Clear();


            if (DataValidation.CheckEmployeeIDExist(employeeID.Text))
            {
                MessageBox.Show("Employee ID already exist. ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                employeeID.Clear();
                return;
            }
            else if ((DataValidation.AnyValuesAreNotValid(employeeID.Text, firstName.Text, middleName.Text, lastName.Text,
                                                        addressUnitNum.Text, addressBrgy.Text, addressCity.Text,
                                                        employeePosition.Text, employeeDepartment.Text, employeeCompany.Text)) != "")
            {

                MessageBox.Show(DataValidation.AnyValuesAreNotValid(employeeID.Text, firstName.Text, middleName.Text, lastName.Text,
                                                     addressUnitNum.Text, addressBrgy.Text, addressCity.Text,
                                                     employeePosition.Text, employeeDepartment.Text, employeeCompany.Text), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                db_connect.Open();
                cmd = new MySqlCommand(Queries.UpdateQuery(), db_connect);
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
                ClearForm();
            }

        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {

            db_connect.Open();
            cmd = new MySqlCommand(Queries.DeleteQuery(), db_connect);
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
            ClearForm();


        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            employeeRecordTable.Rows.Clear();

            db_connect.Open();
            employeeRecordTable.Rows.Clear();
            cmd = new MySqlCommand(Queries.SearchQuery(search.Text), db_connect);

            dataRead = cmd.ExecuteReader();
            DATAREAD();

            dataRead.Close();
            db_connect.Close();
        }

        private void EmployeeRecordTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SaveButton.Visible = false;
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;

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



        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            SaveButton.Visible = true;
            SaveButton.Enabled = true;
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
