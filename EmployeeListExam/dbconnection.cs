using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeListExam
{
    public class Dbconnection
    {

        public string dbconnect() {

            //edit the db_connect to your database
            string db_connect = "server=localhost;user=root;password=;database=db_employeeinfo";
            return db_connect;
        }
    }
}
