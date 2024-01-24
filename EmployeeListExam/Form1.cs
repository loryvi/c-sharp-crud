using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
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

        public EmployeeList()
        {
            InitializeComponent();
            db_connect = new MySqlConnection(dbconn.dbconnect());
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }


        //Loads the data from database mySql.
        private void LoadRecord()
        {
            db_connect.Open();
            employeeRecordTable.Rows.Clear();
            cmd = new MySqlCommand("SELECT `EmployeeID`, `FirstName`, `MiddleName`, `LastName`, `birthday`, `addressUnitNum`, `addressBrgy`, `addressCity`, `employeePosition`, `employeeDepartment`, `employeeCompany`, `employeeDateJoined`, `employeeDateLeft` FROM `db_curd`", db_connect);

                dataRead = cmd.ExecuteReader();
                while (dataRead.Read())
                {
                    employeeRecordTable.Rows.Add(employeeRecordTable.Rows.Count + 1, dataRead["EmployeeID"].ToString(),
                                                                         dataRead["LastName"].ToString(),
                                                                         dataRead["FirstName"].ToString(),
                                                                         dataRead["MiddleName"].ToString(),
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
                
             dataRead.Close();
             db_connect.Close();
            

        }

        public void clearForm()
        {
            EmployeeIDText.Clear();
            FirstNameText.Clear();
            MiddleNameText.Clear();
            LastNameText.Clear();
            birthdayPicker.Value = DateTime.Now;
            addressUnitNumText.Clear();
            addressBrgyText.Clear();
            addressCityText.Clear();
            employeePositionText.Clear();
            employeeDepartmentText.Clear();
            employeeCompanyText.Clear();
            employeeDateJoined.Value = DateTime.Now;
            employeeDateLeft.Value = DateTime.Now;
        }


        //save and save the input data
        private void saveButton_Click(object sender, EventArgs e)
        {
            if ((EmployeeIDText.Text == string.Empty) ||
               (FirstNameText.Text == string.Empty) ||
               (LastNameText.Text == string.Empty) ||
               (addressUnitNumText.Text == string.Empty) ||
               (addressBrgyText.Text == string.Empty) ||
               (addressCityText.Text == string.Empty) ||
               (employeePositionText.Text == string.Empty) ||
               (employeeDepartmentText.Text == string.Empty) ||
               (employeeCompanyText.Text == string.Empty))
            {
                MessageBox.Show("Warning: Fill Required Box!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                string birthday = birthdayPicker.Value.ToString("yyyy-MM-dd"); //saves birthdayPicker string to birthday in MYSQl;
                string date_joined = employeeDateJoined.Value.ToString("yyyy-MM-dd");
                string date_left = employeeDateLeft.Value.ToString("yyyy-MM-dd");
                db_connect.Open();
                cmd = new MySqlCommand("INSERT INTO `db_curd`(`EmployeeID`,`FirstName`,`MiddleName`,`LastName`,`birthday`,`addressUnitNum`,`addressBrgy`,`addressCity`,`employeePosition`,`employeeDepartment`,`employeeCompany`,`employeeDateJoined`,`employeeDateLeft`) " +
                                                    "VALUES (@EmployeeID, @FirstName, @MiddleName, @LastName, @birthday, @addressUnitNum, @addressBrgy, @addressCity, @employeePosition, @employeeDepartment, @employeeCompany, @employeeDateJoined, @employeeDateLeft)"
                                                    , db_connect);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeIDText.Text); //EmployeeIDText - input
                cmd.Parameters.AddWithValue("@FirstName", FirstNameText.Text);
                cmd.Parameters.AddWithValue("@MiddleName", MiddleNameText.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNameText.Text);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@addressUnitNum", addressUnitNumText.Text);
                cmd.Parameters.AddWithValue("@addressBrgy", addressBrgyText.Text);
                cmd.Parameters.AddWithValue("@addressCity", addressCityText.Text);
                cmd.Parameters.AddWithValue("@employeePosition", employeePositionText.Text);
                cmd.Parameters.AddWithValue("@employeeDepartment", employeeDepartmentText.Text);
                cmd.Parameters.AddWithValue("@employeeCompany", employeeCompanyText.Text);
                cmd.Parameters.AddWithValue("@employeeDateJoined", date_joined);
                cmd.Parameters.AddWithValue("@employeeDateLeft", date_left);

                i = cmd.ExecuteNonQuery(); // execute mysqlcommand. //MySql.Data.MySqlClient.MySqlException: 'if Column count match value count at row 1'

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
            try
            {
                string birthday = birthdayPicker.Value.ToString("yyyy-MM-dd"); //saves birthdayPicker string to birthday in MYSQl;
                string date_joined = employeeDateJoined.Value.ToString("yyyy-MM-dd");
                string date_left = employeeDateLeft.Value.ToString("yyyy-MM-dd");
                db_connect.Open();
                cmd = new MySqlCommand("UPDATE `db_curd` SET `FirstName`=@FirstName,`MiddleName`=@MiddleName,`LastName=@LastName`,`birthday`=@birthday," +
                                                            "`addressUnitNum`=@addressUnitNum,`addressBrgy`=@addressBrgy,`addressCity`=@addressCity," +
                                                            "`employeePosition`=@employeePosition,`employeeDepartment`=@employeeDepartment,`employeeCompany`=employeeCompany," +
                                                            "`employeeDateJoined`=@employeeDateJoined,`employeeDateLeft`=@employeeDateLeft WHERE `EmployeeID`=@EmployeeID", db_connect);


                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@FirstName", FirstNameText.Text);
                cmd.Parameters.AddWithValue("@MiddleName", MiddleNameText.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNameText.Text);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@addressUnitNum", addressUnitNumText.Text);
                cmd.Parameters.AddWithValue("@addressBrgy", addressBrgyText.Text);
                cmd.Parameters.AddWithValue("@addressCity", addressCityText.Text);
                cmd.Parameters.AddWithValue("@employeePosition", employeePositionText.Text);
                cmd.Parameters.AddWithValue("@employeeDepartment", employeeDepartmentText.Text);
                cmd.Parameters.AddWithValue("@employeeCompany", employeeCompanyText.Text);
                cmd.Parameters.AddWithValue("@employeeDateJoined", date_joined);
                cmd.Parameters.AddWithValue("@employeeDateLeft", date_left);
               // cmd.Parameters.AddWithValue("@EmployeeID", EmployeeIDText.Text); //EmployeeIDText - input

                i = cmd.ExecuteNonQuery(); // execute mysqlcommand. //MySql.Data.MySqlClient.MySqlException: 'Column count doesn't match value count at row 1'

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
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Edit", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {

            db_connect.Open();
            cmd = new MySqlCommand("DELETE From`db_curd` WHERE `EmployeeID`=@EmployeeID", db_connect);


            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeIDText.Text); //EmployeeIDText - input

            i = cmd.ExecuteNonQuery(); // execute mysqlcommand. //MySql.Data.MySqlClient.MySqlException: 'Column count doesn't match value count at row 1'

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

        private void employeeRecordTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeIDText.Text = employeeRecordTable.CurrentRow.Cells[1].Value.ToString();
            FirstNameText.Text = employeeRecordTable.CurrentRow.Cells[2].Value.ToString();
            MiddleNameText.Text = employeeRecordTable.CurrentRow.Cells[3].Value.ToString();
            LastNameText.Text = employeeRecordTable.CurrentRow.Cells[4].Value.ToString();
            birthdayPicker.Text = employeeRecordTable.CurrentRow.Cells[5].Value.ToString();
            addressUnitNumText.Text = employeeRecordTable.CurrentRow.Cells[6].Value.ToString();
            addressBrgyText.Text = employeeRecordTable.CurrentRow.Cells[7].Value.ToString();
            addressCityText.Text = employeeRecordTable.CurrentRow.Cells[8].Value.ToString();
            employeePositionText.Text = employeeRecordTable.CurrentRow.Cells[9].Value.ToString();
            employeeDepartmentText.Text = employeeRecordTable.CurrentRow.Cells[10].Value.ToString();
            employeeCompanyText.Text = employeeRecordTable.CurrentRow.Cells[11].Value.ToString();
            employeeDateJoined.Text = employeeRecordTable.CurrentRow.Cells[12].Value.ToString();
            employeeDateLeft.Text = employeeRecordTable.CurrentRow.Cells[13].Value.ToString();

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            employeeRecordTable.Rows.Clear();

            db_connect.Open();
            employeeRecordTable.Rows.Clear();
            cmd = new MySqlCommand("SELECT `EmployeeID`, `FirstName`, `MiddleName`, `LastName`, `birthday`, `addressUnitNum`, `addressBrgy`, `addressCity`, `employeePosition`, `employeeDepartment`, `employeeCompany`, `employeeDateJoined`, `employeeDateLeft` FROM `db_curd`" +
                                   "WHERE employeeID like '%"+ searchTextBox.Text +"%'" +
                                      "or FirstName like '%"+ searchTextBox.Text +"%'"+
                                      "or MiddleName like '%" + searchTextBox.Text + "%'"+
                                      "or LastName like '%" + searchTextBox.Text + "%'",db_connect);

            dataRead = cmd.ExecuteReader();
            while (dataRead.Read())
            {
                employeeRecordTable.Rows.Add(employeeRecordTable.Rows.Count + 1, dataRead["EmployeeID"].ToString(),
                                                                     dataRead["LastName"].ToString(),
                                                                     dataRead["FirstName"].ToString(),
                                                                     dataRead["MiddleName"].ToString(),
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

            dataRead.Close();
            db_connect.Close();
        }
    }

}
        
