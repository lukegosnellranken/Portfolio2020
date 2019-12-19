namespace FortuneTeller
{
    partial class FormFortuneTeller
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
            this.buttonFortuneCookie = new System.Windows.Forms.Button();
            this.textBoxFortune = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonFortuneCookie
            // 
            this.buttonFortuneCookie.Location = new System.Drawing.Point(65, 82);
            this.buttonFortuneCookie.Name = "buttonFortuneCookie";
            this.buttonFortuneCookie.Size = new System.Drawing.Size(268, 196);
            this.buttonFortuneCookie.TabIndex = 0;
            this.buttonFortuneCookie.UseVisualStyleBackColor = true;
            this.buttonFortuneCookie.Click += new System.EventHandler(this.buttonFortuneCookie_Click);
            // 
            // textBoxFortune
            // 
            this.textBoxFortune.Location = new System.Drawing.Point(353, 171);
            this.textBoxFortune.Name = "textBoxFortune";
            this.textBoxFortune.Size = new System.Drawing.Size(386, 20);
            this.textBoxFortune.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(227, 327);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(163, 41);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(452, 327);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 41);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // FormFortuneTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxFortune);
            this.Controls.Add(this.buttonFortuneCookie);
            this.Name = "FormFortuneTeller";
            this.Text = "FortuneTeller";
            this.Load += new System.EventHandler(this.FormFortuneTeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFortuneCookie;
        private System.Windows.Forms.TextBox textBoxFortune;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
    }
}

