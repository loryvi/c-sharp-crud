using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeListExam
{
     public class Queries
    {
        public string selectQuery()
        {
            string select = "SELECT `EmployeeID`, `FirstName`, `MiddleName`, `LastName`, `birthday`, `addressUnitNum`, `addressBrgy`, `addressCity`, `employeePosition`, `employeeDepartment`, `employeeCompany`, `employeeDateJoined`, `employeeDateLeft` FROM `db_curd`";
            return select;
        }

        public string insertQuery() {
            string insert = "INSERT INTO `db_curd`(`EmployeeID`,`FirstName`,`MiddleName`,`LastName`,`birthday`,`addressUnitNum`,`addressBrgy`,`addressCity`,`employeePosition`,`employeeDepartment`,`employeeCompany`,`employeeDateJoined`,`employeeDateLeft`) " +
                                                    "VALUES (@EmployeeID, @FirstName, @MiddleName, @LastName, @birthday, @addressUnitNum, @addressBrgy, @addressCity, @employeePosition, @employeeDepartment, @employeeCompany, @employeeDateJoined, @employeeDateLeft)";
            return insert;
        }

        public string updateQuery()
        { //cannot change employeeID
            string update = "UPDATE `db_curd` SET `FirstName`=@FirstName,`MiddleName`=@MiddleName,`LastName`=@LastName,`birthday`=@birthday," +
                                                "`addressUnitNum`=@addressUnitNum,`addressBrgy`=@addressBrgy,`addressCity`=@addressCity," +
                                                "`employeePosition`=@employeePosition,`employeeDepartment`=@employeeDepartment,`employeeCompany`=@employeeCompany," +
                                                "`employeeDateJoined`=@employeeDateJoined,`employeeDateLeft`=@employeeDateLeft " +
                                                "WHERE `EmployeeID`=@EmployeeID";
            return update;
        }

        public string deleteQuery()
        {
            string delete = "DELETE From`db_curd` WHERE `EmployeeID`=@EmployeeID";
            return delete;
        }

        public string searchQuery(string searchtext)
        {
            string search = "SELECT `EmployeeID`, `FirstName`, `MiddleName`, `LastName`, `birthday`, `addressUnitNum`, `addressBrgy`, `addressCity`, `employeePosition`, `employeeDepartment`, `employeeCompany`, `employeeDateJoined`, `employeeDateLeft` FROM `db_curd`" +
                 "WHERE EmployeeID like '%" + searchtext + "%'"+
                "or FirstName like '%" + searchtext + "%'" +
                "or MiddleName like '%" + searchtext + "%'" +
                "or LastName like '%" + searchtext + "%'" +
                "or birthday like '%" + searchtext + "%'" +
                "or addressUnitNum like '%" + searchtext + "%'" +
                "or addressBrgy like '%" + searchtext + "%'" +
                "or addressCity like '%" + searchtext + "%'" +
                "or employeePosition like '%" + searchtext + "%'" +
                "or employeeDepartment like '%" + searchtext + "%'" +
                "or employeeCompany like '%" + searchtext + "%'" +
                "or employeeDateJoined like '%" + searchtext + "%'" +
                 "or employeeDateLeft like '%" + searchtext + "%'";
            return search;
        }

        
    }
}
