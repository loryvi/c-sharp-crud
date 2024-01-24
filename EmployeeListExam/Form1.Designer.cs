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
            EmployeeIDText = new TextBox();
            FirstNameText = new TextBox();
            label1 = new Label();
            MiddleNameText = new TextBox();
            label2 = new Label();
            LastNameText = new TextBox();
            label3 = new Label();
            BirthdayLabel = new Label();
            birthdayPicker = new DateTimePicker();
            addressLabel = new Label();
            addressUnitNumText = new TextBox();
            unitNumLabel = new Label();
            addressCityLabel = new Label();
            addressBrgyLabel = new Label();
            addressCityText = new TextBox();
            addressBrgyText = new TextBox();
            label4 = new Label();
            employeePositionText = new TextBox();
            positionLabel = new Label();
            employeeDepartmentText = new TextBox();
            departmentLabel = new Label();
            employeeCompanyText = new TextBox();
            companyLabel = new Label();
            employeeDateJoined = new DateTimePicker();
            employeeDateLeft = new DateTimePicker();
            label5 = new Label();
            employeeRecordTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            birthdate = new DataGridViewTextBoxColumn();
            addressBrgy = new DataGridViewTextBoxColumn();
            addressUnitNum = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            employeePosition = new DataGridViewTextBoxColumn();
            employeeDepartment = new DataGridViewTextBoxColumn();
            employeeCompany = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            saveButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            searchTextBox = new TextBox();
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
            // EmployeeIDText
            // 
            EmployeeIDText.Location = new Point(9, 42);
            EmployeeIDText.Name = "EmployeeIDText";
            EmployeeIDText.Size = new Size(117, 23);
            EmployeeIDText.TabIndex = 1;
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(133, 42);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(218, 23);
            FirstNameText.TabIndex = 3;
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
            // MiddleNameText
            // 
            MiddleNameText.Location = new Point(357, 42);
            MiddleNameText.Name = "MiddleNameText";
            MiddleNameText.Size = new Size(200, 23);
            MiddleNameText.TabIndex = 5;
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
            // LastNameText
            // 
            LastNameText.Location = new Point(563, 42);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(225, 23);
            LastNameText.TabIndex = 7;
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
            // addressUnitNumText
            // 
            addressUnitNumText.Location = new Point(272, 86);
            addressUnitNumText.Name = "addressUnitNumText";
            addressUnitNumText.Size = new Size(149, 23);
            addressUnitNumText.TabIndex = 11;
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
            // addressCityText
            // 
            addressCityText.Location = new Point(607, 86);
            addressCityText.Name = "addressCityText";
            addressCityText.Size = new Size(181, 23);
            addressCityText.TabIndex = 17;
            // 
            // addressBrgyText
            // 
            addressBrgyText.Location = new Point(423, 86);
            addressBrgyText.Name = "addressBrgyText";
            addressBrgyText.Size = new Size(182, 23);
            addressBrgyText.TabIndex = 18;
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
            // employeePositionText
            // 
            employeePositionText.Location = new Point(279, 138);
            employeePositionText.Name = "employeePositionText";
            employeePositionText.Size = new Size(163, 23);
            employeePositionText.TabIndex = 24;
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
            // employeeDepartmentText
            // 
            employeeDepartmentText.Location = new Point(133, 138);
            employeeDepartmentText.Name = "employeeDepartmentText";
            employeeDepartmentText.Size = new Size(140, 23);
            employeeDepartmentText.TabIndex = 22;
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
            // employeeCompanyText
            // 
            employeeCompanyText.Location = new Point(9, 138);
            employeeCompanyText.Name = "employeeCompanyText";
            employeeCompanyText.Size = new Size(117, 23);
            employeeCompanyText.TabIndex = 20;
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
            employeeRecordTable.Columns.AddRange(new DataGridViewColumn[] { Column1, EmployeeID, FirstName, MiddleName, LastName, birthdate, addressBrgy, addressUnitNum, City, employeePosition, employeeDepartment, employeeCompany, Column11, Column12 });
            employeeRecordTable.Location = new Point(9, 234);
            employeeRecordTable.Name = "employeeRecordTable";
            employeeRecordTable.ReadOnly = true;
            employeeRecordTable.RowHeadersVisible = false;
            employeeRecordTable.Size = new Size(779, 259);
            employeeRecordTable.TabIndex = 29;
            employeeRecordTable.CellClick += employeeRecordTable_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.HeaderText = "Employee No.";
            EmployeeID.MaxInputLength = 11;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Width = 97;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FirstName.HeaderText = "First Name";
            FirstName.MaxInputLength = 50;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 82;
            // 
            // MiddleName
            // 
            MiddleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MiddleName.HeaderText = "Middle Name";
            MiddleName.MaxInputLength = 50;
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            MiddleName.Width = 96;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LastName.HeaderText = "Last Name";
            LastName.MaxInputLength = 50;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 81;
            // 
            // birthdate
            // 
            birthdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            birthdate.DefaultCellStyle = dataGridViewCellStyle4;
            birthdate.HeaderText = "Birthdate";
            birthdate.Name = "birthdate";
            birthdate.ReadOnly = true;
            birthdate.Width = 80;
            // 
            // addressBrgy
            // 
            addressBrgy.HeaderText = "Brgy";
            addressBrgy.MaxInputLength = 50;
            addressBrgy.Name = "addressBrgy";
            addressBrgy.ReadOnly = true;
            // 
            // addressUnitNum
            // 
            addressUnitNum.HeaderText = "Unit #";
            addressUnitNum.MaxInputLength = 50;
            addressUnitNum.Name = "addressUnitNum";
            addressUnitNum.ReadOnly = true;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MaxInputLength = 50;
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // employeePosition
            // 
            employeePosition.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employeePosition.HeaderText = "Position";
            employeePosition.MaxInputLength = 50;
            employeePosition.Name = "employeePosition";
            employeePosition.ReadOnly = true;
            employeePosition.Width = 75;
            // 
            // employeeDepartment
            // 
            employeeDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employeeDepartment.HeaderText = "Department";
            employeeDepartment.MaxInputLength = 50;
            employeeDepartment.Name = "employeeDepartment";
            employeeDepartment.ReadOnly = true;
            employeeDepartment.Width = 95;
            // 
            // employeeCompany
            // 
            employeeCompany.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employeeCompany.HeaderText = "Company Name";
            employeeCompany.MaxInputLength = 50;
            employeeCompany.Name = "employeeCompany";
            employeeCompany.ReadOnly = true;
            employeeCompany.Width = 109;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            Column11.DefaultCellStyle = dataGridViewCellStyle5;
            Column11.HeaderText = "Date Joined";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 86;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            Column12.DefaultCellStyle = dataGridViewCellStyle6;
            Column12.HeaderText = "Date Left";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 73;
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
            // searchTextBox
            // 
            searchTextBox.Location = new Point(65, 195);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(220, 23);
            searchTextBox.TabIndex = 33;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
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
            Controls.Add(searchTextBox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(saveButton);
            Controls.Add(employeeRecordTable);
            Controls.Add(employeeDateLeft);
            Controls.Add(label5);
            Controls.Add(employeeDateJoined);
            Controls.Add(label4);
            Controls.Add(employeePositionText);
            Controls.Add(positionLabel);
            Controls.Add(employeeDepartmentText);
            Controls.Add(departmentLabel);
            Controls.Add(employeeCompanyText);
            Controls.Add(companyLabel);
            Controls.Add(addressBrgyText);
            Controls.Add(addressCityText);
            Controls.Add(addressBrgyLabel);
            Controls.Add(addressCityLabel);
            Controls.Add(unitNumLabel);
            Controls.Add(addressUnitNumText);
            Controls.Add(addressLabel);
            Controls.Add(birthdayPicker);
            Controls.Add(BirthdayLabel);
            Controls.Add(LastNameText);
            Controls.Add(label3);
            Controls.Add(MiddleNameText);
            Controls.Add(label2);
            Controls.Add(FirstNameText);
            Controls.Add(label1);
            Controls.Add(EmployeeIDText);
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
        private TextBox EmployeeIDText;
        private TextBox FirstNameText;
        private Label label1;
        private TextBox MiddleNameText;
        private Label label2;
        private TextBox LastNameText;
        private Label label3;
        private Label BirthdayLabel;
        private DateTimePicker birthdayPicker;
        private Label addressLabel;
        private TextBox addressUnitNumText;
        private Label unitNumLabel;
        private Label addressCityLabel;
        private Label addressBrgyLabel;
        private TextBox addressCityText;
        private TextBox addressBrgyText;
        private Label label4;
        private TextBox employeePositionText;
        private Label positionLabel;
        private TextBox employeeDepartmentText;
        private Label departmentLabel;
        private TextBox employeeCompanyText;
        private Label companyLabel;
        private DateTimePicker employeeDateJoined;
        private DateTimePicker employeeDateLeft;
        private Label label5;
        private DataGridView employeeRecordTable;
        private Button saveButton;
        private Button editButton;
        private Button deleteButton;
        private TextBox searchTextBox;
        private Label searchLabel;
        private Button clearButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn birthdate;
        private DataGridViewTextBoxColumn addressBrgy;
        private DataGridViewTextBoxColumn addressUnitNum;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn employeePosition;
        private DataGridViewTextBoxColumn employeeDepartment;
        private DataGridViewTextBoxColumn employeeCompany;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
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
    }
}
