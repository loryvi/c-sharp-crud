using MySql.Data.MySqlClient;
using System;

namespace EmployeeListExam
{
     class DataValidation
    {

        public static bool CheckEmployeeIDExist(string searchEmployeeID)
        {

            bool duplicate;
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
                duplicate = false;
            }
            else
            {
                duplicate = true;
            }
            db_connect.Close();
            return duplicate;
        }

        public static string AnyValuesAreNotValid(string employeeID, string firstName, string middleName, string lastName, string addressUnitNum, string addressBrgy, string addressCity, string employeePosition, string employeeDepartment, string employeeCompany)

        {
            string message;

            if ((employeeID.Length == 0) ||
                  (firstName.Length == 0) ||
                  (lastName.Length == 0) ||
                  (addressUnitNum.Length == 0) ||
                  (addressBrgy.Length == 0) ||
                  (addressCity.Length == 0) ||
                  (employeePosition.Length == 0) ||
                  (employeeDepartment.Length == 0) ||
                  (employeeCompany.Length == 0))
            {
                message = "Fill Required Box!";
            }
            else if (employeeID.Length > 12)
            {
                message = "The maximum length for the Employee ID is 12 characters!";
            }
            else if (firstName.Length > 50)
            {
                message = "The maximum length for the First Name is 50 characters!";
            }
            else if (middleName.Length > 50)
            {
                message = "The maximum length for the Middle Name is 50 characters!";
            }
            else if (lastName.Length > 50)
            {
                message = "The maximum length for the Last Name is 50 characters!";
            }
            else if ((addressUnitNum.Length + addressBrgy.Length + addressCity.Length) > 50)
            {
                message = "The maximum length for the Address is 50 characters!";
            }
            else if (employeePosition.Length > 50)
            {
                message = "The maximum length for the Position is 50 characters!";

            }
            else if (employeeDepartment.Length > 50)
            {
                message = "The maximum length for the Department is 50 characters!";

            }
            else if (employeeCompany.Length > 50)
            {
                message = "The maximum length for the Company is 50 characters!";

            }
            else
            {
                message = "";
            }

            return message;

        }


    }
}
