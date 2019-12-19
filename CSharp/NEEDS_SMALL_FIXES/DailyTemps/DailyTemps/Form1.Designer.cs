namespace DailyTemps
{
    partial class FormDailyTemps
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
            this.components = new System.ComponentModel.Container();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelHighTemp = new System.Windows.Forms.Label();
            this.labelAvgTemp = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.textBoxHighTemp = new System.Windows.Forms.TextBox();
            this.textBoxAvgTemp = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(110, 281);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(112, 54);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(243, 281);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 54);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(382, 281);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 54);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(92, 54);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(212, 31);
            this.labelTemp.TabIndex = 6;
            this.labelTemp.Text = "Temp (-20 to 130):";
            this.labelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHighTemp
            // 
            this.labelHighTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelHighTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighTemp.Location = new System.Drawing.Point(97, 131);
            this.labelHighTemp.Name = "labelHighTemp";
            this.labelHighTemp.Size = new System.Drawing.Size(207, 31);
            this.labelHighTemp.TabIndex = 7;
            this.labelHighTemp.Text = "High Temperature:";
            this.labelHighTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAvgTemp
            // 
            this.labelAvgTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelAvgTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgTemp.Location = new System.Drawing.Point(102, 206);
            this.labelAvgTemp.Name = "labelAvgTemp";
            this.labelAvgTemp.Size = new System.Drawing.Size(202, 31);
            this.labelAvgTemp.TabIndex = 8;
            this.labelAvgTemp.Text = "Avg Temperature:";
            this.labelAvgTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemp.Location = new System.Drawing.Point(310, 54);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(212, 31);
            this.textBoxTemp.TabIndex = 0;
            // 
            // textBoxHighTemp
            // 
            this.textBoxHighTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHighTemp.Location = new System.Drawing.Point(310, 131);
            this.textBoxHighTemp.Name = "textBoxHighTemp";
            this.textBoxHighTemp.ReadOnly = true;
            this.textBoxHighTemp.Size = new System.Drawing.Size(212, 31);
            this.textBoxHighTemp.TabIndex = 4;
            // 
            // textBoxAvgTemp
            // 
            this.textBoxAvgTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvgTemp.Location = new System.Drawing.Point(310, 206);
            this.textBoxAvgTemp.Name = "textBoxAvgTemp";
            this.textBoxAvgTemp.ReadOnly = true;
            this.textBoxAvgTemp.Size = new System.Drawing.Size(212, 31);
            this.textBoxAvgTemp.TabIndex = 5;
            // 
            // FormDailyTemps
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(630, 410);
            this.Controls.Add(this.textBoxAvgTemp);
            this.Controls.Add(this.textBoxHighTemp);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.labelAvgTemp);
            this.Controls.Add(this.labelHighTemp);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "FormDailyTemps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeff Scott - Page 220, #4 Daily Temps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHighTemp;
        private System.Windows.Forms.Label labelAvgTemp;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.TextBox textBoxHighTemp;
        private System.Windows.Forms.TextBox textBoxAvgTemp;
        private System.Windows.Forms.Timer timer1;
    }
}

