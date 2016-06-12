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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnReturnMoney = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.gbVisitorStatus = new System.Windows.Forms.GroupBox();
            this.btRetrieveQRData = new System.Windows.Forms.Button();
            this.lbHasLeft = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.liVisitors = new System.Windows.Forms.ListBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btClearResult = new System.Windows.Forms.Button();
            this.tbSearchLastname = new System.Windows.Forms.TextBox();
            this.lbMoneyTransferred = new System.Windows.Forms.Label();
            this.lbMoneySpentFood = new System.Windows.Forms.Label();
            this.lbHasEntered = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbVisitorStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "material name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "material_id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(622, 236);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(603, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaned materials to return";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(34, 49);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 132);
            this.listBox1.TabIndex = 5;
            // 
            // btnReturnMoney
            // 
            this.btnReturnMoney.Location = new System.Drawing.Point(656, 453);
            this.btnReturnMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnMoney.Name = "btnReturnMoney";
            this.btnReturnMoney.Size = new System.Drawing.Size(168, 78);
            this.btnReturnMoney.TabIndex = 7;
            this.btnReturnMoney.Text = "Return money and mark account as invalid";
            this.btnReturnMoney.UseVisualStyleBackColor = true;
            this.btnReturnMoney.Click += new System.EventHandler(this.btnReturnMoney_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(622, 195);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(74, 36);
            this.btnLoan.TabIndex = 8;
            this.btnLoan.Text = "Check";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // gbVisitorStatus
            // 
            this.gbVisitorStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbVisitorStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbVisitorStatus.Controls.Add(this.btRetrieveQRData);
            this.gbVisitorStatus.Controls.Add(this.lbHasLeft);
            this.gbVisitorStatus.Controls.Add(this.label15);
            this.gbVisitorStatus.Controls.Add(this.lbPhoneNumber);
            this.gbVisitorStatus.Controls.Add(this.label14);
            this.gbVisitorStatus.Controls.Add(this.liVisitors);
            this.gbVisitorStatus.Controls.Add(this.btSearch);
            this.gbVisitorStatus.Controls.Add(this.btClearResult);
            this.gbVisitorStatus.Controls.Add(this.tbSearchLastname);
            this.gbVisitorStatus.Controls.Add(this.lbMoneyTransferred);
            this.gbVisitorStatus.Controls.Add(this.lbMoneySpentFood);
            this.gbVisitorStatus.Controls.Add(this.lbHasEntered);
            this.gbVisitorStatus.Controls.Add(this.lbMoney);
            this.gbVisitorStatus.Controls.Add(this.lbEmail);
            this.gbVisitorStatus.Controls.Add(this.label6);
            this.gbVisitorStatus.Controls.Add(this.label5);
            this.gbVisitorStatus.Controls.Add(this.label1);
            this.gbVisitorStatus.Controls.Add(this.label2);
            this.gbVisitorStatus.Controls.Add(this.label7);
            this.gbVisitorStatus.Controls.Add(this.label8);
            this.gbVisitorStatus.Controls.Add(this.lbLastname);
            this.gbVisitorStatus.Location = new System.Drawing.Point(13, 13);
            this.gbVisitorStatus.Margin = new System.Windows.Forms.Padding(4);
            this.gbVisitorStatus.Name = "gbVisitorStatus";
            this.gbVisitorStatus.Padding = new System.Windows.Forms.Padding(4);
            this.gbVisitorStatus.Size = new System.Drawing.Size(572, 693);
            this.gbVisitorStatus.TabIndex = 9;
            this.gbVisitorStatus.TabStop = false;
            this.gbVisitorStatus.Text = "Visitor Status";
            // 
            // btRetrieveQRData
            // 
            this.btRetrieveQRData.Location = new System.Drawing.Point(8, 23);
            this.btRetrieveQRData.Margin = new System.Windows.Forms.Padding(4);
            this.btRetrieveQRData.Name = "btRetrieveQRData";
            this.btRetrieveQRData.Size = new System.Drawing.Size(556, 71);
            this.btRetrieveQRData.TabIndex = 22;
            this.btRetrieveQRData.Text = "Retrieve ID from QR reader";
            this.btRetrieveQRData.UseVisualStyleBackColor = true;
            this.btRetrieveQRData.Click += new System.EventHandler(this.btRetrieveQRData_Click);
            // 
            // lbHasLeft
            // 
            this.lbHasLeft.AutoSize = true;
            this.lbHasLeft.Location = new System.Drawing.Point(196, 293);
            this.lbHasLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHasLeft.Name = "lbHasLeft";
            this.lbHasLeft.Size = new System.Drawing.Size(23, 17);
            this.lbHasLeft.TabIndex = 21;
            this.lbHasLeft.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 293);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "has left:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(196, 182);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(23, 17);
            this.lbPhoneNumber.TabIndex = 19;
            this.lbPhoneNumber.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 182);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "phone number:";
            // 
            // liVisitors
            // 
            this.liVisitors.FormattingEnabled = true;
            this.liVisitors.ItemHeight = 16;
            this.liVisitors.Location = new System.Drawing.Point(8, 522);
            this.liVisitors.Margin = new System.Windows.Forms.Padding(4);
            this.liVisitors.Name = "liVisitors";
            this.liVisitors.Size = new System.Drawing.Size(555, 100);
            this.liVisitors.TabIndex = 17;
            this.liVisitors.SelectedIndexChanged += new System.EventHandler(this.liVisitors_SelectedIndexChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(8, 473);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(556, 42);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btClearResult
            // 
            this.btClearResult.Location = new System.Drawing.Point(8, 630);
            this.btClearResult.Margin = new System.Windows.Forms.Padding(4);
            this.btClearResult.Name = "btClearResult";
            this.btClearResult.Size = new System.Drawing.Size(556, 46);
            this.btClearResult.TabIndex = 15;
            this.btClearResult.Text = "Clear result";
            this.btClearResult.UseVisualStyleBackColor = true;
            this.btClearResult.Click += new System.EventHandler(this.btClearResult_Click);
            // 
            // tbSearchLastname
            // 
            this.tbSearchLastname.Location = new System.Drawing.Point(193, 441);
            this.tbSearchLastname.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchLastname.Name = "tbSearchLastname";
            this.tbSearchLastname.Size = new System.Drawing.Size(369, 22);
            this.tbSearchLastname.TabIndex = 14;
            // 
            // lbMoneyTransferred
            // 
            this.lbMoneyTransferred.AutoSize = true;
            this.lbMoneyTransferred.Location = new System.Drawing.Point(196, 367);
            this.lbMoneyTransferred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMoneyTransferred.Name = "lbMoneyTransferred";
            this.lbMoneyTransferred.Size = new System.Drawing.Size(23, 17);
            this.lbMoneyTransferred.TabIndex = 12;
            this.lbMoneyTransferred.Text = "---";
            // 
            // lbMoneySpentFood
            // 
            this.lbMoneySpentFood.AutoSize = true;
            this.lbMoneySpentFood.Location = new System.Drawing.Point(196, 330);
            this.lbMoneySpentFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMoneySpentFood.Name = "lbMoneySpentFood";
            this.lbMoneySpentFood.Size = new System.Drawing.Size(23, 17);
            this.lbMoneySpentFood.TabIndex = 11;
            this.lbMoneySpentFood.Text = "---";
            // 
            // lbHasEntered
            // 
            this.lbHasEntered.AutoSize = true;
            this.lbHasEntered.Location = new System.Drawing.Point(196, 256);
            this.lbHasEntered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHasEntered.Name = "lbHasEntered";
            this.lbHasEntered.Size = new System.Drawing.Size(23, 17);
            this.lbHasEntered.TabIndex = 10;
            this.lbHasEntered.Text = "---";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(196, 219);
            this.lbMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(23, 17);
            this.lbMoney.TabIndex = 9;
            this.lbMoney.Text = "---";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(196, 145);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(23, 17);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "total money transferred:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "money spent on food:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "has entered:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "money:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Info:";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(20, 445);
            this.lbLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(139, 17);
            this.lbLastname.TabIndex = 1;
            this.lbLastname.Text = "search by last name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 741);
            this.Controls.Add(this.gbVisitorStatus);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.btnReturnMoney);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Exit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbVisitorStatus.ResumeLayout(false);
            this.gbVisitorStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnReturnMoney;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.GroupBox gbVisitorStatus;
        private System.Windows.Forms.Button btRetrieveQRData;
        private System.Windows.Forms.Label lbHasLeft;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox liVisitors;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btClearResult;
        private System.Windows.Forms.TextBox tbSearchLastname;
        private System.Windows.Forms.Label lbMoneyTransferred;
        private System.Windows.Forms.Label lbMoneySpentFood;
        private System.Windows.Forms.Label lbHasEntered;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbLastname;
    }
}

