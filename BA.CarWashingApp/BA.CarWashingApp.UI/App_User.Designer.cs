namespace BA.CarWashingApp.UI
{
    partial class App_User
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
            lblUserName = new System.Windows.Forms.Label();
            tbUserName = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            tbPassword = new System.Windows.Forms.TextBox();
            cbRole = new System.Windows.Forms.ComboBox();
            lblRole = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            gbAddRole = new System.Windows.Forms.GroupBox();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            gbAddRole.SuspendLayout();
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
            panelMenu.Size = new System.Drawing.Size(326, 952);
            panelMenu.TabIndex = 7;
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
            panel3.Size = new System.Drawing.Size(1344, 115);
            panel3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(340, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(293, 45);
            label1.TabIndex = 2;
            label1.Text = "Application User";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUserName.Location = new System.Drawing.Point(125, 88);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(121, 35);
            lblUserName.TabIndex = 9;
            lblUserName.Text = "UserName: ";
            lblUserName.Click += label3_Click;
            // 
            // tbUserName
            // 
            tbUserName.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbUserName.Location = new System.Drawing.Point(252, 88);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new System.Drawing.Size(206, 42);
            tbUserName.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(125, 157);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(118, 35);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password: ";
            // 
            // tbPassword
            // 
            tbPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbPassword.Location = new System.Drawing.Point(252, 157);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(206, 42);
            tbPassword.TabIndex = 12;
            // 
            // cbRole
            // 
            cbRole.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new System.Drawing.Point(252, 244);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(206, 48);
            cbRole.TabIndex = 13;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRole.Location = new System.Drawing.Point(177, 250);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(66, 35);
            lblRole.TabIndex = 14;
            lblRole.Text = "Role: ";
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(366, 345);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(92, 56);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbAddRole
            // 
            gbAddRole.Controls.Add(btnAdd);
            gbAddRole.Controls.Add(lblRole);
            gbAddRole.Controls.Add(cbRole);
            gbAddRole.Controls.Add(tbPassword);
            gbAddRole.Controls.Add(lblPassword);
            gbAddRole.Controls.Add(tbUserName);
            gbAddRole.Controls.Add(lblUserName);
            gbAddRole.Location = new System.Drawing.Point(468, 226);
            gbAddRole.Name = "gbAddRole";
            gbAddRole.Size = new System.Drawing.Size(670, 482);
            gbAddRole.TabIndex = 16;
            gbAddRole.TabStop = false;
            // 
            // App_User
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1670, 952);
            Controls.Add(gbAddRole);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "App_User";
            Text = "App_User";
            Load += App_User_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gbAddRole.ResumeLayout(false);
            gbAddRole.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAddRole;
    }
}