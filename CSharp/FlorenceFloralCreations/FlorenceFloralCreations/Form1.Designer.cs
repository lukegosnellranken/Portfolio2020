namespace FlorenceFloralCreations
{
    partial class FormFlorence
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxOccasion = new System.Windows.Forms.ListBox();
            this.listBoxChoice = new System.Windows.Forms.ListBox();
            this.labelGoodChoice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(193, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(383, 44);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Florence\'s Floral Creations";
            // 
            // listBoxOccasion
            // 
            this.listBoxOccasion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOccasion.FormattingEnabled = true;
            this.listBoxOccasion.ItemHeight = 20;
            this.listBoxOccasion.Items.AddRange(new object[] {
            "Anniversary",
            "Birthday",
            "Funeral",
            "Get Well"});
            this.listBoxOccasion.Location = new System.Drawing.Point(100, 92);
            this.listBoxOccasion.Name = "listBoxOccasion";
            this.listBoxOccasion.Size = new System.Drawing.Size(225, 164);
            this.listBoxOccasion.TabIndex = 1;
            this.listBoxOccasion.SelectedIndexChanged += new System.EventHandler(this.listBoxOccasion_SelectedIndexChanged);
            // 
            // listBoxChoice
            // 
            this.listBoxChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChoice.FormattingEnabled = true;
            this.listBoxChoice.ItemHeight = 20;
            this.listBoxChoice.Location = new System.Drawing.Point(462, 92);
            this.listBoxChoice.Name = "listBoxChoice";
            this.listBoxChoice.Size = new System.Drawing.Size(225, 164);
            this.listBoxChoice.TabIndex = 2;
            this.listBoxChoice.SelectedIndexChanged += new System.EventHandler(this.listBoxChoice_SelectedIndexChanged);
            // 
            // labelGoodChoice
            // 
            this.labelGoodChoice.AutoSize = true;
            this.labelGoodChoice.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoodChoice.Location = new System.Drawing.Point(133, 359);
            this.labelGoodChoice.Name = "labelGoodChoice";
            this.labelGoodChoice.Size = new System.Drawing.Size(192, 44);
            this.labelGoodChoice.TabIndex = 3;
            this.labelGoodChoice.Text = "Good Choice!";
            this.labelGoodChoice.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(462, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 223);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormFlorence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelGoodChoice);
            this.Controls.Add(this.listBoxChoice);
            this.Controls.Add(this.listBoxOccasion);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormFlorence";
            this.Text = "Florence\'s Floral Creations";
            this.Load += new System.EventHandler(this.FormFlorence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxOccasion;
        private System.Windows.Forms.ListBox listBoxChoice;
        private System.Windows.Forms.Label labelGoodChoice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

