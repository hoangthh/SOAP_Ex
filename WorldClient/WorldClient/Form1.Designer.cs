namespace WorldClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetAllCountries = new Button();
            dataGridViewCountries = new DataGridView();
            btnGetCountryByCode = new Button();
            txtCountryCode = new TextBox();
            label1 = new Label();
            btnGetCityByName = new Button();
            label2 = new Label();
            txtCityName = new TextBox();
            dataGridViewCity = new DataGridView();
            btnGetCitiesByCountryCode = new Button();
            label3 = new Label();
            txtCountryCodeCities = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCity).BeginInit();
            SuspendLayout();
            // 
            // btnGetAllCountries
            // 
            btnGetAllCountries.Location = new Point(64, 9);
            btnGetAllCountries.Name = "btnGetAllCountries";
            btnGetAllCountries.Size = new Size(161, 29);
            btnGetAllCountries.TabIndex = 0;
            btnGetAllCountries.Text = "Get All Countries";
            btnGetAllCountries.UseVisualStyleBackColor = true;
            btnGetAllCountries.Click += btnGetAllCountries_Click;
            // 
            // dataGridViewCountries
            // 
            dataGridViewCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountries.Location = new Point(12, 93);
            dataGridViewCountries.Name = "dataGridViewCountries";
            dataGridViewCountries.RowHeadersWidth = 51;
            dataGridViewCountries.Size = new Size(582, 659);
            dataGridViewCountries.TabIndex = 2;
            // 
            // btnGetCountryByCode
            // 
            btnGetCountryByCode.Location = new Point(394, 9);
            btnGetCountryByCode.Name = "btnGetCountryByCode";
            btnGetCountryByCode.Size = new Size(200, 29);
            btnGetCountryByCode.TabIndex = 3;
            btnGetCountryByCode.Text = "Get Country By Code";
            btnGetCountryByCode.UseVisualStyleBackColor = true;
            btnGetCountryByCode.Click += btnGetCountryByCode_Click;
            // 
            // txtCountryCode
            // 
            txtCountryCode.Location = new Point(428, 44);
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.Size = new Size(125, 27);
            txtCountryCode.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 51);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 5;
            label1.Text = "Country Code:";
            // 
            // btnGetCityByName
            // 
            btnGetCityByName.Location = new Point(742, 9);
            btnGetCityByName.Name = "btnGetCityByName";
            btnGetCityByName.Size = new Size(155, 29);
            btnGetCityByName.TabIndex = 6;
            btnGetCityByName.Text = "Get City By Name";
            btnGetCityByName.UseVisualStyleBackColor = true;
            btnGetCityByName.Click += btnGetCityByName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(652, 51);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 7;
            label2.Text = "City Name:";
            // 
            // txtCityName
            // 
            txtCityName.Location = new Point(759, 44);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(125, 27);
            txtCityName.TabIndex = 8;
            // 
            // dataGridViewCity
            // 
            dataGridViewCity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCity.Location = new Point(652, 93);
            dataGridViewCity.Name = "dataGridViewCity";
            dataGridViewCity.RowHeadersWidth = 51;
            dataGridViewCity.Size = new Size(787, 659);
            dataGridViewCity.TabIndex = 9;
            // 
            // btnGetCitiesByCountryCode
            // 
            btnGetCitiesByCountryCode.Location = new Point(1106, 12);
            btnGetCitiesByCountryCode.Name = "btnGetCitiesByCountryCode";
            btnGetCitiesByCountryCode.Size = new Size(189, 29);
            btnGetCitiesByCountryCode.TabIndex = 10;
            btnGetCitiesByCountryCode.Text = "Get Cities By Country Code";
            btnGetCitiesByCountryCode.UseVisualStyleBackColor = true;
            btnGetCitiesByCountryCode.Click += btnGetCitiesByCountryCode_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(979, 51);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 11;
            label3.Text = "Country Code Cities:";
            // 
            // txtCountryCodeCities
            // 
            txtCountryCodeCities.Location = new Point(1138, 47);
            txtCountryCodeCities.Name = "txtCountryCodeCities";
            txtCountryCodeCities.Size = new Size(125, 27);
            txtCountryCodeCities.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 764);
            Controls.Add(txtCountryCodeCities);
            Controls.Add(label3);
            Controls.Add(btnGetCitiesByCountryCode);
            Controls.Add(dataGridViewCity);
            Controls.Add(txtCityName);
            Controls.Add(label2);
            Controls.Add(btnGetCityByName);
            Controls.Add(label1);
            Controls.Add(txtCountryCode);
            Controls.Add(btnGetCountryByCode);
            Controls.Add(dataGridViewCountries);
            Controls.Add(btnGetAllCountries);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetAllCountries;
        private DataGridView dataGridViewCountries;
        private Button btnGetCountryByCode;
        private TextBox txtCountryCode;
        private Label label1;
        private Button btnGetCityByName;
        private Label label2;
        private TextBox txtCityName;
        private DataGridView dataGridViewCity;
        private Button btnGetCitiesByCountryCode;
        private Label label3;
        private TextBox txtCountryCodeCities;
    }
}
