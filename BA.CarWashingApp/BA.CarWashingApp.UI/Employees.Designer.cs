namespace BA.CarWashingApp.UI
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cbEmpStatus = new System.Windows.Forms.CheckBox();
            cbEmployeePosition = new System.Windows.Forms.ComboBox();
            mcShiftEnd = new System.Windows.Forms.MonthCalendar();
            label10 = new System.Windows.Forms.Label();
            mcShiftBegin = new System.Windows.Forms.MonthCalendar();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbEmployeeSurname = new System.Windows.Forms.TextBox();
            tbEmployeeName = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tbEmployeeSalary = new System.Windows.Forms.TextBox();
            listBox1 = new System.Windows.Forms.ListBox();
            lblLeaveRequest = new System.Windows.Forms.Label();
            tbLeaveRequest = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tbEmpID = new System.Windows.Forms.TextBox();
            lblEmpID = new System.Windows.Forms.Label();
            btnCreateRequest = new System.Windows.Forms.Button();
            lblAddUserID = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            tbAddUserID = new System.Windows.Forms.TextBox();
            tbWashingID = new System.Windows.Forms.TextBox();
            btnAdd_Employee = new System.Windows.Forms.Button();
            btnListEmployee = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            tbTotalLeave = new System.Windows.Forms.TextBox();
            tbUsedLeave = new System.Windows.Forms.TextBox();
            tbRemainingLeave = new System.Windows.Forms.TextBox();
            btn_Delete_Emp = new System.Windows.Forms.Button();
            btn_Update_emp = new System.Windows.Forms.Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Margin = new System.Windows.Forms.Padding(7);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(326, 1028);
            panelMenu.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(326, 115);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.HotTrack;
            label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(148, 22);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(152, 58);
            label2.TabIndex = 0;
            label2.Text = "Car Washing \r\nApplication";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            panel2.BackgroundImage = Properties.Resources.icons8_car_wash_501;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel2.Location = new System.Drawing.Point(4, 3);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(138, 108);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel3.Controls.Add(label1);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(326, 0);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(2104, 115);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(340, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(201, 45);
            label1.TabIndex = 2;
            label1.Text = "Employees";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEmpStatus);
            groupBox1.Controls.Add(cbEmployeePosition);
            groupBox1.Controls.Add(mcShiftEnd);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(mcShiftBegin);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbEmployeeSurname);
            groupBox1.Controls.Add(tbEmployeeName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbEmployeeSalary);
            groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(370, 154);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(649, 540);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Employee";
            // 
            // cbEmpStatus
            // 
            cbEmpStatus.AutoSize = true;
            cbEmpStatus.Location = new System.Drawing.Point(312, 141);
            cbEmpStatus.Name = "cbEmpStatus";
            cbEmpStatus.Size = new System.Drawing.Size(108, 33);
            cbEmpStatus.TabIndex = 27;
            cbEmpStatus.Text = "Available";
            cbEmpStatus.UseVisualStyleBackColor = true;
            // 
            // cbEmployeePosition
            // 
            cbEmployeePosition.FormattingEnabled = true;
            cbEmployeePosition.Items.AddRange(new object[] { "Resepcion", "Washer " });
            cbEmployeePosition.Location = new System.Drawing.Point(302, 189);
            cbEmployeePosition.Name = "cbEmployeePosition";
            cbEmployeePosition.Size = new System.Drawing.Size(339, 37);
            cbEmployeePosition.TabIndex = 24;
            // 
            // mcShiftEnd
            // 
            mcShiftEnd.Location = new System.Drawing.Point(312, 341);
            mcShiftEnd.Name = "mcShiftEnd";
            mcShiftEnd.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(312, 303);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(93, 29);
            label10.TabIndex = 25;
            label10.Text = "Shift End: ";
            // 
            // mcShiftBegin
            // 
            mcShiftBegin.Location = new System.Drawing.Point(8, 341);
            mcShiftBegin.Name = "mcShiftBegin";
            mcShiftBegin.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(111, 100);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(170, 29);
            label9.TabIndex = 23;
            label9.Text = "Employee Surname:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(121, 192);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(160, 29);
            label7.TabIndex = 21;
            label7.Text = "Employee Position:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(133, 51);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(148, 29);
            label3.TabIndex = 14;
            label3.Text = "Employee Name: ";
            // 
            // tbEmployeeSurname
            // 
            tbEmployeeSurname.Location = new System.Drawing.Point(302, 97);
            tbEmployeeSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbEmployeeSurname.Name = "tbEmployeeSurname";
            tbEmployeeSurname.Size = new System.Drawing.Size(339, 36);
            tbEmployeeSurname.TabIndex = 20;
            // 
            // tbEmployeeName
            // 
            tbEmployeeName.Location = new System.Drawing.Point(302, 48);
            tbEmployeeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbEmployeeName.Name = "tbEmployeeName";
            tbEmployeeName.Size = new System.Drawing.Size(339, 36);
            tbEmployeeName.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(132, 142);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(149, 29);
            label6.TabIndex = 18;
            label6.Text = "Employee Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 303);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 29);
            label5.TabIndex = 16;
            label5.Text = "Shift Begin :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(224, 245);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 29);
            label4.TabIndex = 15;
            label4.Text = "Salary:";
            // 
            // tbEmployeeSalary
            // 
            tbEmployeeSalary.Location = new System.Drawing.Point(302, 238);
            tbEmployeeSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbEmployeeSalary.Name = "tbEmployeeSalary";
            tbEmployeeSalary.Size = new System.Drawing.Size(339, 36);
            tbEmployeeSalary.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new System.Drawing.Point(1065, 152);
            listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(1360, 303);
            listBox1.TabIndex = 9;
            // 
            // lblLeaveRequest
            // 
            lblLeaveRequest.AutoSize = true;
            lblLeaveRequest.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLeaveRequest.Location = new System.Drawing.Point(7, 33);
            lblLeaveRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLeaveRequest.Name = "lblLeaveRequest";
            lblLeaveRequest.Size = new System.Drawing.Size(156, 25);
            lblLeaveRequest.TabIndex = 22;
            lblLeaveRequest.Text = "Leave Request:";
            // 
            // tbLeaveRequest
            // 
            tbLeaveRequest.Location = new System.Drawing.Point(170, 35);
            tbLeaveRequest.Name = "tbLeaveRequest";
            tbLeaveRequest.Size = new System.Drawing.Size(307, 23);
            tbLeaveRequest.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbEmpID);
            groupBox2.Controls.Add(lblEmpID);
            groupBox2.Controls.Add(btnCreateRequest);
            groupBox2.Controls.Add(lblLeaveRequest);
            groupBox2.Controls.Add(tbLeaveRequest);
            groupBox2.Location = new System.Drawing.Point(1138, 561);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(566, 189);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Leave Statue";
            // 
            // tbEmpID
            // 
            tbEmpID.Location = new System.Drawing.Point(170, 73);
            tbEmpID.Name = "tbEmpID";
            tbEmpID.Size = new System.Drawing.Size(307, 23);
            tbEmpID.TabIndex = 32;
            // 
            // lblEmpID
            // 
            lblEmpID.AutoSize = true;
            lblEmpID.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmpID.Location = new System.Drawing.Point(18, 73);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new System.Drawing.Size(146, 25);
            lblEmpID.TabIndex = 31;
            lblEmpID.Text = "Employee ID : ";
            // 
            // btnCreateRequest
            // 
            btnCreateRequest.FlatAppearance.BorderSize = 0;
            btnCreateRequest.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreateRequest.Location = new System.Drawing.Point(443, 121);
            btnCreateRequest.Name = "btnCreateRequest";
            btnCreateRequest.Size = new System.Drawing.Size(100, 51);
            btnCreateRequest.TabIndex = 30;
            btnCreateRequest.Text = "Create Request";
            btnCreateRequest.UseVisualStyleBackColor = true;
            btnCreateRequest.Click += btnCreateRequest_Click;
            // 
            // lblAddUserID
            // 
            lblAddUserID.AutoSize = true;
            lblAddUserID.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAddUserID.Location = new System.Drawing.Point(360, 873);
            lblAddUserID.Name = "lblAddUserID";
            lblAddUserID.Size = new System.Drawing.Size(89, 23);
            lblAddUserID.TabIndex = 31;
            lblAddUserID.Text = "App User ID :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(362, 938);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(87, 23);
            label15.TabIndex = 32;
            label15.Text = "Washing ID :";
            // 
            // tbAddUserID
            // 
            tbAddUserID.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbAddUserID.Location = new System.Drawing.Point(448, 872);
            tbAddUserID.Name = "tbAddUserID";
            tbAddUserID.Size = new System.Drawing.Size(100, 30);
            tbAddUserID.TabIndex = 33;
            // 
            // tbWashingID
            // 
            tbWashingID.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbWashingID.Location = new System.Drawing.Point(448, 931);
            tbWashingID.Name = "tbWashingID";
            tbWashingID.Size = new System.Drawing.Size(100, 30);
            tbWashingID.TabIndex = 34;
            // 
            // btnAdd_Employee
            // 
            btnAdd_Employee.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd_Employee.Location = new System.Drawing.Point(785, 931);
            btnAdd_Employee.Name = "btnAdd_Employee";
            btnAdd_Employee.Size = new System.Drawing.Size(94, 52);
            btnAdd_Employee.TabIndex = 35;
            btnAdd_Employee.Text = "Add";
            btnAdd_Employee.UseVisualStyleBackColor = true;
            btnAdd_Employee.Click += btnAdd_Employee_Click;
            // 
            // btnListEmployee
            // 
            btnListEmployee.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnListEmployee.Location = new System.Drawing.Point(2205, 495);
            btnListEmployee.Name = "btnListEmployee";
            btnListEmployee.Size = new System.Drawing.Size(168, 52);
            btnListEmployee.TabIndex = 36;
            btnListEmployee.Text = "List";
            btnListEmployee.UseVisualStyleBackColor = true;
            btnListEmployee.Click += btnListEmployee_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(370, 727);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(123, 25);
            label8.TabIndex = 37;
            label8.Text = "Total Leave:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(370, 812);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(178, 25);
            label11.TabIndex = 38;
            label11.Text = "Remaining Leave:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(370, 769);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(126, 25);
            label12.TabIndex = 39;
            label12.Text = "Used Leave:";
            // 
            // tbTotalLeave
            // 
            tbTotalLeave.Location = new System.Drawing.Point(560, 727);
            tbTotalLeave.Name = "tbTotalLeave";
            tbTotalLeave.Size = new System.Drawing.Size(307, 23);
            tbTotalLeave.TabIndex = 40;
            // 
            // tbUsedLeave
            // 
            tbUsedLeave.Location = new System.Drawing.Point(560, 771);
            tbUsedLeave.Name = "tbUsedLeave";
            tbUsedLeave.Size = new System.Drawing.Size(307, 23);
            tbUsedLeave.TabIndex = 41;
            // 
            // tbRemainingLeave
            // 
            tbRemainingLeave.Location = new System.Drawing.Point(560, 818);
            tbRemainingLeave.Name = "tbRemainingLeave";
            tbRemainingLeave.Size = new System.Drawing.Size(307, 23);
            tbRemainingLeave.TabIndex = 42;
            // 
            // btn_Delete_Emp
            // 
            btn_Delete_Emp.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Delete_Emp.Location = new System.Drawing.Point(2069, 495);
            btn_Delete_Emp.Name = "btn_Delete_Emp";
            btn_Delete_Emp.Size = new System.Drawing.Size(94, 52);
            btn_Delete_Emp.TabIndex = 43;
            btn_Delete_Emp.Text = "Delete";
            btn_Delete_Emp.UseVisualStyleBackColor = true;
            btn_Delete_Emp.Click += btn_Delete_Emp_Click;
            // 
            // btn_Update_emp
            // 
            btn_Update_emp.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Update_emp.Location = new System.Drawing.Point(906, 931);
            btn_Update_emp.Name = "btn_Update_emp";
            btn_Update_emp.Size = new System.Drawing.Size(105, 52);
            btn_Update_emp.TabIndex = 44;
            btn_Update_emp.Text = "Update";
            btn_Update_emp.UseVisualStyleBackColor = true;
            btn_Update_emp.Click += btn_Update_emp_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2430, 1028);
            Controls.Add(btn_Update_emp);
            Controls.Add(btn_Delete_Emp);
            Controls.Add(tbRemainingLeave);
            Controls.Add(tbUsedLeave);
            Controls.Add(tbTotalLeave);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(btnListEmployee);
            Controls.Add(btnAdd_Employee);
            Controls.Add(tbWashingID);
            Controls.Add(tbAddUserID);
            Controls.Add(label15);
            Controls.Add(lblAddUserID);
            Controls.Add(groupBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbEmployeeSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLeaveRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmployeeSurname;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar mcShiftEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar mcShiftBegin;
        private System.Windows.Forms.TextBox tbLeaveRequest;
        private System.Windows.Forms.ComboBox cbEmployeePosition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAddUserID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbAddUserID;
        private System.Windows.Forms.TextBox tbWashingID;
        private System.Windows.Forms.Button btnAdd_Employee;
        private System.Windows.Forms.Button btnListEmployee;
        private System.Windows.Forms.Button btnCreateRequest;
        private System.Windows.Forms.CheckBox cbEmpStatus;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTotalLeave;
        private System.Windows.Forms.TextBox tbUsedLeave;
        private System.Windows.Forms.TextBox tbRemainingLeave;
        private System.Windows.Forms.Button btn_Delete_Emp;
        private System.Windows.Forms.Button btn_Update_emp;
    }
}