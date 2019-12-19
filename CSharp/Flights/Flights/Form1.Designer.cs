namespace Flights
{
    partial class Flights
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
            this.textBoxFlightInfo = new System.Windows.Forms.TextBox();
            this.textBoxAirportName = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.labelAirportName = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelFlightNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelTIme = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFlightInfo
            // 
            this.textBoxFlightInfo.Location = new System.Drawing.Point(524, 249);
            this.textBoxFlightInfo.Name = "textBoxFlightInfo";
            this.textBoxFlightInfo.ReadOnly = true;
            this.textBoxFlightInfo.Size = new System.Drawing.Size(160, 20);
            this.textBoxFlightInfo.TabIndex = 21;
            // 
            // textBoxAirportName
            // 
            this.textBoxAirportName.Location = new System.Drawing.Point(251, 285);
            this.textBoxAirportName.Name = "textBoxAirportName";
            this.textBoxAirportName.Size = new System.Drawing.Size(143, 20);
            this.textBoxAirportName.TabIndex = 20;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(251, 227);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(143, 20);
            this.textBoxCode.TabIndex = 19;
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Location = new System.Drawing.Point(251, 169);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(143, 20);
            this.textBoxFlightNumber.TabIndex = 18;
            // 
            // labelAirportName
            // 
            this.labelAirportName.AutoSize = true;
            this.labelAirportName.Location = new System.Drawing.Point(161, 288);
            this.labelAirportName.Name = "labelAirportName";
            this.labelAirportName.Size = new System.Drawing.Size(68, 13);
            this.labelAirportName.TabIndex = 17;
            this.labelAirportName.Text = "Airport Name";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(161, 230);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(65, 13);
            this.labelCode.TabIndex = 16;
            this.labelCode.Text = "Airport Code";
            // 
            // labelFlightNumber
            // 
            this.labelFlightNumber.AutoSize = true;
            this.labelFlightNumber.Location = new System.Drawing.Point(161, 172);
            this.labelFlightNumber.Name = "labelFlightNumber";
            this.labelFlightNumber.Size = new System.Drawing.Size(72, 13);
            this.labelFlightNumber.TabIndex = 15;
            this.labelFlightNumber.Text = "Flight Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(524, 79);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(160, 48);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(164, 94);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(230, 20);
            this.textBoxSearch.TabIndex = 12;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(161, 78);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(140, 13);
            this.labelInstructions.TabIndex = 11;
            this.labelInstructions.Text = "Enter Flight Number or Code";
            // 
            // labelTIme
            // 
            this.labelTIme.AutoSize = true;
            this.labelTIme.Location = new System.Drawing.Point(161, 355);
            this.labelTIme.Name = "labelTIme";
            this.labelTIme.Size = new System.Drawing.Size(30, 13);
            this.labelTIme.TabIndex = 22;
            this.labelTIme.Text = "Time";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(251, 352);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(143, 20);
            this.textBoxTime.TabIndex = 23;
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTIme);
            this.Controls.Add(this.textBoxFlightInfo);
            this.Controls.Add(this.textBoxAirportName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxFlightNumber);
            this.Controls.Add(this.labelAirportName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelFlightNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelInstructions);
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFlightInfo;
        private System.Windows.Forms.TextBox textBoxAirportName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxFlightNumber;
        private System.Windows.Forms.Label labelAirportName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelTIme;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}

