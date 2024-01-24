# Making a CRUD with C# .NET Winforms User Interface

## Table of contents
 
- [Overview](#overview)
  -[Data](#data) 
  -[Nested Folder](#nestedfolder) 
  -[Classes](#classes) 
  - [Screenshot](#screenshot)
  - [CREATE](#links)
  - [READ](#READ)
  - [UPDATE](#update)
  - [DELETE](#delete)
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
	-addressUnitNum* (50)
	- addressBrgy* (50)
	- addressCity* (50)
	- employeePosition* (50)
	- employeeDepartment* (50)
	- employeeCompany* (50)
	- employeeDateJoined 
	- EmployeeDateLeft

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
![](screenshots/UserInterface.png)
A screenshot of the user interface when ran. 

![](screenshots/mysql.png)
A screenshot of the connected database from MySQL

## My process

### Create

- add input data to database
```  private void saveButton_Click(object sender, EventArgs e)
        {

                if ((EmployeeIDText.Text == string.Empty) ||
                 (FirstNameText.Text == string.Empty) ||
                 (LastNameText.Text == string.Empty) ||
                 (addressUnitNumText.Text == string.Empty) ||
                 (addressBrgyText.Text == string.Empty) ||
                 (addressCityText.Text == string.Empty) ||
                 (employeePositionText.Text == string.Empty) ||
                 (employeeDepartmentText.Text == string.Empty))
                {
                    MessageBox.Show("Warning: Fill Required Box!", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    db_connect.Open();
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
                }


        }
```
- [validation (if input string is empty, maxlength, and is EmployeeID already exist](/queries.cs)

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
