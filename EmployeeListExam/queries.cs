namespace EmployeeListExam
{
    public class Queries
    {
        public static string SelectQuery()
        {
            const string select = "SELECT `EmployeeID`, `FirstName`, `MiddleName`, `LastName`, `birthday`, `addressUnitNum`, `addressBrgy`, `addressCity`, `employeePosition`, `employeeDepartment`, `employeeCompany`, `employeeDateJoined`, `employeeDateLeft` FROM `db_curd`";
            return select;
        }

        public static string InsertQuery() {
            const string insert = "INSERT INTO `db_curd`(`EmployeeID`,`FirstName`,`MiddleName`,`LastName`,`birthday`,`addressUnitNum`,`addressBrgy`,`addressCity`,`employeePosition`,`employeeDepartment`,`employeeCompany`,`employeeDateJoined`,`employeeDateLeft`) " +
                                                    "VALUES (@EmployeeID, @FirstName, @MiddleName, @LastName, @birthday, @addressUnitNum, @addressBrgy, @addressCity, @employeePosition, @employeeDepartment, @employeeCompany, @employeeDateJoined, @employeeDateLeft)";
            return insert;
        }

        public static string UpdateQuery()
        { //cannot change employeeID
            const string update = "UPDATE `db_curd` SET `FirstName`=@FirstName,`MiddleName`=@MiddleName,`LastName`=@LastName,`birthday`=@birthday," +
                                                "`addressUnitNum`=@addressUnitNum,`addressBrgy`=@addressBrgy,`addressCity`=@addressCity," +
                                                "`employeePosition`=@employeePosition,`employeeDepartment`=@employeeDepartment,`employeeCompany`=@employeeCompany," +
                                                "`employeeDateJoined`=@employeeDateJoined,`employeeDateLeft`=@employeeDateLeft " +
                                                "WHERE `EmployeeID`=@EmployeeID";
            return update;
        }

        public static string DeleteQuery()
        {
            const string delete = "DELETE From`db_curd` WHERE `EmployeeID`=@EmployeeID";
            return delete;
        }

        public static string SearchQuery(string searchtext)
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
