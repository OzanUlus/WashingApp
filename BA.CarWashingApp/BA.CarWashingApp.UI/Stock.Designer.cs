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
            tbMaterialStock = new System.Windows.Forms.TextBox();
            lblMinStockMaterial = new System.Windows.Forms.Label();
            tbMaterialMinStock = new System.Windows.Forms.TextBox();
            gbMaterial = new System.Windows.Forms.GroupBox();
            btnMaterialAdd = new System.Windows.Forms.Button();
            btnMaterialDelete = new System.Windows.Forms.Button();
            btnControl = new System.Windows.Forms.Button();
            btnListMaterial = new System.Windows.Forms.Button();
            tbcontrol = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            gbMaterial.SuspendLayout();
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
            listBox1.Location = new System.Drawing.Point(1077, 227);
            listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(474, 372);
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
            // tbMaterialStock
            // 
            tbMaterialStock.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbMaterialStock.Location = new System.Drawing.Point(232, 162);
            tbMaterialStock.Name = "tbMaterialStock";
            tbMaterialStock.Size = new System.Drawing.Size(202, 40);
            tbMaterialStock.TabIndex = 12;
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
            // tbMaterialMinStock
            // 
            tbMaterialMinStock.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbMaterialMinStock.Location = new System.Drawing.Point(232, 250);
            tbMaterialMinStock.Name = "tbMaterialMinStock";
            tbMaterialMinStock.Size = new System.Drawing.Size(202, 40);
            tbMaterialMinStock.TabIndex = 14;
            // 
            // gbMaterial
            // 
            gbMaterial.Controls.Add(btnMaterialAdd);
            gbMaterial.Controls.Add(lblMaterialName);
            gbMaterial.Controls.Add(lblMinStockMaterial);
            gbMaterial.Controls.Add(tbMaterialMinStock);
            gbMaterial.Controls.Add(lblMaterialStock);
            gbMaterial.Controls.Add(tbMaterialName);
            gbMaterial.Controls.Add(tbMaterialStock);
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
            btnMaterialAdd.Location = new System.Drawing.Point(356, 306);
            btnMaterialAdd.Name = "btnMaterialAdd";
            btnMaterialAdd.Size = new System.Drawing.Size(78, 49);
            btnMaterialAdd.TabIndex = 16;
            btnMaterialAdd.Text = "Add";
            btnMaterialAdd.UseVisualStyleBackColor = true;
            btnMaterialAdd.Click += btnMaterialAdd_Click;
            // 
            // btnMaterialDelete
            // 
            btnMaterialDelete.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMaterialDelete.Location = new System.Drawing.Point(1451, 628);
            btnMaterialDelete.Name = "btnMaterialDelete";
            btnMaterialDelete.Size = new System.Drawing.Size(100, 49);
            btnMaterialDelete.TabIndex = 17;
            btnMaterialDelete.Text = "Delete";
            btnMaterialDelete.UseVisualStyleBackColor = true;
            btnMaterialDelete.Click += btnMaterialDelete_Click;
            // 
            // btnControl
            // 
            btnControl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnControl.Location = new System.Drawing.Point(129, 109);
            btnControl.Name = "btnControl";
            btnControl.Size = new System.Drawing.Size(92, 32);
            btnControl.TabIndex = 17;
            btnControl.Text = "Control";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // btnListMaterial
            // 
            btnListMaterial.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnListMaterial.Location = new System.Drawing.Point(1327, 629);
            btnListMaterial.Name = "btnListMaterial";
            btnListMaterial.Size = new System.Drawing.Size(92, 49);
            btnListMaterial.TabIndex = 18;
            btnListMaterial.Text = "List";
            btnListMaterial.UseVisualStyleBackColor = true;
            btnListMaterial.Click += btnListMaterial_Click;
            // 
            // tbcontrol
            // 
            tbcontrol.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbcontrol.Location = new System.Drawing.Point(37, 68);
            tbcontrol.Name = "tbcontrol";
            tbcontrol.Size = new System.Drawing.Size(184, 35);
            tbcontrol.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbcontrol);
            groupBox1.Controls.Add(btnControl);
            groupBox1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(687, 669);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(243, 160);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control Material";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(37, 40);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 25);
            label3.TabIndex = 21;
            label3.Text = "Name";
            // 
            // Stock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1653, 927);
            Controls.Add(groupBox1);
            Controls.Add(btnListMaterial);
            Controls.Add(btnMaterialDelete);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.TextBox tbMaterialName;
        private System.Windows.Forms.Label lblMaterialStock;
        private System.Windows.Forms.TextBox tbMaterialStock;
        private System.Windows.Forms.Label lblMinStockMaterial;
        private System.Windows.Forms.TextBox tbMaterialMinStock;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.Button btnMaterialAdd;
        private System.Windows.Forms.Button btnMaterialDelete;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnListMaterial;
        private System.Windows.Forms.TextBox tbcontrol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}