namespace ArrayFunGUI
{
    partial class ArrayFunGUI
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
            this.buttonDisplayArray = new System.Windows.Forms.Button();
            this.buttonLowest = new System.Windows.Forms.Button();
            this.buttonHighest = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.buttonAscending = new System.Windows.Forms.Button();
            this.buttonDescending = new System.Windows.Forms.Button();
            this.buttonBinarySearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.textBoxBinarySearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDisplayArray
            // 
            this.buttonDisplayArray.Location = new System.Drawing.Point(310, 51);
            this.buttonDisplayArray.Name = "buttonDisplayArray";
            this.buttonDisplayArray.Size = new System.Drawing.Size(153, 34);
            this.buttonDisplayArray.TabIndex = 1;
            this.buttonDisplayArray.Text = "Display Array";
            this.buttonDisplayArray.UseVisualStyleBackColor = true;
            this.buttonDisplayArray.Click += new System.EventHandler(this.buttonDisplayArray_Click);
            // 
            // buttonLowest
            // 
            this.buttonLowest.Location = new System.Drawing.Point(310, 213);
            this.buttonLowest.Name = "buttonLowest";
            this.buttonLowest.Size = new System.Drawing.Size(153, 34);
            this.buttonLowest.TabIndex = 2;
            this.buttonLowest.Text = "Display Lowest";
            this.buttonLowest.UseVisualStyleBackColor = true;
            this.buttonLowest.Click += new System.EventHandler(this.buttonLowest_Click);
            // 
            // buttonHighest
            // 
            this.buttonHighest.Location = new System.Drawing.Point(555, 213);
            this.buttonHighest.Name = "buttonHighest";
            this.buttonHighest.Size = new System.Drawing.Size(153, 34);
            this.buttonHighest.TabIndex = 3;
            this.buttonHighest.Text = "Display Highest";
            this.buttonHighest.UseVisualStyleBackColor = true;
            this.buttonHighest.Click += new System.EventHandler(this.buttonHighest_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(555, 51);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(153, 34);
            this.buttonSum.TabIndex = 4;
            this.buttonSum.Text = "Display Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonAvg
            // 
            this.buttonAvg.Location = new System.Drawing.Point(310, 298);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(153, 34);
            this.buttonAvg.TabIndex = 5;
            this.buttonAvg.Text = "Display Avg";
            this.buttonAvg.UseVisualStyleBackColor = true;
            this.buttonAvg.Click += new System.EventHandler(this.buttonAvg_Click);
            // 
            // buttonAscending
            // 
            this.buttonAscending.Location = new System.Drawing.Point(555, 134);
            this.buttonAscending.Name = "buttonAscending";
            this.buttonAscending.Size = new System.Drawing.Size(153, 34);
            this.buttonAscending.TabIndex = 6;
            this.buttonAscending.Text = "Sort Ascending";
            this.buttonAscending.UseVisualStyleBackColor = true;
            this.buttonAscending.Click += new System.EventHandler(this.buttonAscending_Click);
            // 
            // buttonDescending
            // 
            this.buttonDescending.Location = new System.Drawing.Point(310, 134);
            this.buttonDescending.Name = "buttonDescending";
            this.buttonDescending.Size = new System.Drawing.Size(153, 34);
            this.buttonDescending.TabIndex = 7;
            this.buttonDescending.Text = "Sort Descending";
            this.buttonDescending.UseVisualStyleBackColor = true;
            this.buttonDescending.Click += new System.EventHandler(this.buttonDescending_Click);
            // 
            // buttonBinarySearch
            // 
            this.buttonBinarySearch.Location = new System.Drawing.Point(555, 298);
            this.buttonBinarySearch.Name = "buttonBinarySearch";
            this.buttonBinarySearch.Size = new System.Drawing.Size(83, 34);
            this.buttonBinarySearch.TabIndex = 8;
            this.buttonBinarySearch.Text = "Binary Search";
            this.buttonBinarySearch.UseVisualStyleBackColor = true;
            this.buttonBinarySearch.Click += new System.EventHandler(this.buttonBinarySearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(310, 384);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(153, 34);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear List Box";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(433, 478);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(153, 34);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(555, 384);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(153, 34);
            this.buttonHelp.TabIndex = 11;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(75, 26);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(153, 563);
            this.listBoxDisplay.TabIndex = 12;
            // 
            // textBoxBinarySearch
            // 
            this.textBoxBinarySearch.Location = new System.Drawing.Point(644, 312);
            this.textBoxBinarySearch.Name = "textBoxBinarySearch";
            this.textBoxBinarySearch.Size = new System.Drawing.Size(64, 20);
            this.textBoxBinarySearch.TabIndex = 13;
            // 
            // ArrayFunGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.textBoxBinarySearch);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBinarySearch);
            this.Controls.Add(this.buttonDescending);
            this.Controls.Add(this.buttonAscending);
            this.Controls.Add(this.buttonAvg);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonHighest);
            this.Controls.Add(this.buttonLowest);
            this.Controls.Add(this.buttonDisplayArray);
            this.Name = "ArrayFunGUI";
            this.Text = "ArrayFunGUI";
            this.Load += new System.EventHandler(this.ArrayFunGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisplayArray;
        private System.Windows.Forms.Button buttonLowest;
        private System.Windows.Forms.Button buttonHighest;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonAscending;
        private System.Windows.Forms.Button buttonDescending;
        private System.Windows.Forms.Button buttonBinarySearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.TextBox textBoxBinarySearch;
    }
}

