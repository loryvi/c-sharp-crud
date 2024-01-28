using MySql.Data.MySqlClient;
using System;


namespace EmployeeListExam
{
    class DataValidation
    {

        public static bool CheckEmployeeIDExist(string searchEmployeeID)
        {

            bool duplicate = false;
            MySqlConnection db_connect;
            MySqlCommand cmd;

            Dbconnection dbconn = new Dbconnection();

            db_connect = new MySqlConnection(dbconn.dbconnect());


            db_connect.Open();

            cmd = new MySqlCommand("SELECT EXISTS(SELECT COUNT(*) FROM `db_curd` WHERE EmployeeID='" + searchEmployeeID + "')", db_connect);
            cmd.Parameters.Clear();
            object j = cmd.ExecuteScalar();
            if (Convert.ToInt32(j) > 0)
            {
                duplicate = true;
            }
            db_connect.Close();
            return duplicate;
        }

        public static bool AnyValuesAreNotValid(string employeeID, string firstName, string middleName, string lastName, string addressUnitNum, string addressBrgy, string addressCity, string employeePosition, string employeeDepartment, string employeeCompany)

        {
                if ((employeeID == string.Empty) ||
                      (firstName == string.Empty) ||
                      (lastName == string.Empty) ||
                      (addressUnitNum == string.Empty) ||
                      (addressBrgy == string.Empty) ||
                      (addressCity == string.Empty) ||
                      (employeePosition == string.Empty) ||
                      (employeeDepartment == string.Empty) ||
                      (employeeCompany == string.Empty))
                {
                    MessageBox.Show("Fill Required Box!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (employeeID.Length > 12)
                {
                    MessageBox.Show("The maximum length for the Employee ID is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else if (firstName.Length > 50)
                {
                    MessageBox.Show("The maximum length for the First Name is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else if (middleName.Length > 50)
                {
                    MessageBox.Show("The maximum length for the Middle Name is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                }
                else if (lastName.Length > 50)
                {
                    MessageBox.Show("The maximum length for the Last Name is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else if ((addressUnitNum.Length + addressBrgy.Length + addressCity.Length) > 50)
                {
                    MessageBox.Show("The maximum length for the Address is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else if (employeePosition.Length > 50)
                {
                    MessageBox.Show("The maximum length for the Position is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else if (employeeDepartment.Length > 50)
                {
                    MessageBox.Show("The maximum length for the Department is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else if (employeeCompany.Length > 50)
                {
                    MessageBox.Show("The maximum length for the Company is 50 characters!", "Warning: Input Max Character!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            return true;
        }


    }
}
