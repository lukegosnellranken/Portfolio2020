namespace PayrollGUI
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelGrossPay = new System.Windows.Forms.Label();
            this.labelTotalGross = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxGrossPay = new System.Windows.Forms.TextBox();
            this.textBoxTotalGross = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(217, 61);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(217, 118);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(217, 182);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(35, 13);
            this.labelHours.TabIndex = 2;
            this.labelHours.Text = "Hours";
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Location = new System.Drawing.Point(217, 252);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.labelHourlyRate.TabIndex = 3;
            this.labelHourlyRate.Text = "Hourly Rate";
            // 
            // labelGrossPay
            // 
            this.labelGrossPay.AutoSize = true;
            this.labelGrossPay.Location = new System.Drawing.Point(217, 317);
            this.labelGrossPay.Name = "labelGrossPay";
            this.labelGrossPay.Size = new System.Drawing.Size(55, 13);
            this.labelGrossPay.TabIndex = 4;
            this.labelGrossPay.Text = "Gross Pay";
            // 
            // labelTotalGross
            // 
            this.labelTotalGross.AutoSize = true;
            this.labelTotalGross.Location = new System.Drawing.Point(217, 384);
            this.labelTotalGross.Name = "labelTotalGross";
            this.labelTotalGross.Size = new System.Drawing.Size(61, 13);
            this.labelTotalGross.TabIndex = 5;
            this.labelTotalGross.Text = "Total Gross";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(330, 58);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(123, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(330, 118);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(123, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(330, 179);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(123, 20);
            this.textBoxHours.TabIndex = 8;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(330, 249);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(123, 20);
            this.textBoxHourlyRate.TabIndex = 9;
            // 
            // textBoxGrossPay
            // 
            this.textBoxGrossPay.Location = new System.Drawing.Point(330, 314);
            this.textBoxGrossPay.Name = "textBoxGrossPay";
            this.textBoxGrossPay.ReadOnly = true;
            this.textBoxGrossPay.Size = new System.Drawing.Size(123, 20);
            this.textBoxGrossPay.TabIndex = 11;
            // 
            // textBoxTotalGross
            // 
            this.textBoxTotalGross.Location = new System.Drawing.Point(330, 381);
            this.textBoxTotalGross.Name = "textBoxTotalGross";
            this.textBoxTotalGross.ReadOnly = true;
            this.textBoxTotalGross.Size = new System.Drawing.Size(123, 20);
            this.textBoxTotalGross.TabIndex = 12;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(541, 82);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(110, 49);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(541, 189);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 48);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(541, 305);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 48);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxTotalGross);
            this.Controls.Add(this.textBoxGrossPay);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelTotalGross);
            this.Controls.Add(this.labelGrossPay);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "Form1";
            this.Text = "PayrollGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label labelGrossPay;
        private System.Windows.Forms.Label labelTotalGross;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.TextBox textBoxGrossPay;
        private System.Windows.Forms.TextBox textBoxTotalGross;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

