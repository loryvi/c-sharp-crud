using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeListExam
{
    class isDataValid
    {

        public static bool checkEmployeeIDExist(string searchEmployeeID)
        {
            MySqlConnection db_connect;
            Dbconnection dbconn = new Dbconnection();
            db_connect = new MySqlConnection(dbconn.dbconnect());

            MySqlCommand  cmd = new MySqlCommand("SELECT EXISTS(SELECT COUNT (*) FROM `db_curd` WHERE EmployeeID='" + searchEmployeeID + "')", db_connect);
            object i = cmd.ExecuteScalar();
            if (Convert.ToInt32( i) > 0)
            {
                //MessageBox.Show("Warning: Employee ID exist!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                //MessageBox.Show("Warning: Fill Required Box!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static bool checkStringIsNotEmpty(string input)
        {
            return input == string.Empty;
        }
        
        public static bool checkMaxLengthTo50(string input)
        {
            return input.Length >= 50;
            //check if length is more than or equal to 50
        }

        public static bool checkMaxLengthTo12(string input)
        {
            return input.Length >= 12; //check if length more than or equal to 12
        }

        
    }
}
