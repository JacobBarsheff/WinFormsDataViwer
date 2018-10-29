namespace WinForms_DataViewer
{
    partial class Detail
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
            this.picture_weatherIcon = new System.Windows.Forms.PictureBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Long = new System.Windows.Forms.Label();
            this.lbl_lat = new System.Windows.Forms.Label();
            this.lbl_weatherDesc = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_WindSpeed = new System.Windows.Forms.Label();
            this.lbl_Cloud = new System.Windows.Forms.Label();
            this.lbl_Pressure = new System.Windows.Forms.Label();
            this.lbl_Humidity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_WindDeg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_weatherIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_weatherIcon
            // 
            this.picture_weatherIcon.Location = new System.Drawing.Point(132, 47);
            this.picture_weatherIcon.Name = "picture_weatherIcon";
            this.picture_weatherIcon.Size = new System.Drawing.Size(101, 101);
            this.picture_weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_weatherIcon.TabIndex = 0;
            this.picture_weatherIcon.TabStop = false;
            this.picture_weatherIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_City
            // 
            this.lbl_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(159, 4);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(58, 40);
            this.lbl_City.TabIndex = 1;
            this.lbl_City.Text = "City";
            this.lbl_City.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(6, 16);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(43, 13);
            this.lbl_Country.TabIndex = 2;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_Long
            // 
            this.lbl_Long.AutoSize = true;
            this.lbl_Long.Location = new System.Drawing.Point(6, 36);
            this.lbl_Long.Name = "lbl_Long";
            this.lbl_Long.Size = new System.Drawing.Size(54, 13);
            this.lbl_Long.TabIndex = 3;
            this.lbl_Long.Text = "Longitude";
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Location = new System.Drawing.Point(6, 54);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(45, 13);
            this.lbl_lat.TabIndex = 4;
            this.lbl_lat.Text = "Latitude";
            // 
            // lbl_weatherDesc
            // 
            this.lbl_weatherDesc.AutoSize = true;
            this.lbl_weatherDesc.Location = new System.Drawing.Point(6, 54);
            this.lbl_weatherDesc.Name = "lbl_weatherDesc";
            this.lbl_weatherDesc.Size = new System.Drawing.Size(70, 13);
            this.lbl_weatherDesc.TabIndex = 5;
            this.lbl_weatherDesc.Text = "weatherDesc";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(6, 16);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(34, 13);
            this.lbl_Temp.TabIndex = 6;
            this.lbl_Temp.Text = "Temp";
            // 
            // lbl_WindSpeed
            // 
            this.lbl_WindSpeed.AutoSize = true;
            this.lbl_WindSpeed.Location = new System.Drawing.Point(6, 73);
            this.lbl_WindSpeed.Name = "lbl_WindSpeed";
            this.lbl_WindSpeed.Size = new System.Drawing.Size(63, 13);
            this.lbl_WindSpeed.TabIndex = 7;
            this.lbl_WindSpeed.Text = "WindSpeed";
            // 
            // lbl_Cloud
            // 
            this.lbl_Cloud.AutoSize = true;
            this.lbl_Cloud.Location = new System.Drawing.Point(6, 36);
            this.lbl_Cloud.Name = "lbl_Cloud";
            this.lbl_Cloud.Size = new System.Drawing.Size(83, 13);
            this.lbl_Cloud.TabIndex = 8;
            this.lbl_Cloud.Text = "Cloud Coverage";
            // 
            // lbl_Pressure
            // 
            this.lbl_Pressure.AutoSize = true;
            this.lbl_Pressure.Location = new System.Drawing.Point(250, 26);
            this.lbl_Pressure.Name = "lbl_Pressure";
            this.lbl_Pressure.Size = new System.Drawing.Size(48, 13);
            this.lbl_Pressure.TabIndex = 9;
            this.lbl_Pressure.Text = "Pressure";
            // 
            // lbl_Humidity
            // 
            this.lbl_Humidity.AutoSize = true;
            this.lbl_Humidity.Location = new System.Drawing.Point(172, 26);
            this.lbl_Humidity.Name = "lbl_Humidity";
            this.lbl_Humidity.Size = new System.Drawing.Size(47, 13);
            this.lbl_Humidity.TabIndex = 10;
            this.lbl_Humidity.Text = "Humidity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Country);
            this.groupBox1.Controls.Add(this.lbl_Long);
            this.groupBox1.Controls.Add(this.lbl_lat);
            this.groupBox1.Location = new System.Drawing.Point(8, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_WindSpeed);
            this.groupBox2.Controls.Add(this.lbl_Temp);
            this.groupBox2.Controls.Add(this.lbl_Cloud);
            this.groupBox2.Controls.Add(this.lbl_weatherDesc);
            this.groupBox2.Location = new System.Drawing.Point(195, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 103);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Conditions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_WindDeg);
            this.groupBox3.Controls.Add(this.lbl_Humidity);
            this.groupBox3.Controls.Add(this.lbl_Pressure);
            this.groupBox3.Location = new System.Drawing.Point(8, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 52);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Info";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(272, 321);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_WindDeg
            // 
            this.lbl_WindDeg.AutoSize = true;
            this.lbl_WindDeg.Location = new System.Drawing.Point(4, 25);
            this.lbl_WindDeg.Name = "lbl_WindDeg";
            this.lbl_WindDeg.Size = new System.Drawing.Size(72, 13);
            this.lbl_WindDeg.TabIndex = 11;
            this.lbl_WindDeg.Text = "WindDegrees";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 356);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.picture_weatherIcon);
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_weatherIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_weatherIcon;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Long;
        private System.Windows.Forms.Label lbl_lat;
        private System.Windows.Forms.Label lbl_weatherDesc;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_WindSpeed;
        private System.Windows.Forms.Label lbl_Cloud;
        private System.Windows.Forms.Label lbl_Pressure;
        private System.Windows.Forms.Label lbl_Humidity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_WindDeg;
    }
}