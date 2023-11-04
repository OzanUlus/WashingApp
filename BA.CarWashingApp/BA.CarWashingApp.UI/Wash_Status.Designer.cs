namespace BA.CarWashingApp.UI
{
    partial class Wash_Status
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
            listView1 = new System.Windows.Forms.ListView();
            order_no_list = new System.Windows.Forms.ColumnHeader();
            lisance_plate_list = new System.Windows.Forms.ColumnHeader();
            brand_list = new System.Windows.Forms.ColumnHeader();
            model_list = new System.Windows.Forms.ColumnHeader();
            washing_type_list = new System.Windows.Forms.ColumnHeader();
            washing_position_list = new System.Windows.Forms.ColumnHeader();
            remaining_time_list = new System.Windows.Forms.ColumnHeader();
            employee_list = new System.Windows.Forms.ColumnHeader();
            gbMaterialRecipe = new System.Windows.Forms.GroupBox();
            tbMaterialID = new System.Windows.Forms.TextBox();
            tbWashingRecipeId = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tbWashingId = new System.Windows.Forms.TextBox();
            tbWashingTypeId = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            btnWashStatusEdit = new System.Windows.Forms.Button();
            btnWashStatusDetail = new System.Windows.Forms.Button();
            btnWashStatusCancel = new System.Windows.Forms.Button();
            btnWashStatusAddTime = new System.Windows.Forms.Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            gbMaterialRecipe.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panelMenu.Size = new System.Drawing.Size(326, 1055);
            panelMenu.TabIndex = 4;
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
            panel3.Size = new System.Drawing.Size(1602, 115);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(340, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 45);
            label1.TabIndex = 2;
            label1.Text = "Wash Status";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { order_no_list, lisance_plate_list, brand_list, model_list, washing_type_list, washing_position_list, remaining_time_list, employee_list });
            listView1.Location = new System.Drawing.Point(381, 463);
            listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(978, 276);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // order_no_list
            // 
            order_no_list.Text = "Order No";
            order_no_list.Width = 100;
            // 
            // lisance_plate_list
            // 
            lisance_plate_list.Text = "Lisance Plate";
            lisance_plate_list.Width = 100;
            // 
            // brand_list
            // 
            brand_list.Text = "Brand";
            brand_list.Width = 100;
            // 
            // model_list
            // 
            model_list.Text = "Model";
            model_list.Width = 100;
            // 
            // washing_type_list
            // 
            washing_type_list.Text = "Washing Type";
            washing_type_list.Width = 100;
            // 
            // washing_position_list
            // 
            washing_position_list.Text = "Washing Position";
            washing_position_list.Width = 100;
            // 
            // remaining_time_list
            // 
            remaining_time_list.Text = "Remaining Time";
            remaining_time_list.Width = 100;
            // 
            // employee_list
            // 
            employee_list.Text = "Employee";
            employee_list.Width = 100;
            // 
            // gbMaterialRecipe
            // 
            gbMaterialRecipe.Controls.Add(tbMaterialID);
            gbMaterialRecipe.Controls.Add(tbWashingRecipeId);
            gbMaterialRecipe.Controls.Add(label10);
            gbMaterialRecipe.Controls.Add(label11);
            gbMaterialRecipe.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gbMaterialRecipe.Location = new System.Drawing.Point(403, 158);
            gbMaterialRecipe.Name = "gbMaterialRecipe";
            gbMaterialRecipe.Size = new System.Drawing.Size(415, 183);
            gbMaterialRecipe.TabIndex = 22;
            gbMaterialRecipe.TabStop = false;
            gbMaterialRecipe.Text = "Material Washing Recipe ";
            // 
            // tbMaterialID
            // 
            tbMaterialID.Location = new System.Drawing.Point(196, 130);
            tbMaterialID.Name = "tbMaterialID";
            tbMaterialID.Size = new System.Drawing.Size(213, 36);
            tbMaterialID.TabIndex = 17;
            // 
            // tbWashingRecipeId
            // 
            tbWashingRecipeId.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbWashingRecipeId.Location = new System.Drawing.Point(196, 61);
            tbWashingRecipeId.Name = "tbWashingRecipeId";
            tbWashingRecipeId.Size = new System.Drawing.Size(213, 36);
            tbWashingRecipeId.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(81, 130);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(109, 29);
            label10.TabIndex = 14;
            label10.Text = "Material ID :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(29, 68);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(161, 29);
            label11.TabIndex = 13;
            label11.Text = "Washing Recipe ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbWashingId);
            groupBox1.Controls.Add(tbWashingTypeId);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(944, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(415, 183);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = " Washing Type Washing";
            // 
            // tbWashingId
            // 
            tbWashingId.Location = new System.Drawing.Point(196, 130);
            tbWashingId.Name = "tbWashingId";
            tbWashingId.Size = new System.Drawing.Size(213, 36);
            tbWashingId.TabIndex = 17;
            // 
            // tbWashingTypeId
            // 
            tbWashingTypeId.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbWashingTypeId.Location = new System.Drawing.Point(196, 61);
            tbWashingTypeId.Name = "tbWashingTypeId";
            tbWashingTypeId.Size = new System.Drawing.Size(213, 36);
            tbWashingTypeId.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(81, 130);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(109, 29);
            label12.TabIndex = 14;
            label12.Text = "Washing ID :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(29, 68);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(143, 29);
            label13.TabIndex = 13;
            label13.Text = "Washing Type ID:";
            label13.Click += label13_Click;
            // 
            // btnWashStatusEdit
            // 
            btnWashStatusEdit.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnWashStatusEdit.Location = new System.Drawing.Point(1426, 668);
            btnWashStatusEdit.Name = "btnWashStatusEdit";
            btnWashStatusEdit.Size = new System.Drawing.Size(114, 54);
            btnWashStatusEdit.TabIndex = 26;
            btnWashStatusEdit.Text = "Edit";
            btnWashStatusEdit.UseVisualStyleBackColor = true;
            // 
            // btnWashStatusDetail
            // 
            btnWashStatusDetail.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnWashStatusDetail.Location = new System.Drawing.Point(1426, 556);
            btnWashStatusDetail.Name = "btnWashStatusDetail";
            btnWashStatusDetail.Size = new System.Drawing.Size(114, 49);
            btnWashStatusDetail.TabIndex = 27;
            btnWashStatusDetail.Text = "Detail";
            btnWashStatusDetail.UseVisualStyleBackColor = true;
            // 
            // btnWashStatusCancel
            // 
            btnWashStatusCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnWashStatusCancel.Location = new System.Drawing.Point(1585, 668);
            btnWashStatusCancel.Name = "btnWashStatusCancel";
            btnWashStatusCancel.Size = new System.Drawing.Size(114, 54);
            btnWashStatusCancel.TabIndex = 28;
            btnWashStatusCancel.Text = "Cancel";
            btnWashStatusCancel.UseVisualStyleBackColor = true;
            // 
            // btnWashStatusAddTime
            // 
            btnWashStatusAddTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnWashStatusAddTime.Location = new System.Drawing.Point(1585, 556);
            btnWashStatusAddTime.Name = "btnWashStatusAddTime";
            btnWashStatusAddTime.Size = new System.Drawing.Size(114, 49);
            btnWashStatusAddTime.TabIndex = 29;
            btnWashStatusAddTime.Text = "Add Time";
            btnWashStatusAddTime.UseVisualStyleBackColor = true;
            // 
            // Wash_Status
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1928, 1055);
            Controls.Add(btnWashStatusAddTime);
            Controls.Add(btnWashStatusCancel);
            Controls.Add(btnWashStatusDetail);
            Controls.Add(btnWashStatusEdit);
            Controls.Add(groupBox1);
            Controls.Add(gbMaterialRecipe);
            Controls.Add(listView1);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Wash_Status";
            Text = "Wash_Status";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gbMaterialRecipe.ResumeLayout(false);
            gbMaterialRecipe.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader order_no_list;
        private System.Windows.Forms.ColumnHeader lisance_plate_list;
        private System.Windows.Forms.ColumnHeader brand_list;
        private System.Windows.Forms.ColumnHeader model_list;
        private System.Windows.Forms.ColumnHeader washing_type_list;
        private System.Windows.Forms.ColumnHeader washing_position_list;
        private System.Windows.Forms.ColumnHeader remaining_time_list;
        private System.Windows.Forms.ColumnHeader employee_list;
        private System.Windows.Forms.GroupBox gbMaterialRecipe;
        private System.Windows.Forms.TextBox tbMaterialID;
        private System.Windows.Forms.TextBox tbWashingRecipeId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbWashingId;
        private System.Windows.Forms.TextBox tbWashingTypeId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnWashStatusEdit;
        private System.Windows.Forms.Button btnWashStatusDetail;
        private System.Windows.Forms.Button btnWashStatusCancel;
        private System.Windows.Forms.Button btnWashStatusAddTime;
    }
}