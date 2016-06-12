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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_visitorName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.returnMaterial = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clearUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.retrieveQR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(16, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 528);
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
            this.columnHeader1.Width = 165;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rented to:";
            this.columnHeader6.Width = 212;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 76;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 696);
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
            this.listView2.Location = new System.Drawing.Point(503, 136);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(368, 389);
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
            this.columnHeader4.Width = 133;
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
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Materials loaned";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Materials in stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Return material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Material ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 638);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 699);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Current visitor:";
            // 
            // lb_visitorName
            // 
            this.lb_visitorName.AutoSize = true;
            this.lb_visitorName.Location = new System.Drawing.Point(500, 60);
            this.lb_visitorName.Name = "lb_visitorName";
            this.lb_visitorName.Size = new System.Drawing.Size(16, 13);
            this.lb_visitorName.TabIndex = 31;
            this.lb_visitorName.Text = "---";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.returnMaterial);
            this.groupBox1.Controls.Add(this.loan);
            this.groupBox1.Controls.Add(this.clearUser);
            this.groupBox1.Controls.Add(this.retrieveQR);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lb_visitorName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Location = new System.Drawing.Point(3, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 743);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // returnMaterial
            // 
            this.returnMaterial.Depth = 0;
            this.returnMaterial.Location = new System.Drawing.Point(503, 664);
            this.returnMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.returnMaterial.Name = "returnMaterial";
            this.returnMaterial.Primary = true;
            this.returnMaterial.Size = new System.Drawing.Size(368, 54);
            this.returnMaterial.TabIndex = 36;
            this.returnMaterial.Text = "return material";
            this.returnMaterial.UseVisualStyleBackColor = true;
            this.returnMaterial.Click += new System.EventHandler(this.returnMaterial_Click);
            // 
            // loan
            // 
            this.loan.Depth = 0;
            this.loan.Location = new System.Drawing.Point(503, 549);
            this.loan.MouseState = MaterialSkin.MouseState.HOVER;
            this.loan.Name = "loan";
            this.loan.Primary = true;
            this.loan.Size = new System.Drawing.Size(368, 51);
            this.loan.TabIndex = 35;
            this.loan.Text = "loan";
            this.loan.UseVisualStyleBackColor = true;
            this.loan.Click += new System.EventHandler(this.loan_Click);
            // 
            // clearUser
            // 
            this.clearUser.Depth = 0;
            this.clearUser.Location = new System.Drawing.Point(686, 19);
            this.clearUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearUser.Name = "clearUser";
            this.clearUser.Primary = true;
            this.clearUser.Size = new System.Drawing.Size(185, 62);
            this.clearUser.TabIndex = 34;
            this.clearUser.Text = "clear selected visitor";
            this.clearUser.UseVisualStyleBackColor = true;
            this.clearUser.Click += new System.EventHandler(this.clearUser_Click);
            // 
            // retrieveQR
            // 
            this.retrieveQR.Depth = 0;
            this.retrieveQR.Location = new System.Drawing.Point(16, 19);
            this.retrieveQR.MouseState = MaterialSkin.MouseState.HOVER;
            this.retrieveQR.Name = "retrieveQR";
            this.retrieveQR.Primary = true;
            this.retrieveQR.Size = new System.Drawing.Size(458, 62);
            this.retrieveQR.TabIndex = 33;
            this.retrieveQR.Text = "get user from qr reader";
            this.retrieveQR.UseVisualStyleBackColor = true;
            this.retrieveQR.Click += new System.EventHandler(this.retrieveQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 814);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Loan Materials Stand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_visitorName;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton retrieveQR;
        private MaterialSkin.Controls.MaterialRaisedButton clearUser;
        private MaterialSkin.Controls.MaterialRaisedButton loan;
        private MaterialSkin.Controls.MaterialRaisedButton returnMaterial;
    }
}

