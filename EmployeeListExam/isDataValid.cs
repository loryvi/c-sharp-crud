using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EmployeeListExam
{
    class isDataValid
    {

        public static bool checkEmployeeIDExist(string searchEmployeeID)
        {
            
            bool duplicate = false;
            MySqlConnection db_connect;
            MySqlCommand cmd;

            Dbconnection dbconn = new Dbconnection();
            
            db_connect = new MySqlConnection(dbconn.dbconnect());


            db_connect.Open();
                      
            cmd = new MySqlCommand("SELECT EXISTS(SELECT COUNT(*) FROM `db_curd` WHERE EmployeeID='" + searchEmployeeID + "')", db_connect);
            cmd.Parameters.Clear();
            object i = cmd.ExecuteScalar();
            if(Convert.ToInt32(i)> 0)
            {
                duplicate = true;
            }
            db_connect.Close();
            return duplicate;
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
