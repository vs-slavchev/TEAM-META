﻿namespace StatusInspectionApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbVisitorStatus = new System.Windows.Forms.GroupBox();
            this.clearResult = new MaterialSkin.Controls.MaterialRaisedButton();
            this.searchByLastName = new MaterialSkin.Controls.MaterialRaisedButton();
            this.retrieveQRdata = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbHasLeft = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.liVisitors = new System.Windows.Forms.ListBox();
            this.lbMoneyTransferred = new System.Windows.Forms.Label();
            this.lbMoneySpentFood = new System.Windows.Forms.Label();
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
            this.bgOverallStatus = new System.Windows.Forms.GroupBox();
            this.updateOverallStatus = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.tbSearchLastname = new System.Windows.Forms.TextBox();
            this.gbVisitorStatus.SuspendLayout();
            this.bgOverallStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVisitorStatus
            // 
            this.gbVisitorStatus.BackColor = System.Drawing.Color.MediumPurple;
            this.gbVisitorStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbVisitorStatus.Controls.Add(this.clearResult);
            this.gbVisitorStatus.Controls.Add(this.searchByLastName);
            this.gbVisitorStatus.Controls.Add(this.retrieveQRdata);
            this.gbVisitorStatus.Controls.Add(this.lbHasLeft);
            this.gbVisitorStatus.Controls.Add(this.label15);
            this.gbVisitorStatus.Controls.Add(this.lbPhoneNumber);
            this.gbVisitorStatus.Controls.Add(this.label14);
            this.gbVisitorStatus.Controls.Add(this.liVisitors);
            this.gbVisitorStatus.Controls.Add(this.tbSearchLastname);
            this.gbVisitorStatus.Controls.Add(this.lbMoneyTransferred);
            this.gbVisitorStatus.Controls.Add(this.lbMoneySpentFood);
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
            this.gbVisitorStatus.Location = new System.Drawing.Point(3, 67);
            this.gbVisitorStatus.Name = "gbVisitorStatus";
            this.gbVisitorStatus.Size = new System.Drawing.Size(429, 686);
            this.gbVisitorStatus.TabIndex = 0;
            this.gbVisitorStatus.TabStop = false;
            this.gbVisitorStatus.Text = "Visitor Status";
            // 
            // clearResult
            // 
            this.clearResult.Depth = 0;
            this.clearResult.Location = new System.Drawing.Point(6, 631);
            this.clearResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearResult.Name = "clearResult";
            this.clearResult.Primary = true;
            this.clearResult.Size = new System.Drawing.Size(417, 49);
            this.clearResult.TabIndex = 25;
            this.clearResult.Text = "Clear result";
            this.clearResult.UseVisualStyleBackColor = true;
            this.clearResult.Click += new System.EventHandler(this.clearResult_Click);
            // 
            // searchByLastName
            // 
            this.searchByLastName.Depth = 0;
            this.searchByLastName.Location = new System.Drawing.Point(6, 425);
            this.searchByLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchByLastName.Name = "searchByLastName";
            this.searchByLastName.Primary = true;
            this.searchByLastName.Size = new System.Drawing.Size(417, 34);
            this.searchByLastName.TabIndex = 24;
            this.searchByLastName.Text = "Search";
            this.searchByLastName.UseVisualStyleBackColor = true;
            this.searchByLastName.Click += new System.EventHandler(this.searchByLastName_Click);
            // 
            // retrieveQRdata
            // 
            this.retrieveQRdata.Depth = 0;
            this.retrieveQRdata.Location = new System.Drawing.Point(6, 19);
            this.retrieveQRdata.MouseState = MaterialSkin.MouseState.HOVER;
            this.retrieveQRdata.Name = "retrieveQRdata";
            this.retrieveQRdata.Primary = true;
            this.retrieveQRdata.Size = new System.Drawing.Size(417, 78);
            this.retrieveQRdata.TabIndex = 23;
            this.retrieveQRdata.Text = "Get user from QR reader";
            this.retrieveQRdata.UseVisualStyleBackColor = true;
            this.retrieveQRdata.Click += new System.EventHandler(this.retrieveQRdata_Click);
            // 
            // lbHasLeft
            // 
            this.lbHasLeft.AutoSize = true;
            this.lbHasLeft.Location = new System.Drawing.Point(142, 260);
            this.lbHasLeft.Name = "lbHasLeft";
            this.lbHasLeft.Size = new System.Drawing.Size(16, 13);
            this.lbHasLeft.TabIndex = 21;
            this.lbHasLeft.Text = "---";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "has left:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(142, 170);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(16, 13);
            this.lbPhoneNumber.TabIndex = 19;
            this.lbPhoneNumber.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "phone number:";
            // 
            // liVisitors
            // 
            this.liVisitors.FormattingEnabled = true;
            this.liVisitors.Location = new System.Drawing.Point(6, 465);
            this.liVisitors.Name = "liVisitors";
            this.liVisitors.Size = new System.Drawing.Size(417, 160);
            this.liVisitors.TabIndex = 17;
            this.liVisitors.SelectedIndexChanged += new System.EventHandler(this.liVisitors_SelectedIndexChanged);
            // 
            // lbMoneyTransferred
            // 
            this.lbMoneyTransferred.AutoSize = true;
            this.lbMoneyTransferred.Location = new System.Drawing.Point(142, 320);
            this.lbMoneyTransferred.Name = "lbMoneyTransferred";
            this.lbMoneyTransferred.Size = new System.Drawing.Size(16, 13);
            this.lbMoneyTransferred.TabIndex = 12;
            this.lbMoneyTransferred.Text = "---";
            // 
            // lbMoneySpentFood
            // 
            this.lbMoneySpentFood.AutoSize = true;
            this.lbMoneySpentFood.Location = new System.Drawing.Point(142, 290);
            this.lbMoneySpentFood.Name = "lbMoneySpentFood";
            this.lbMoneySpentFood.Size = new System.Drawing.Size(16, 13);
            this.lbMoneySpentFood.TabIndex = 11;
            this.lbMoneySpentFood.Text = "---";
            // 
            // lbHasEntered
            // 
            this.lbHasEntered.AutoSize = true;
            this.lbHasEntered.Location = new System.Drawing.Point(142, 230);
            this.lbHasEntered.Name = "lbHasEntered";
            this.lbHasEntered.Size = new System.Drawing.Size(16, 13);
            this.lbHasEntered.TabIndex = 10;
            this.lbHasEntered.Text = "---";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(142, 200);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(16, 13);
            this.lbMoney.TabIndex = 9;
            this.lbMoney.Text = "---";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(142, 140);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(16, 13);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "total money transferred:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "money spent on food:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "has entered:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Info:";
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(15, 402);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(104, 13);
            this.lbLastname.TabIndex = 1;
            this.lbLastname.Text = "search by last name:";
            // 
            // bgOverallStatus
            // 
            this.bgOverallStatus.BackColor = System.Drawing.Color.MediumPurple;
            this.bgOverallStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgOverallStatus.Controls.Add(this.updateOverallStatus);
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
            this.bgOverallStatus.Location = new System.Drawing.Point(438, 67);
            this.bgOverallStatus.Name = "bgOverallStatus";
            this.bgOverallStatus.Size = new System.Drawing.Size(450, 686);
            this.bgOverallStatus.TabIndex = 1;
            this.bgOverallStatus.TabStop = false;
            this.bgOverallStatus.Text = "Overall Status";
            // 
            // updateOverallStatus
            // 
            this.updateOverallStatus.Depth = 0;
            this.updateOverallStatus.Location = new System.Drawing.Point(9, 19);
            this.updateOverallStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateOverallStatus.Name = "updateOverallStatus";
            this.updateOverallStatus.Primary = true;
            this.updateOverallStatus.Size = new System.Drawing.Size(431, 78);
            this.updateOverallStatus.TabIndex = 15;
            this.updateOverallStatus.Text = "Update information";
            this.updateOverallStatus.UseVisualStyleBackColor = true;
            this.updateOverallStatus.Click += new System.EventHandler(this.updateOverallStatus_Click);
            // 
            // lbCampSpotsBooked
            // 
            this.lbCampSpotsBooked.AutoSize = true;
            this.lbCampSpotsBooked.Location = new System.Drawing.Point(157, 256);
            this.lbCampSpotsBooked.Name = "lbCampSpotsBooked";
            this.lbCampSpotsBooked.Size = new System.Drawing.Size(16, 13);
            this.lbCampSpotsBooked.TabIndex = 13;
            this.lbCampSpotsBooked.Text = "---";
            // 
            // lbTotalMoneyPaid
            // 
            this.lbTotalMoneyPaid.AutoSize = true;
            this.lbTotalMoneyPaid.Location = new System.Drawing.Point(157, 229);
            this.lbTotalMoneyPaid.Name = "lbTotalMoneyPaid";
            this.lbTotalMoneyPaid.Size = new System.Drawing.Size(16, 13);
            this.lbTotalMoneyPaid.TabIndex = 12;
            this.lbTotalMoneyPaid.Text = "---";
            // 
            // lbTotalBalance
            // 
            this.lbTotalBalance.AutoSize = true;
            this.lbTotalBalance.Location = new System.Drawing.Point(157, 199);
            this.lbTotalBalance.Name = "lbTotalBalance";
            this.lbTotalBalance.Size = new System.Drawing.Size(16, 13);
            this.lbTotalBalance.TabIndex = 11;
            this.lbTotalBalance.Text = "---";
            // 
            // lbVisitorsLeft
            // 
            this.lbVisitorsLeft.AutoSize = true;
            this.lbVisitorsLeft.Location = new System.Drawing.Point(157, 171);
            this.lbVisitorsLeft.Name = "lbVisitorsLeft";
            this.lbVisitorsLeft.Size = new System.Drawing.Size(16, 13);
            this.lbVisitorsLeft.TabIndex = 10;
            this.lbVisitorsLeft.Text = "---";
            // 
            // lbVisitorsNotEntered
            // 
            this.lbVisitorsNotEntered.AutoSize = true;
            this.lbVisitorsNotEntered.Location = new System.Drawing.Point(157, 142);
            this.lbVisitorsNotEntered.Name = "lbVisitorsNotEntered";
            this.lbVisitorsNotEntered.Size = new System.Drawing.Size(16, 13);
            this.lbVisitorsNotEntered.TabIndex = 9;
            this.lbVisitorsNotEntered.Text = "---";
            // 
            // lbVisitorsEntered
            // 
            this.lbVisitorsEntered.AutoSize = true;
            this.lbVisitorsEntered.Location = new System.Drawing.Point(157, 116);
            this.lbVisitorsEntered.Name = "lbVisitorsEntered";
            this.lbVisitorsEntered.Size = new System.Drawing.Size(16, 13);
            this.lbVisitorsEntered.TabIndex = 8;
            this.lbVisitorsEntered.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "List of free camp spots:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "camp spots booked:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "total money paid:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "total money balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "visitors left:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "visitors not entered yet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "visitors entered:";
            // 
            // liCampSpots
            // 
            this.liCampSpots.FormattingEnabled = true;
            this.liCampSpots.Location = new System.Drawing.Point(6, 351);
            this.liCampSpots.Name = "liCampSpots";
            this.liCampSpots.Size = new System.Drawing.Size(434, 329);
            this.liCampSpots.TabIndex = 0;
            // 
            // tbSearchLastname
            // 
            this.tbSearchLastname.Location = new System.Drawing.Point(145, 399);
            this.tbSearchLastname.Name = "tbSearchLastname";
            this.tbSearchLastname.Size = new System.Drawing.Size(278, 20);
            this.tbSearchLastname.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(892, 755);
            this.Controls.Add(this.bgOverallStatus);
            this.Controls.Add(this.gbVisitorStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Status Inspection";
            this.gbVisitorStatus.ResumeLayout(false);
            this.gbVisitorStatus.PerformLayout();
            this.bgOverallStatus.ResumeLayout(false);
            this.bgOverallStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVisitorStatus;
        private System.Windows.Forms.Label lbMoneyTransferred;
        private System.Windows.Forms.Label lbMoneySpentFood;
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
        private System.Windows.Forms.ListBox liVisitors;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbHasLeft;
        private System.Windows.Forms.Label label15;
        private MaterialSkin.Controls.MaterialRaisedButton updateOverallStatus;
        private MaterialSkin.Controls.MaterialRaisedButton retrieveQRdata;
        private MaterialSkin.Controls.MaterialRaisedButton searchByLastName;
        private MaterialSkin.Controls.MaterialRaisedButton clearResult;
        private System.Windows.Forms.TextBox tbSearchLastname;
    }
}

