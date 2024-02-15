using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;

namespace EmployeeListExam
{
     class DataValidation
    {

        public static bool CheckEmployeeIDExist(string searchEmployeeID){
            int result;
            Dbconnection dbconn = new Dbconnection();
            MySqlConnection db_connect = new MySqlConnection(dbconn.dbconnect());
            db_connect.Open();
            MySqlCommand cmd = new MySqlCommand(Queries.SearchDuplicate(searchEmployeeID),db_connect);
            result = (Int32)cmd.ExecuteScalar();
            bool duplicate = (result == 1 ? true : false ); // returned false after 1235
            db_connect.Close();
            return duplicate;
        }

        public static string AnyValuesAreNotValid(string employeeID, string firstName, string middleName, string lastName, string addressUnitNum, string addressBrgy, string addressCity, string employeePosition, string employeeDepartment, string employeeCompany)
        {
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
                return "Fill Required Box!";
            }
            else if (employeeID.Length > 12)
            {
                return "The maximum length for the Employee ID is 12 characters!";
            }
            else if (firstName.Length > 50)
            {
                return "The maximum length for the First Name is 50 characters!";
            }
            else if (middleName.Length > 50)
            {
                return "The maximum length for the Middle Name is 50 characters!";
            }
            else if (lastName.Length > 50)
            {
                return "The maximum length for the Last Name is 50 characters!";
            }
            else if ((addressUnitNum.Length + addressBrgy.Length + addressCity.Length) > 50)
            {
                return "The maximum length for the Address is 50 characters!";
            }
            else if (employeePosition.Length > 50)
            {
                return "The maximum length for the Position is 50 characters!";

            }
            else if (employeeDepartment.Length > 50)
            {
                return "The maximum length for the Department is 50 characters!";

            }
            else if (employeeCompany.Length > 50)
            {
                return "The maximum length for the Company is 50 characters!";

            }
            else
            {
                return "";
            }

        }


    }
}
