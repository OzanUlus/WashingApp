namespace BA.CarWashingApp.UI
{
    partial class FormLoginMenu
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
            label1 = new System.Windows.Forms.Label();
            panelMenu = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            tboxUserName = new System.Windows.Forms.TextBox();
            tboxPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.HotTrack;
            label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(127, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 58);
            label1.TabIndex = 0;
            label1.Text = "Car Washing \r\nApplication";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Margin = new System.Windows.Forms.Padding(6);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(279, 542);
            panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(279, 100);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            panel2.BackgroundImage = Properties.Resources.icons8_car_wash_501;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(118, 94);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(279, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(689, 100);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(291, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 45);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // tboxUserName
            // 
            tboxUserName.Location = new System.Drawing.Point(476, 206);
            tboxUserName.Name = "tboxUserName";
            tboxUserName.Size = new System.Drawing.Size(309, 33);
            tboxUserName.TabIndex = 2;
            tboxUserName.TextChanged += tboxUserName_TextChanged;
            // 
            // tboxPassword
            // 
            tboxPassword.Location = new System.Drawing.Point(476, 296);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.Size = new System.Drawing.Size(309, 33);
            tboxPassword.TabIndex = 3;
            tboxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(471, 178);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 25);
            label3.TabIndex = 4;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(471, 268);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(653, 375);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(132, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLoginMenu
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(968, 542);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tboxPassword);
            Controls.Add(tboxUserName);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "FormLoginMenu";
            Text = "Login Menu";
            Load += FormLoginMenu_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
    }
}

