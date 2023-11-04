namespace BA.CarWashingApp.UI
{
    partial class App_Settings
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
            CbVehicleType = new System.Windows.Forms.ComboBox();
            lblVehicleType = new System.Windows.Forms.Label();
            tbWashingTime = new System.Windows.Forms.TextBox();
            lblDirtType = new System.Windows.Forms.Label();
            lblRecipes = new System.Windows.Forms.Label();
            lblWashTime = new System.Windows.Forms.Label();
            cbDirtType = new System.Windows.Forms.ComboBox();
            cbRecipes = new System.Windows.Forms.ComboBox();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(326, 703);
            panelMenu.TabIndex = 8;
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
            panel3.Size = new System.Drawing.Size(1196, 115);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(340, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(350, 45);
            label1.TabIndex = 2;
            label1.Text = "Application Settings";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CbVehicleType
            // 
            CbVehicleType.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CbVehicleType.FormattingEnabled = true;
            CbVehicleType.Items.AddRange(new object[] { "SUV", "Sedan", "HB" });
            CbVehicleType.Location = new System.Drawing.Point(608, 180);
            CbVehicleType.Name = "CbVehicleType";
            CbVehicleType.Size = new System.Drawing.Size(301, 37);
            CbVehicleType.TabIndex = 10;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVehicleType.Location = new System.Drawing.Point(480, 183);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new System.Drawing.Size(109, 29);
            lblVehicleType.TabIndex = 11;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // tbWashingTime
            // 
            tbWashingTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbWashingTime.Location = new System.Drawing.Point(608, 371);
            tbWashingTime.Name = "tbWashingTime";
            tbWashingTime.Size = new System.Drawing.Size(301, 36);
            tbWashingTime.TabIndex = 12;
            // 
            // lblDirtType
            // 
            lblDirtType.AutoSize = true;
            lblDirtType.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDirtType.Location = new System.Drawing.Point(507, 252);
            lblDirtType.Name = "lblDirtType";
            lblDirtType.Size = new System.Drawing.Size(82, 29);
            lblDirtType.TabIndex = 13;
            lblDirtType.Text = "Dirt Type";
            // 
            // lblRecipes
            // 
            lblRecipes.AutoSize = true;
            lblRecipes.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRecipes.Location = new System.Drawing.Point(480, 309);
            lblRecipes.Name = "lblRecipes";
            lblRecipes.Size = new System.Drawing.Size(122, 29);
            lblRecipes.TabIndex = 14;
            lblRecipes.Text = "Wash Recipes";
            // 
            // lblWashTime
            // 
            lblWashTime.AutoSize = true;
            lblWashTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWashTime.Location = new System.Drawing.Point(467, 374);
            lblWashTime.Name = "lblWashTime";
            lblWashTime.Size = new System.Drawing.Size(122, 29);
            lblWashTime.TabIndex = 15;
            lblWashTime.Text = "Washing Time";
            // 
            // cbDirtType
            // 
            cbDirtType.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbDirtType.FormattingEnabled = true;
            cbDirtType.Items.AddRange(new object[] { "Very Dirty", "Normal Dirty", "Low Dirty" });
            cbDirtType.Location = new System.Drawing.Point(608, 244);
            cbDirtType.Name = "cbDirtType";
            cbDirtType.Size = new System.Drawing.Size(301, 37);
            cbDirtType.TabIndex = 16;
            // 
            // cbRecipes
            // 
            cbRecipes.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbRecipes.FormattingEnabled = true;
            cbRecipes.Items.AddRange(new object[] { "SUV", "Sedan", "HB" });
            cbRecipes.Location = new System.Drawing.Point(608, 309);
            cbRecipes.Name = "cbRecipes";
            cbRecipes.Size = new System.Drawing.Size(301, 37);
            cbRecipes.TabIndex = 17;
            // 
            // App_Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1522, 703);
            Controls.Add(cbRecipes);
            Controls.Add(cbDirtType);
            Controls.Add(lblWashTime);
            Controls.Add(lblRecipes);
            Controls.Add(lblDirtType);
            Controls.Add(tbWashingTime);
            Controls.Add(lblVehicleType);
            Controls.Add(CbVehicleType);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "App_Settings";
            Text = "App_Settings";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private System.Windows.Forms.ComboBox CbVehicleType;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox tbWashingTime;
        private System.Windows.Forms.Label lblDirtType;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.Label lblWashTime;
        private System.Windows.Forms.ComboBox cbDirtType;
        private System.Windows.Forms.ComboBox cbRecipes;
    }
}