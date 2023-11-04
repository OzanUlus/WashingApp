namespace BA.CarWashingApp.UI
{
    partial class Stock
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
            listBox1 = new System.Windows.Forms.ListBox();
            lblMaterialName = new System.Windows.Forms.Label();
            tbMaterialName = new System.Windows.Forms.TextBox();
            lblMaterialStock = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            lblMinStockMaterial = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            gbMaterial = new System.Windows.Forms.GroupBox();
            btnMaterialAdd = new System.Windows.Forms.Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            gbMaterial.SuspendLayout();
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
            panelMenu.Size = new System.Drawing.Size(326, 927);
            panelMenu.TabIndex = 5;
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
            panel3.Size = new System.Drawing.Size(1327, 115);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(340, 22);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 45);
            label1.TabIndex = 2;
            label1.Text = "Stock";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            listBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new System.Drawing.Point(1130, 204);
            listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(403, 395);
            listBox1.TabIndex = 7;
            // 
            // lblMaterialName
            // 
            lblMaterialName.AutoSize = true;
            lblMaterialName.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMaterialName.Location = new System.Drawing.Point(117, 77);
            lblMaterialName.Name = "lblMaterialName";
            lblMaterialName.Size = new System.Drawing.Size(76, 33);
            lblMaterialName.TabIndex = 9;
            lblMaterialName.Text = "Name :";
            // 
            // tbMaterialName
            // 
            tbMaterialName.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbMaterialName.Location = new System.Drawing.Point(232, 70);
            tbMaterialName.Name = "tbMaterialName";
            tbMaterialName.Size = new System.Drawing.Size(202, 40);
            tbMaterialName.TabIndex = 10;
            // 
            // lblMaterialStock
            // 
            lblMaterialStock.AutoSize = true;
            lblMaterialStock.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMaterialStock.Location = new System.Drawing.Point(118, 169);
            lblMaterialStock.Name = "lblMaterialStock";
            lblMaterialStock.Size = new System.Drawing.Size(75, 33);
            lblMaterialStock.TabIndex = 11;
            lblMaterialStock.Text = "Stock :";
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(232, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(202, 40);
            textBox2.TabIndex = 12;
            // 
            // lblMinStockMaterial
            // 
            lblMinStockMaterial.AutoSize = true;
            lblMinStockMaterial.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMinStockMaterial.Location = new System.Drawing.Point(77, 253);
            lblMinStockMaterial.Name = "lblMinStockMaterial";
            lblMinStockMaterial.Size = new System.Drawing.Size(116, 33);
            lblMinStockMaterial.TabIndex = 13;
            lblMinStockMaterial.Text = "Min. Stock :";
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(232, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(202, 40);
            textBox3.TabIndex = 14;
            // 
            // gbMaterial
            // 
            gbMaterial.Controls.Add(btnMaterialAdd);
            gbMaterial.Controls.Add(lblMaterialName);
            gbMaterial.Controls.Add(lblMinStockMaterial);
            gbMaterial.Controls.Add(textBox3);
            gbMaterial.Controls.Add(lblMaterialStock);
            gbMaterial.Controls.Add(tbMaterialName);
            gbMaterial.Controls.Add(textBox2);
            gbMaterial.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gbMaterial.Location = new System.Drawing.Point(403, 204);
            gbMaterial.Name = "gbMaterial";
            gbMaterial.Size = new System.Drawing.Size(527, 383);
            gbMaterial.TabIndex = 15;
            gbMaterial.TabStop = false;
            gbMaterial.Text = "Materials";
            // 
            // btnMaterialAdd
            // 
            btnMaterialAdd.Location = new System.Drawing.Point(380, 305);
            btnMaterialAdd.Name = "btnMaterialAdd";
            btnMaterialAdd.Size = new System.Drawing.Size(107, 58);
            btnMaterialAdd.TabIndex = 16;
            btnMaterialAdd.Text = "Add";
            btnMaterialAdd.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1653, 927);
            Controls.Add(gbMaterial);
            Controls.Add(listBox1);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Stock";
            Text = "Stock";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gbMaterial.ResumeLayout(false);
            gbMaterial.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.TextBox tbMaterialName;
        private System.Windows.Forms.Label lblMaterialStock;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMinStockMaterial;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.Button btnMaterialAdd;
    }
}