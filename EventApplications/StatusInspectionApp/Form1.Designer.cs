namespace StatusInspectionApp
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
            this.gbVisitorStatus = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btClearResult = new System.Windows.Forms.Button();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbMoneyTransferred = new System.Windows.Forms.Label();
            this.lbMoneySpent = new System.Windows.Forms.Label();
            this.lbHasEntered = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.bgOverallStatus = new System.Windows.Forms.GroupBox();
            this.btUpdateOverallStatus = new System.Windows.Forms.Button();
            this.lbCampSpotsBooked = new System.Windows.Forms.Label();
            this.lbTotalMoneyPaid = new System.Windows.Forms.Label();
            this.lbTotalBalance = new System.Windows.Forms.Label();
            this.lbVisitorsLeft = new System.Windows.Forms.Label();
            this.lbVisitorsNotEntered = new System.Windows.Forms.Label();
            this.lbVisitorsEntered = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.liCampSpots = new System.Windows.Forms.ListBox();
            this.gbVisitorStatus.SuspendLayout();
            this.bgOverallStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVisitorStatus
            // 
            this.gbVisitorStatus.Controls.Add(this.btSearch);
            this.gbVisitorStatus.Controls.Add(this.btClearResult);
            this.gbVisitorStatus.Controls.Add(this.tbLastname);
            this.gbVisitorStatus.Controls.Add(this.tbId);
            this.gbVisitorStatus.Controls.Add(this.lbMoneyTransferred);
            this.gbVisitorStatus.Controls.Add(this.lbMoneySpent);
            this.gbVisitorStatus.Controls.Add(this.lbHasEntered);
            this.gbVisitorStatus.Controls.Add(this.lbMoney);
            this.gbVisitorStatus.Controls.Add(this.lbEmail);
            this.gbVisitorStatus.Controls.Add(this.label6);
            this.gbVisitorStatus.Controls.Add(this.label5);
            this.gbVisitorStatus.Controls.Add(this.label4);
            this.gbVisitorStatus.Controls.Add(this.label3);
            this.gbVisitorStatus.Controls.Add(this.label2);
            this.gbVisitorStatus.Controls.Add(this.label1);
            this.gbVisitorStatus.Controls.Add(this.lbLastname);
            this.gbVisitorStatus.Controls.Add(this.lbId);
            this.gbVisitorStatus.Location = new System.Drawing.Point(21, 12);
            this.gbVisitorStatus.Name = "gbVisitorStatus";
            this.gbVisitorStatus.Size = new System.Drawing.Size(250, 399);
            this.gbVisitorStatus.TabIndex = 0;
            this.gbVisitorStatus.TabStop = false;
            this.gbVisitorStatus.Text = "Visitor Status";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(10, 87);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(223, 23);
            this.btSearch.TabIndex = 16;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // btClearResult
            // 
            this.btClearResult.Location = new System.Drawing.Point(13, 289);
            this.btClearResult.Name = "btClearResult";
            this.btClearResult.Size = new System.Drawing.Size(220, 23);
            this.btClearResult.TabIndex = 15;
            this.btClearResult.Text = "Clear result";
            this.btClearResult.UseVisualStyleBackColor = true;
            this.btClearResult.Click += new System.EventHandler(this.btClearResult_Click);
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(82, 61);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(151, 20);
            this.tbLastname.TabIndex = 14;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(82, 31);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(151, 20);
            this.tbId.TabIndex = 13;
            // 
            // lbMoneyTransferred
            // 
            this.lbMoneyTransferred.AutoSize = true;
            this.lbMoneyTransferred.Location = new System.Drawing.Point(142, 261);
            this.lbMoneyTransferred.Name = "lbMoneyTransferred";
            this.lbMoneyTransferred.Size = new System.Drawing.Size(16, 13);
            this.lbMoneyTransferred.TabIndex = 12;
            this.lbMoneyTransferred.Text = "---";
            // 
            // lbMoneySpent
            // 
            this.lbMoneySpent.AutoSize = true;
            this.lbMoneySpent.Location = new System.Drawing.Point(142, 231);
            this.lbMoneySpent.Name = "lbMoneySpent";
            this.lbMoneySpent.Size = new System.Drawing.Size(16, 13);
            this.lbMoneySpent.TabIndex = 11;
            this.lbMoneySpent.Text = "---";
            // 
            // lbHasEntered
            // 
            this.lbHasEntered.AutoSize = true;
            this.lbHasEntered.Location = new System.Drawing.Point(142, 201);
            this.lbHasEntered.Name = "lbHasEntered";
            this.lbHasEntered.Size = new System.Drawing.Size(16, 13);
            this.lbHasEntered.TabIndex = 10;
            this.lbHasEntered.Text = "---";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(142, 170);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(16, 13);
            this.lbMoney.TabIndex = 9;
            this.lbMoney.Text = "---";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(142, 143);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(16, 13);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "total money transferred:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "money spent on food:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "has entered:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result:";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(7, 64);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(69, 13);
            this.lbLastname.TabIndex = 1;
            this.lbLastname.Text = "by last name:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(7, 34);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(32, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "by id:";
            // 
            // bgOverallStatus
            // 
            this.bgOverallStatus.Controls.Add(this.btUpdateOverallStatus);
            this.bgOverallStatus.Controls.Add(this.lbCampSpotsBooked);
            this.bgOverallStatus.Controls.Add(this.lbTotalMoneyPaid);
            this.bgOverallStatus.Controls.Add(this.lbTotalBalance);
            this.bgOverallStatus.Controls.Add(this.lbVisitorsLeft);
            this.bgOverallStatus.Controls.Add(this.lbVisitorsNotEntered);
            this.bgOverallStatus.Controls.Add(this.lbVisitorsEntered);
            this.bgOverallStatus.Controls.Add(this.label13);
            this.bgOverallStatus.Controls.Add(this.label12);
            this.bgOverallStatus.Controls.Add(this.label11);
            this.bgOverallStatus.Controls.Add(this.label10);
            this.bgOverallStatus.Controls.Add(this.label9);
            this.bgOverallStatus.Controls.Add(this.label8);
            this.bgOverallStatus.Controls.Add(this.label7);
            this.bgOverallStatus.Controls.Add(this.liCampSpots);
            this.bgOverallStatus.Location = new System.Drawing.Point(297, 12);
            this.bgOverallStatus.Name = "bgOverallStatus";
            this.bgOverallStatus.Size = new System.Drawing.Size(304, 399);
            this.bgOverallStatus.TabIndex = 1;
            this.bgOverallStatus.TabStop = false;
            this.bgOverallStatus.Text = "Overall Status";
            // 
            // btUpdateOverallStatus
            // 
            this.btUpdateOverallStatus.Location = new System.Drawing.Point(7, 20);
            this.btUpdateOverallStatus.Name = "btUpdateOverallStatus";
            this.btUpdateOverallStatus.Size = new System.Drawing.Size(291, 23);
            this.btUpdateOverallStatus.TabIndex = 14;
            this.btUpdateOverallStatus.Text = "Update information";
            this.btUpdateOverallStatus.UseVisualStyleBackColor = true;
            this.btUpdateOverallStatus.Click += new System.EventHandler(this.btUpdateOverallStatus_Click);
            // 
            // lbCampSpotsBooked
            // 
            this.lbCampSpotsBooked.AutoSize = true;
            this.lbCampSpotsBooked.Location = new System.Drawing.Point(147, 201);
            this.lbCampSpotsBooked.Name = "lbCampSpotsBooked";
            this.lbCampSpotsBooked.Size = new System.Drawing.Size(16, 13);
            this.lbCampSpotsBooked.TabIndex = 13;
            this.lbCampSpotsBooked.Text = "---";
            // 
            // lbTotalMoneyPaid
            // 
            this.lbTotalMoneyPaid.AutoSize = true;
            this.lbTotalMoneyPaid.Location = new System.Drawing.Point(147, 170);
            this.lbTotalMoneyPaid.Name = "lbTotalMoneyPaid";
            this.lbTotalMoneyPaid.Size = new System.Drawing.Size(16, 13);
            this.lbTotalMoneyPaid.TabIndex = 12;
            this.lbTotalMoneyPaid.Text = "---";
            // 
            // lbTotalBalance
            // 
            this.lbTotalBalance.AutoSize = true;
            this.lbTotalBalance.Location = new System.Drawing.Point(147, 143);
            this.lbTotalBalance.Name = "lbTotalBalance";
            this.lbTotalBalance.Size = new System.Drawing.Size(16, 13);
            this.lbTotalBalance.TabIndex = 11;
            this.lbTotalBalance.Text = "---";
            this.lbTotalBalance.Click += new System.EventHandler(this.label17_Click);
            // 
            // lbVisitorsLeft
            // 
            this.lbVisitorsLeft.AutoSize = true;
            this.lbVisitorsLeft.Location = new System.Drawing.Point(147, 113);
            this.lbVisitorsLeft.Name = "lbVisitorsLeft";
            this.lbVisitorsLeft.Size = new System.Drawing.Size(16, 13);
            this.lbVisitorsLeft.TabIndex = 10;
            this.lbVisitorsLeft.Text = "---";
            // 
            // lbVisitorsNotEntered
            // 
            this.lbVisitorsNotEntered.AutoSize = true;
            this.lbVisitorsNotEntered.Location = new System.Drawing.Point(147, 87);
            this.lbVisitorsNotEntered.Name = "lbVisitorsNotEntered";
            this.lbVisitorsNotEntered.Size = new System.Drawing.Size(16, 13);
            this.lbVisitorsNotEntered.TabIndex = 9;
            this.lbVisitorsNotEntered.Text = "---";
            // 
            // lbVisitorsEntered
            // 
            this.lbVisitorsEntered.AutoSize = true;
            this.lbVisitorsEntered.Location = new System.Drawing.Point(147, 61);
            this.lbVisitorsEntered.Name = "lbVisitorsEntered";
            this.lbVisitorsEntered.Size = new System.Drawing.Size(16, 13);
            this.lbVisitorsEntered.TabIndex = 8;
            this.lbVisitorsEntered.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "List of free camp spots:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "camp spots booked:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "total money paid:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "total money balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "visitors left:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "visitors not entered yet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "visitors entered:";
            // 
            // liCampSpots
            // 
            this.liCampSpots.FormattingEnabled = true;
            this.liCampSpots.Location = new System.Drawing.Point(7, 257);
            this.liCampSpots.Name = "liCampSpots";
            this.liCampSpots.Size = new System.Drawing.Size(291, 134);
            this.liCampSpots.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 423);
            this.Controls.Add(this.bgOverallStatus);
            this.Controls.Add(this.gbVisitorStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbVisitorStatus.ResumeLayout(false);
            this.gbVisitorStatus.PerformLayout();
            this.bgOverallStatus.ResumeLayout(false);
            this.bgOverallStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVisitorStatus;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbMoneyTransferred;
        private System.Windows.Forms.Label lbMoneySpent;
        private System.Windows.Forms.Label lbHasEntered;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.GroupBox bgOverallStatus;
        private System.Windows.Forms.Label lbTotalBalance;
        private System.Windows.Forms.Label lbVisitorsLeft;
        private System.Windows.Forms.Label lbVisitorsNotEntered;
        private System.Windows.Forms.Label lbVisitorsEntered;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox liCampSpots;
        private System.Windows.Forms.Label lbCampSpotsBooked;
        private System.Windows.Forms.Label lbTotalMoneyPaid;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btClearResult;
        private System.Windows.Forms.Button btUpdateOverallStatus;
    }
}

