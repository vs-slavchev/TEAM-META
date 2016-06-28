namespace ShopApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_visitorFirstName = new System.Windows.Forms.Label();
            this.lb_visitorLastName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.retrieveQR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.lb_visitorFirstName);
            this.groupBox1.Controls.Add(this.lb_visitorLastName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.remove);
            this.groupBox1.Controls.Add(this.buy);
            this.groupBox1.Controls.Add(this.retrieveQR);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Location = new System.Drawing.Point(3, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(763, 534);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // lb_visitorFirstName
            // 
            this.lb_visitorFirstName.AutoSize = true;
            this.lb_visitorFirstName.Location = new System.Drawing.Point(504, 63);
            this.lb_visitorFirstName.Name = "lb_visitorFirstName";
            this.lb_visitorFirstName.Size = new System.Drawing.Size(16, 13);
            this.lb_visitorFirstName.TabIndex = 68;
            this.lb_visitorFirstName.Text = "---";
            // 
            // lb_visitorLastName
            // 
            this.lb_visitorLastName.AutoSize = true;
            this.lb_visitorLastName.Location = new System.Drawing.Point(504, 89);
            this.lb_visitorLastName.Name = "lb_visitorLastName";
            this.lb_visitorLastName.Size = new System.Drawing.Size(16, 13);
            this.lb_visitorLastName.TabIndex = 67;
            this.lb_visitorLastName.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Current visitor:";
            // 
            // remove
            // 
            this.remove.Depth = 0;
            this.remove.Location = new System.Drawing.Point(163, 378);
            this.remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.remove.Name = "remove";
            this.remove.Primary = true;
            this.remove.Size = new System.Drawing.Size(178, 41);
            this.remove.TabIndex = 64;
            this.remove.Text = "remove selected";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // buy
            // 
            this.buy.Depth = 0;
            this.buy.Location = new System.Drawing.Point(71, 378);
            this.buy.MouseState = MaterialSkin.MouseState.HOVER;
            this.buy.Name = "buy";
            this.buy.Primary = true;
            this.buy.Size = new System.Drawing.Size(86, 41);
            this.buy.TabIndex = 63;
            this.buy.Text = "purchase";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // retrieveQR
            // 
            this.retrieveQR.Depth = 0;
            this.retrieveQR.Location = new System.Drawing.Point(71, 28);
            this.retrieveQR.MouseState = MaterialSkin.MouseState.HOVER;
            this.retrieveQR.Name = "retrieveQR";
            this.retrieveQR.Primary = true;
            this.retrieveQR.Size = new System.Drawing.Size(270, 62);
            this.retrieveQR.TabIndex = 62;
            this.retrieveQR.Text = "Get visitor QR code";
            this.retrieveQR.UseVisualStyleBackColor = true;
            this.retrieveQR.Click += new System.EventHandler(this.retrieveQR_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(297, 288);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 60;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Quantity:";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(255, 258);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(86, 23);
            this.button17.TabIndex = 57;
            this.button17.Text = "Beer";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(255, 229);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(86, 23);
            this.button16.TabIndex = 56;
            this.button16.Text = "Water";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(255, 200);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(86, 23);
            this.button15.TabIndex = 55;
            this.button15.Text = "Fanta";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(255, 171);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(86, 23);
            this.button14.TabIndex = 54;
            this.button14.Text = "Coca Cola";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(255, 142);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 23);
            this.button13.TabIndex = 53;
            this.button13.Text = "Garlic sauce";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(163, 258);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(86, 23);
            this.button12.TabIndex = 52;
            this.button12.Text = "Chili";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(163, 229);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 23);
            this.button11.TabIndex = 51;
            this.button11.Text = "Mayo";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(163, 200);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 23);
            this.button10.TabIndex = 50;
            this.button10.Text = "Ketchup";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(163, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 23);
            this.button9.TabIndex = 49;
            this.button9.Text = "Mixed doner";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(163, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 23);
            this.button8.TabIndex = 48;
            this.button8.Text = "Chicken doner";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(71, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 23);
            this.button7.TabIndex = 47;
            this.button7.Text = "French fries";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(71, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 46;
            this.button6.Text = "Chicken wings";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(71, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "Hot Dog";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(71, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "Cheeseburger";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Hamburger";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(382, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 277);
            this.listBox1.TabIndex = 42;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(235, 332);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 26);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "0.00 €";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(183, 336);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 20);
            this.label25.TabIndex = 38;
            this.label25.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 604);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialRaisedButton retrieveQR;
        private MaterialSkin.Controls.MaterialRaisedButton buy;
        private MaterialSkin.Controls.MaterialRaisedButton remove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_visitorLastName;
        private System.Windows.Forms.Label lb_visitorFirstName;
    }
}

