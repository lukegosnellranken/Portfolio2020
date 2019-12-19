namespace CreditCardMasker
{
    partial class FormCreditCardMasker
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
            this.labelMasked = new System.Windows.Forms.Label();
            this.buttonMask = new System.Windows.Forms.Button();
            this.textBoxCCNumber = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMasked
            // 
            this.labelMasked.AutoSize = true;
            this.labelMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasked.Location = new System.Drawing.Point(105, 283);
            this.labelMasked.Name = "labelMasked";
            this.labelMasked.Size = new System.Drawing.Size(92, 31);
            this.labelMasked.TabIndex = 0;
            this.labelMasked.Text = "label1";
            // 
            // buttonMask
            // 
            this.buttonMask.Location = new System.Drawing.Point(580, 207);
            this.buttonMask.Name = "buttonMask";
            this.buttonMask.Size = new System.Drawing.Size(75, 23);
            this.buttonMask.TabIndex = 1;
            this.buttonMask.Text = "Mask";
            this.buttonMask.UseVisualStyleBackColor = true;
            this.buttonMask.Click += new System.EventHandler(this.buttonMask_Click);
            // 
            // textBoxCCNumber
            // 
            this.textBoxCCNumber.Location = new System.Drawing.Point(111, 210);
            this.textBoxCCNumber.Name = "textBoxCCNumber";
            this.textBoxCCNumber.Size = new System.Drawing.Size(340, 20);
            this.textBoxCCNumber.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(221, 83);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(336, 39);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Credit Card Masker";
            // 
            // FormCreditCardMasker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxCCNumber);
            this.Controls.Add(this.buttonMask);
            this.Controls.Add(this.labelMasked);
            this.Name = "FormCreditCardMasker";
            this.Text = "Credit Card Masker";
            this.Load += new System.EventHandler(this.FormCreditCardMasker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMasked;
        private System.Windows.Forms.Button buttonMask;
        private System.Windows.Forms.TextBox textBoxCCNumber;
        private System.Windows.Forms.Label labelTitle;
    }
}

