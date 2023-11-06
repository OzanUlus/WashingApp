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
            remaining_time_list = new System.Windows.Forms.ColumnHeader();
            employee_list = new System.Windows.Forms.ColumnHeader();
            btnWashStatusDetail = new System.Windows.Forms.Button();
            listView2 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
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
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { order_no_list, lisance_plate_list, brand_list, model_list, remaining_time_list, employee_list });
            listView1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listView1.Location = new System.Drawing.Point(381, 186);
            listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(703, 276);
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
            lisance_plate_list.Width = 150;
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
            // remaining_time_list
            // 
            remaining_time_list.Text = "Remaining Time";
            remaining_time_list.Width = 150;
            // 
            // employee_list
            // 
            employee_list.Text = "Employee";
            employee_list.Width = 100;
            // 
            // btnWashStatusDetail
            // 
            btnWashStatusDetail.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnWashStatusDetail.Location = new System.Drawing.Point(1146, 413);
            btnWashStatusDetail.Name = "btnWashStatusDetail";
            btnWashStatusDetail.Size = new System.Drawing.Size(114, 49);
            btnWashStatusDetail.TabIndex = 27;
            btnWashStatusDetail.Text = "Detail";
            btnWashStatusDetail.UseVisualStyleBackColor = true;
            btnWashStatusDetail.Click += btnWashStatusDetail_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.Location = new System.Drawing.Point(381, 624);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(703, 244);
            listView2.TabIndex = 28;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Lisance Plate";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Customer ";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dirt Status";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Vehicle Type";
            columnHeader4.Width = 150;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(1297, 413);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(147, 49);
            button1.TabIndex = 29;
            button1.Text = "Vehicle Detail";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(1091, 351);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 29);
            label3.TabIndex = 31;
            label3.Text = "Washing ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(1232, 344);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(212, 36);
            textBox1.TabIndex = 32;
            // 
            // Wash_Status
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1928, 1055);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(btnWashStatusDetail);
            Controls.Add(listView1);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Wash_Status";
            Text = "Wash_Status";
            Load += Wash_Status_Load;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader order_no_list;
        private System.Windows.Forms.ColumnHeader lisance_plate_list;
        private System.Windows.Forms.ColumnHeader brand_list;
        private System.Windows.Forms.ColumnHeader model_list;
        private System.Windows.Forms.ColumnHeader remaining_time_list;
        private System.Windows.Forms.ColumnHeader employee_list;
        private System.Windows.Forms.Button btnWashStatusDetail;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}