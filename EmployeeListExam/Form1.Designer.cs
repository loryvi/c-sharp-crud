namespace EmployeeListExam
{
    partial class EmployeeList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            EmployeeID_label = new Label();
            employeeID = new TextBox();
            firstName = new TextBox();
            label1 = new Label();
            middleName = new TextBox();
            label2 = new Label();
            lastName = new TextBox();
            label3 = new Label();
            BirthdayLabel = new Label();
            birthdayPicker = new DateTimePicker();
            addressLabel = new Label();
            addressUnitNum = new TextBox();
            unitNumLabel = new Label();
            addressCityLabel = new Label();
            addressBrgyLabel = new Label();
            addressCity = new TextBox();
            addressBrgy = new TextBox();
            label4 = new Label();
            employeePosition = new TextBox();
            positionLabel = new Label();
            employeeDepartment = new TextBox();
            departmentLabel = new Label();
            employeeCompany = new TextBox();
            companyLabel = new Label();
            employeeDateJoined = new DateTimePicker();
            employeeDateLeft = new DateTimePicker();
            label5 = new Label();
            employeeRecordTable = new DataGridView();
            saveButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            search = new TextBox();
            searchLabel = new Label();
            clearButton = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            employee_ID = new DataGridViewTextBoxColumn();
            employee_FirstName = new DataGridViewTextBoxColumn();
            employee_MiddleName = new DataGridViewTextBoxColumn();
            employee_LastName = new DataGridViewTextBoxColumn();
            employee_birthdate = new DataGridViewTextBoxColumn();
            employee_addressBrgy = new DataGridViewTextBoxColumn();
            employee_addressUnitNum = new DataGridViewTextBoxColumn();
            employee_City = new DataGridViewTextBoxColumn();
            employee_Position = new DataGridViewTextBoxColumn();
            employee_Department = new DataGridViewTextBoxColumn();
            employee_Company = new DataGridViewTextBoxColumn();
            employee_dataJoined = new DataGridViewTextBoxColumn();
            employee_DateJoined = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)employeeRecordTable).BeginInit();
            SuspendLayout();
            // 
            // EmployeeID_label
            // 
            EmployeeID_label.AutoSize = true;
            EmployeeID_label.Location = new Point(22, 25);
            EmployeeID_label.Name = "EmployeeID_label";
            EmployeeID_label.Size = new Size(79, 15);
            EmployeeID_label.TabIndex = 0;
            EmployeeID_label.Text = "Employee ID: ";
            // 
            // employeeID
            // 
            employeeID.Location = new Point(9, 42);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(117, 23);
            employeeID.TabIndex = 1;
            // 
            // firstName
            // 
            firstName.Location = new Point(133, 42);
            firstName.Name = "firstName";
            firstName.Size = new Size(218, 23);
            firstName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name: ";
            // 
            // middleName
            // 
            middleName.Location = new Point(357, 42);
            middleName.Name = "middleName";
            middleName.Size = new Size(200, 23);
            middleName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 26);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "Middle Name: ";
            // 
            // lastName
            // 
            lastName.Location = new Point(563, 42);
            lastName.Name = "lastName";
            lastName.Size = new Size(225, 23);
            lastName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 26);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name:";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Location = new Point(9, 68);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(57, 15);
            BirthdayLabel.TabIndex = 8;
            BirthdayLabel.Text = "Birthday: ";
            // 
            // birthdayPicker
            // 
            birthdayPicker.Location = new Point(9, 86);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(190, 23);
            birthdayPicker.TabIndex = 9;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.Location = new Point(205, 90);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(66, 17);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "ADDRESS:";
            // 
            // addressUnitNum
            // 
            addressUnitNum.Location = new Point(272, 86);
            addressUnitNum.Name = "addressUnitNum";
            addressUnitNum.Size = new Size(149, 23);
            addressUnitNum.TabIndex = 11;
            // 
            // unitNumLabel
            // 
            unitNumLabel.AutoSize = true;
            unitNumLabel.Location = new Point(281, 68);
            unitNumLabel.Name = "unitNumLabel";
            unitNumLabel.Size = new Size(45, 15);
            unitNumLabel.TabIndex = 12;
            unitNumLabel.Text = "Unit #: ";
            // 
            // addressCityLabel
            // 
            addressCityLabel.AutoSize = true;
            addressCityLabel.Location = new Point(621, 68);
            addressCityLabel.Name = "addressCityLabel";
            addressCityLabel.Size = new Size(31, 15);
            addressCityLabel.TabIndex = 14;
            addressCityLabel.Text = "City:";
            // 
            // addressBrgyLabel
            // 
            addressBrgyLabel.AutoSize = true;
            addressBrgyLabel.Location = new Point(430, 68);
            addressBrgyLabel.Name = "addressBrgyLabel";
            addressBrgyLabel.Size = new Size(37, 15);
            addressBrgyLabel.TabIndex = 16;
            addressBrgyLabel.Text = "Brgy: ";
            // 
            // addressCity
            // 
            addressCity.Location = new Point(607, 86);
            addressCity.Name = "addressCity";
            addressCity.Size = new Size(181, 23);
            addressCity.TabIndex = 17;
            // 
            // addressBrgy
            // 
            addressBrgy.Location = new Point(423, 86);
            addressBrgy.Name = "addressBrgy";
            addressBrgy.Size = new Size(182, 23);
            addressBrgy.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 118);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 25;
            label4.Text = "Date Joined:";
            // 
            // employeePosition
            // 
            employeePosition.Location = new Point(279, 138);
            employeePosition.Name = "employeePosition";
            employeePosition.Size = new Size(163, 23);
            employeePosition.TabIndex = 24;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(292, 120);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(53, 15);
            positionLabel.TabIndex = 23;
            positionLabel.Text = "Position:";
            // 
            // employeeDepartment
            // 
            employeeDepartment.Location = new Point(133, 138);
            employeeDepartment.Name = "employeeDepartment";
            employeeDepartment.Size = new Size(140, 23);
            employeeDepartment.TabIndex = 22;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new Point(141, 119);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(73, 15);
            departmentLabel.TabIndex = 21;
            departmentLabel.Text = "Department:";
            // 
            // employeeCompany
            // 
            employeeCompany.Location = new Point(9, 138);
            employeeCompany.Name = "employeeCompany";
            employeeCompany.Size = new Size(117, 23);
            employeeCompany.TabIndex = 20;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new Point(21, 119);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new Size(59, 15);
            companyLabel.TabIndex = 19;
            companyLabel.Text = "Company";
            // 
            // employeeDateJoined
            // 
            employeeDateJoined.Location = new Point(448, 138);
            employeeDateJoined.Name = "employeeDateJoined";
            employeeDateJoined.Size = new Size(168, 23);
            employeeDateJoined.TabIndex = 26;
            // 
            // employeeDateLeft
            // 
            employeeDateLeft.Location = new Point(622, 138);
            employeeDateLeft.Name = "employeeDateLeft";
            employeeDateLeft.Size = new Size(166, 23);
            employeeDateLeft.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(622, 118);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 27;
            label5.Text = "Date Left:";
            // 
            // employeeRecordTable
            // 
            employeeRecordTable.AllowUserToAddRows = false;
            employeeRecordTable.AllowUserToDeleteRows = false;
            employeeRecordTable.BackgroundColor = SystemColors.ControlLightLight;
            employeeRecordTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeRecordTable.Columns.AddRange(new DataGridViewColumn[] { Column1, employee_ID, employee_FirstName, employee_MiddleName, employee_LastName, employee_birthdate, employee_addressBrgy, employee_addressUnitNum, employee_City, employee_Position, employee_Department, employee_Company, employee_dataJoined, employee_DateJoined });
            employeeRecordTable.Location = new Point(9, 234);
            employeeRecordTable.Name = "employeeRecordTable";
            employeeRecordTable.ReadOnly = true;
            employeeRecordTable.RowHeadersVisible = false;
            employeeRecordTable.Size = new Size(779, 259);
            employeeRecordTable.TabIndex = 29;
            employeeRecordTable.CellClick += employeeRecordTable_CellClick;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DeepSkyBlue;
            saveButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(437, 176);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(113, 42);
            saveButton.TabIndex = 30;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.DarkOrange;
            editButton.Font = new Font("Century Gothic", 11.25F);
            editButton.Location = new Point(556, 176);
            editButton.Name = "editButton";
            editButton.Size = new Size(113, 42);
            editButton.TabIndex = 31;
            editButton.Text = "Update";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Century Gothic", 11.25F);
            deleteButton.ForeColor = SystemColors.Window;
            deleteButton.Location = new Point(675, 176);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(113, 42);
            deleteButton.TabIndex = 32;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // search
            // 
            search.Location = new Point(65, 195);
            search.Name = "search";
            search.Size = new Size(220, 23);
            search.TabIndex = 33;
            search.TextChanged += searchTextBox_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(17, 203);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 34;
            searchLabel.Text = "Search";
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Century Gothic", 11.25F);
            clearButton.Location = new Point(369, 176);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(62, 42);
            clearButton.TabIndex = 35;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(10, 5);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 36;
            label6.Text = "* Required ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(10, 24);
            label7.Name = "label7";
            label7.Size = new Size(13, 18);
            label7.TabIndex = 37;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(132, 24);
            label8.Name = "label8";
            label8.Size = new Size(13, 18);
            label8.TabIndex = 38;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(271, 68);
            label9.Name = "label9";
            label9.Size = new Size(13, 18);
            label9.TabIndex = 39;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(563, 25);
            label10.Name = "label10";
            label10.Size = new Size(13, 18);
            label10.TabIndex = 40;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(419, 68);
            label11.Name = "label11";
            label11.Size = new Size(13, 18);
            label11.TabIndex = 41;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(611, 68);
            label12.Name = "label12";
            label12.Size = new Size(13, 18);
            label12.TabIndex = 42;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(10, 120);
            label13.Name = "label13";
            label13.Size = new Size(13, 18);
            label13.TabIndex = 43;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(132, 120);
            label14.Name = "label14";
            label14.Size = new Size(13, 18);
            label14.TabIndex = 44;
            label14.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Anton", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(281, 120);
            label15.Name = "label15";
            label15.Size = new Size(13, 18);
            label15.TabIndex = 45;
            label15.Text = "*";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // employee_ID
            // 
            employee_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_ID.HeaderText = "Employee No.";
            employee_ID.MaxInputLength = 11;
            employee_ID.Name = "employee_ID";
            employee_ID.ReadOnly = true;
            employee_ID.Width = 106;
            // 
            // employee_FirstName
            // 
            employee_FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_FirstName.HeaderText = "First Name";
            employee_FirstName.MaxInputLength = 50;
            employee_FirstName.Name = "employee_FirstName";
            employee_FirstName.ReadOnly = true;
            employee_FirstName.Width = 89;
            // 
            // employee_MiddleName
            // 
            employee_MiddleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_MiddleName.HeaderText = "Middle Name";
            employee_MiddleName.MaxInputLength = 50;
            employee_MiddleName.Name = "employee_MiddleName";
            employee_MiddleName.ReadOnly = true;
            employee_MiddleName.Width = 104;
            // 
            // employee_LastName
            // 
            employee_LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_LastName.HeaderText = "Last Name";
            employee_LastName.MaxInputLength = 50;
            employee_LastName.Name = "employee_LastName";
            employee_LastName.ReadOnly = true;
            employee_LastName.Width = 88;
            // 
            // employee_birthdate
            // 
            employee_birthdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            employee_birthdate.DefaultCellStyle = dataGridViewCellStyle4;
            employee_birthdate.HeaderText = "Birthdate";
            employee_birthdate.Name = "employee_birthdate";
            employee_birthdate.ReadOnly = true;
            employee_birthdate.Width = 80;
            // 
            // employee_addressBrgy
            // 
            employee_addressBrgy.HeaderText = "Brgy";
            employee_addressBrgy.MaxInputLength = 50;
            employee_addressBrgy.Name = "employee_addressBrgy";
            employee_addressBrgy.ReadOnly = true;
            // 
            // employee_addressUnitNum
            // 
            employee_addressUnitNum.HeaderText = "Unit #";
            employee_addressUnitNum.MaxInputLength = 50;
            employee_addressUnitNum.Name = "employee_addressUnitNum";
            employee_addressUnitNum.ReadOnly = true;
            // 
            // employee_City
            // 
            employee_City.HeaderText = "City";
            employee_City.MaxInputLength = 50;
            employee_City.Name = "employee_City";
            employee_City.ReadOnly = true;
            // 
            // employee_Position
            // 
            employee_Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_Position.HeaderText = "Position";
            employee_Position.MaxInputLength = 50;
            employee_Position.Name = "employee_Position";
            employee_Position.ReadOnly = true;
            employee_Position.Width = 75;
            // 
            // employee_Department
            // 
            employee_Department.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_Department.HeaderText = "Department";
            employee_Department.MaxInputLength = 50;
            employee_Department.Name = "employee_Department";
            employee_Department.ReadOnly = true;
            employee_Department.Width = 95;
            // 
            // employee_Company
            // 
            employee_Company.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_Company.HeaderText = "Company Name";
            employee_Company.MaxInputLength = 50;
            employee_Company.Name = "employee_Company";
            employee_Company.ReadOnly = true;
            employee_Company.Width = 109;
            // 
            // employee_dataJoined
            // 
            employee_dataJoined.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            employee_dataJoined.DefaultCellStyle = dataGridViewCellStyle5;
            employee_dataJoined.HeaderText = "Date Joined";
            employee_dataJoined.Name = "employee_dataJoined";
            employee_dataJoined.ReadOnly = true;
            employee_dataJoined.Width = 86;
            // 
            // employee_DateJoined
            // 
            employee_DateJoined.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            employee_DateJoined.DefaultCellStyle = dataGridViewCellStyle6;
            employee_DateJoined.HeaderText = "Date Left";
            employee_DateJoined.Name = "employee_DateJoined";
            employee_DateJoined.ReadOnly = true;
            employee_DateJoined.Width = 73;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 495);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(clearButton);
            Controls.Add(searchLabel);
            Controls.Add(search);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(saveButton);
            Controls.Add(employeeRecordTable);
            Controls.Add(employeeDateLeft);
            Controls.Add(label5);
            Controls.Add(employeeDateJoined);
            Controls.Add(label4);
            Controls.Add(employeePosition);
            Controls.Add(positionLabel);
            Controls.Add(employeeDepartment);
            Controls.Add(departmentLabel);
            Controls.Add(employeeCompany);
            Controls.Add(companyLabel);
            Controls.Add(addressBrgy);
            Controls.Add(addressCity);
            Controls.Add(addressBrgyLabel);
            Controls.Add(addressCityLabel);
            Controls.Add(unitNumLabel);
            Controls.Add(addressUnitNum);
            Controls.Add(addressLabel);
            Controls.Add(birthdayPicker);
            Controls.Add(BirthdayLabel);
            Controls.Add(lastName);
            Controls.Add(label3);
            Controls.Add(middleName);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(label1);
            Controls.Add(employeeID);
            Controls.Add(EmployeeID_label);
            Name = "EmployeeList";
            Text = "EmployeeList";
            Load += EmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)employeeRecordTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmployeeID_label;
        private TextBox employeeID;
        private TextBox firstName;
        private Label label1;
        private TextBox middleName;
        private Label label2;
        private TextBox lastName;
        private Label label3;
        private Label BirthdayLabel;
        private DateTimePicker birthdayPicker;
        private Label addressLabel;
        private TextBox addressUnitNum;
        private Label unitNumLabel;
        private Label addressCityLabel;
        private Label addressBrgyLabel;
        private TextBox addressCity;
        private TextBox addressBrgy;
        private Label label4;
        private TextBox employeePosition;
        private Label positionLabel;
        private TextBox employeeDepartment;
        private Label departmentLabel;
        private TextBox employeeCompany;
        private Label companyLabel;
        private DateTimePicker employeeDateJoined;
        private DateTimePicker employeeDateLeft;
        private Label label5;
        private DataGridView employeeRecordTable;
        private Button saveButton;
        private Button editButton;
        private Button deleteButton;
        private TextBox search;
        private Label searchLabel;
        private Button clearButton;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn employee_ID;
        private DataGridViewTextBoxColumn employee_FirstName;
        private DataGridViewTextBoxColumn employee_MiddleName;
        private DataGridViewTextBoxColumn employee_LastName;
        private DataGridViewTextBoxColumn employee_birthdate;
        private DataGridViewTextBoxColumn employee_addressBrgy;
        private DataGridViewTextBoxColumn employee_addressUnitNum;
        private DataGridViewTextBoxColumn employee_City;
        private DataGridViewTextBoxColumn employee_Position;
        private DataGridViewTextBoxColumn employee_Department;
        private DataGridViewTextBoxColumn employee_Company;
        private DataGridViewTextBoxColumn employee_dataJoined;
        private DataGridViewTextBoxColumn employee_DateJoined;
    }
}
