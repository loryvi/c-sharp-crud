# Making a CRUD with C# .NET Winforms User Interface

## Table of contents
 
- [Overview](#overview)
 -[Data](#data) 
 -[Nested Folder](#nestedfolder) 
  - [Screenshot](#screenshot)
  - [CREATE](#links)
  - [READ](#READ)
  - [UPDATE](#update)
  - [DELETE](#delete)
  - [Data Validation](#datavalidation)
- [My process](#my-process)
  - [Built with](#built-with)
  - [What I learned](#what-i-learned)
  - [Continued development](#continued-development)
  - [Useful resources](#useful-resources)

## Overview

A CRUD made of  of a C# .Net Forms.

### Data
** Data with * are mandatory. Numbers inside () are Maximum Length accepted. 

-Data Variables 
 - EmployeeID* (11)
 - FirstName* (50)
 - MiddleName (50)
 - LastName* (50)
 - birthday 
 - addressUnitNum* (50)
 - addressBrgy* (50)
 - addressCity* (50)
 - employeePosition* (50)
 - employeeDepartment* (50)
 - employeeCompany* (50)
 - employeeDateJoined 
 - employeeDateLeft

### Nested Folder
-EmployeeListExam
-README.md
-Images
 -Form1.cs
 -Form1.Designer
 -Form1.resx
 -isDataValid.csd
 -dbconnection.cs
 -queries.cs


### Screenshot
![](images/UserInterface.png)
A screenshot of the user interface when ran. 

![](images/mysql.png)
A screenshot of the connected database from MySQL

## My process

### Create

- add input data to database
```   db_connect.Open();
                    cmd = new MySqlCommand(query.insertQuery(), db_connect);
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
                    clearForm();
```


### Read

```
 //Loads the data from database mySql.
        private void LoadRecord()
        {
            db_connect.Open();
            employeeRecordTable.Rows.Clear();
            cmd = new MySqlCommand(query.selectQuery(), db_connect);

            dataRead = cmd.ExecuteReader();
            DATAREAD();

            dataRead.Close();
            db_connect.Close();
        }
```

### Update 

** Restriction: EmployeeID cannot change.

```//cannot edit EmployeeID
                db_connect.Open();
                cmd = new MySqlCommand(query.updateQuery(), db_connect);
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
                clearForm();
```

### Delete 

```
            db_connect.Open();
            cmd = new MySqlCommand(query.deleteQuery(), db_connect);


            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeIDText.Text); //EmployeeIDText - input

            i = cmd.ExecuteNonQuery(); // execute mysqlcommand. checks if 'Column count doesn't match value count at row 1'

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
```
### What I learned

- Classes
- C# (I am fairly new to c# but I am still learning)
- More OOP

### Continued development

- :bulb: Exception Handling
- :bulb: Make it into a list or a dictionary(key:value)
- :bulb: try to use LINQ
- :bulb: fix interface

### Useful resources
