namespace ExitApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxMatId = new System.Windows.Forms.ListBox();
            this.listBoxMatName = new System.Windows.Forms.ListBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnReturnMoney = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Money balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "material name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "material_id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "return";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxMatId);
            this.groupBox1.Controls.Add(this.listBoxMatName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(39, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaned materials to return";
            // 
            // listBoxMatId
            // 
            this.listBoxMatId.FormattingEnabled = true;
            this.listBoxMatId.ItemHeight = 16;
            this.listBoxMatId.Location = new System.Drawing.Point(132, 48);
            this.listBoxMatId.Name = "listBoxMatId";
            this.listBoxMatId.Size = new System.Drawing.Size(120, 132);
            this.listBoxMatId.TabIndex = 6;
            // 
            // listBoxMatName
            // 
            this.listBoxMatName.FormattingEnabled = true;
            this.listBoxMatName.ItemHeight = 16;
            this.listBoxMatName.Location = new System.Drawing.Point(6, 48);
            this.listBoxMatName.Name = "listBoxMatName";
            this.listBoxMatName.Size = new System.Drawing.Size(120, 132);
            this.listBoxMatName.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(180, 300);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(58, 17);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "balance";
            // 
            // btnReturnMoney
            // 
            this.btnReturnMoney.Location = new System.Drawing.Point(142, 361);
            this.btnReturnMoney.Name = "btnReturnMoney";
            this.btnReturnMoney.Size = new System.Drawing.Size(169, 78);
            this.btnReturnMoney.TabIndex = 7;
            this.btnReturnMoney.Text = "Return money and mark account as invalid";
            this.btnReturnMoney.UseVisualStyleBackColor = true;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(134, 30);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(135, 22);
            this.txtClientID.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 497);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.btnReturnMoney);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxMatId;
        private System.Windows.Forms.ListBox listBoxMatName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnReturnMoney;
        private System.Windows.Forms.TextBox txtClientID;
    }
}

