namespace WinForms_DataViewer
{
    partial class List
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
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_tempScroll = new System.Windows.Forms.Label();
            this._chexBoxTemp = new System.Windows.Forms.CheckBox();
            this.btn_moreDetails = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.AllowUserToAddRows = false;
            this.dataGridViewCities.AllowUserToDeleteRows = false;
            this.dataGridViewCities.AllowUserToResizeColumns = false;
            this.dataGridViewCities.AllowUserToResizeRows = false;
            this.dataGridViewCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCities.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCities.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.Size = new System.Drawing.Size(857, 276);
            this.dataGridViewCities.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(454, 45);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Current Weather For Major US Cities\r\n";
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(97, 350);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(100, 20);
            this.txtBox_search.TabIndex = 2;
            this.txtBox_search.TextChanged += new System.EventHandler(this.txtBox_search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(12, 353);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(79, 13);
            this.lbl_Search.TabIndex = 3;
            this.lbl_Search.Text = "Search By City:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(391, 350);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Minimum = -30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 75;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbl_tempScroll
            // 
            this.lbl_tempScroll.AutoSize = true;
            this.lbl_tempScroll.Location = new System.Drawing.Point(215, 353);
            this.lbl_tempScroll.Name = "lbl_tempScroll";
            this.lbl_tempScroll.Size = new System.Drawing.Size(187, 13);
            this.lbl_tempScroll.TabIndex = 5;
            this.lbl_tempScroll.Text = "Current Temperature at or Below (75) :";
            // 
            // _chexBoxTemp
            // 
            this._chexBoxTemp.AutoSize = true;
            this._chexBoxTemp.Location = new System.Drawing.Point(501, 353);
            this._chexBoxTemp.Name = "_chexBoxTemp";
            this._chexBoxTemp.Size = new System.Drawing.Size(123, 17);
            this._chexBoxTemp.TabIndex = 6;
            this._chexBoxTemp.Text = "Sort By Temperature";
            this._chexBoxTemp.UseVisualStyleBackColor = true;
            this._chexBoxTemp.CheckedChanged += new System.EventHandler(this._chexBoxTemp_CheckedChanged);
            // 
            // btn_moreDetails
            // 
            this.btn_moreDetails.Location = new System.Drawing.Point(632, 30);
            this.btn_moreDetails.Name = "btn_moreDetails";
            this.btn_moreDetails.Size = new System.Drawing.Size(75, 23);
            this.btn_moreDetails.TabIndex = 7;
            this.btn_moreDetails.Text = "More Details";
            this.btn_moreDetails.UseVisualStyleBackColor = true;
            this.btn_moreDetails.Click += new System.EventHandler(this.btn_moreDetails_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(713, 30);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 23);
            this.btn_Help.TabIndex = 8;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(794, 30);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 388);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_moreDetails);
            this.Controls.Add(this._chexBoxTemp);
            this.Controls.Add(this.lbl_tempScroll);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txtBox_search);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dataGridViewCities);
            this.Name = "List";
            this.Text = "WeatherPLUS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txtBox_search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_tempScroll;
        private System.Windows.Forms.CheckBox _chexBoxTemp;
        private System.Windows.Forms.Button btn_moreDetails;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Close;
    }
}

