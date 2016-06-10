namespace Loaning_materialsApp
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_returnMaterial = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_retrieveQR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_visitorName = new System.Windows.Forms.Label();
            this.bt_clearUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(29, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 528);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Material";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rented to:";
            this.columnHeader6.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 677);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0.00";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader5});
            this.listView2.Location = new System.Drawing.Point(452, 136);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(360, 441);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Material";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity left";
            this.columnHeader5.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Materials loaned";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Materials in stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 651);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Return material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Material ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 51);
            this.button1.TabIndex = 21;
            this.button1.Text = "Loan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_returnMaterial
            // 
            this.bt_returnMaterial.Location = new System.Drawing.Point(737, 677);
            this.bt_returnMaterial.Name = "bt_returnMaterial";
            this.bt_returnMaterial.Size = new System.Drawing.Size(75, 23);
            this.bt_returnMaterial.TabIndex = 26;
            this.bt_returnMaterial.Text = "Return";
            this.bt_returnMaterial.UseVisualStyleBackColor = true;
            this.bt_returnMaterial.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 680);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 27;
            // 
            // bt_retrieveQR
            // 
            this.bt_retrieveQR.Location = new System.Drawing.Point(29, 28);
            this.bt_retrieveQR.Name = "bt_retrieveQR";
            this.bt_retrieveQR.Size = new System.Drawing.Size(530, 62);
            this.bt_retrieveQR.TabIndex = 28;
            this.bt_retrieveQR.Text = "Retrieve QR code";
            this.bt_retrieveQR.UseVisualStyleBackColor = true;
            this.bt_retrieveQR.Click += new System.EventHandler(this.bt_retrieveQR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Current visitor:";
            // 
            // lb_visitorName
            // 
            this.lb_visitorName.AutoSize = true;
            this.lb_visitorName.Location = new System.Drawing.Point(583, 66);
            this.lb_visitorName.Name = "lb_visitorName";
            this.lb_visitorName.Size = new System.Drawing.Size(16, 13);
            this.lb_visitorName.TabIndex = 31;
            this.lb_visitorName.Text = "---";
            // 
            // bt_clearUser
            // 
            this.bt_clearUser.Location = new System.Drawing.Point(684, 28);
            this.bt_clearUser.Name = "bt_clearUser";
            this.bt_clearUser.Size = new System.Drawing.Size(128, 62);
            this.bt_clearUser.TabIndex = 32;
            this.bt_clearUser.Text = "Clear selected visitor";
            this.bt_clearUser.UseVisualStyleBackColor = true;
            this.bt_clearUser.Click += new System.EventHandler(this.bt_clearUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 712);
            this.Controls.Add(this.bt_clearUser);
            this.Controls.Add(this.lb_visitorName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_retrieveQR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_returnMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Loan Materials Stand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_returnMaterial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button bt_retrieveQR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_visitorName;
        private System.Windows.Forms.Button bt_clearUser;
    }
}

