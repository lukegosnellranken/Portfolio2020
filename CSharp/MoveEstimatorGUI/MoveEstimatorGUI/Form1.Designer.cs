namespace MoveEstimatorGUI
{
    partial class FormMoveEsimatorGUI
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelBaseCost = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMiles = new System.Windows.Forms.Label();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.textBoxBaseCost = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxMiles = new System.Windows.Forms.TextBox();
            this.textBoxBill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(120, 301);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(117, 63);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(331, 301);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(117, 63);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(544, 301);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(117, 63);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelBaseCost
            // 
            this.labelBaseCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseCost.Location = new System.Drawing.Point(145, 42);
            this.labelBaseCost.Name = "labelBaseCost";
            this.labelBaseCost.Size = new System.Drawing.Size(202, 28);
            this.labelBaseCost.TabIndex = 7;
            this.labelBaseCost.Text = "Move Base Cost:";
            this.labelBaseCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHours
            // 
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(133, 102);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(214, 28);
            this.labelHours.TabIndex = 8;
            this.labelHours.Text = "Move Hours Needed:";
            this.labelHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMiles
            // 
            this.labelMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiles.Location = new System.Drawing.Point(145, 161);
            this.labelMiles.Name = "labelMiles";
            this.labelMiles.Size = new System.Drawing.Size(202, 28);
            this.labelMiles.TabIndex = 9;
            this.labelMiles.Text = "Miles to Move:";
            this.labelMiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBill.Location = new System.Drawing.Point(145, 236);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(202, 28);
            this.labelTotalBill.TabIndex = 10;
            this.labelTotalBill.Text = "Total Bill:";
            this.labelTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.labelTotalBill.Click += new System.EventHandler(this.labelTotalBill_Click);
            // 
            // textBoxBaseCost
            // 
            this.textBoxBaseCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxBaseCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaseCost.Location = new System.Drawing.Point(353, 41);
            this.textBoxBaseCost.Name = "textBoxBaseCost";
            this.textBoxBaseCost.ReadOnly = true;
            this.textBoxBaseCost.Size = new System.Drawing.Size(308, 29);
            this.textBoxBaseCost.TabIndex = 6;
            this.textBoxBaseCost.Text = "200.00";
            this.textBoxBaseCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHours.Location = new System.Drawing.Point(353, 101);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(308, 29);
            this.textBoxHours.TabIndex = 0;
            this.textBoxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.textBoxHours.TextChanged += new System.EventHandler(this.textBoxHours_TextChanged);
            // 
            // textBoxMiles
            // 
            this.textBoxMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMiles.Location = new System.Drawing.Point(353, 160);
            this.textBoxMiles.Name = "textBoxMiles";
            this.textBoxMiles.Size = new System.Drawing.Size(308, 29);
            this.textBoxMiles.TabIndex = 1;
            this.textBoxMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBill
            // 
            this.textBoxBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBill.Location = new System.Drawing.Point(353, 235);
            this.textBoxBill.Name = "textBoxBill";
            this.textBoxBill.ReadOnly = true;
            this.textBoxBill.Size = new System.Drawing.Size(308, 29);
            this.textBoxBill.TabIndex = 2;
            this.textBoxBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMoveEsimatorGUI
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(769, 417);
            this.Controls.Add(this.textBoxBill);
            this.Controls.Add(this.textBoxMiles);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxBaseCost);
            this.Controls.Add(this.labelTotalBill);
            this.Controls.Add(this.labelMiles);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelBaseCost);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "FormMoveEsimatorGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeff Scott - Chapter 3, Move Esitmator GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelBaseCost;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMiles;
        private System.Windows.Forms.Label labelTotalBill;
        private System.Windows.Forms.TextBox textBoxBaseCost;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxMiles;
        private System.Windows.Forms.TextBox textBoxBill;
    }
}

