namespace Insurance_Project
{
    partial class MainForm
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
            buttonAddClient = new Button();
            labelFirstName = new Label();
            labelSurname = new Label();
            labelDoB = new Label();
            checkBoxDiscount = new CheckBox();
            textBoxFirstName = new TextBox();
            textBoxSurname = new TextBox();
            comboBoxCarBrand = new ComboBox();
            label1 = new Label();
            dateTimePickerDoB = new DateTimePicker();
            labelCarModel = new Label();
            comboBoxCarModel = new ComboBox();
            labelDiscount = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxColour = new TextBox();
            numericUpDownCarYear = new NumericUpDown();
            label5 = new Label();
            numericUpDownEngineSize = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            numericUpDownPenaltyPoints = new NumericUpDown();
            numericUpDownDriverLicense = new NumericUpDown();
            label8 = new Label();
            comboBoxGender = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            textBoxEmail = new TextBox();
            comboBoxLocation = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            comboBoxEmission = new ComboBox();
            comboBoxCoverage = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            Date = new Label();
            buttonSearch = new Button();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEngineSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPenaltyPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDriverLicense).BeginInit();
            SuspendLayout();
            // 
            // buttonAddClient
            // 
            buttonAddClient.BackColor = Color.WhiteSmoke;
            buttonAddClient.FlatAppearance.BorderColor = Color.DarkGray;
            buttonAddClient.FlatStyle = FlatStyle.Flat;
            buttonAddClient.ForeColor = Color.Black;
            buttonAddClient.Location = new Point(1106, 842);
            buttonAddClient.Margin = new Padding(2);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(112, 34);
            buttonAddClient.TabIndex = 0;
            buttonAddClient.Text = "Add Client";
            buttonAddClient.UseVisualStyleBackColor = false;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.ForeColor = Color.Black;
            labelFirstName.Location = new Point(94, 172);
            labelFirstName.Margin = new Padding(2, 0, 2, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(106, 28);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.ForeColor = Color.Black;
            labelSurname.Location = new Point(94, 234);
            labelSurname.Margin = new Padding(2, 0, 2, 0);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(89, 28);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname";
            // 
            // labelDoB
            // 
            labelDoB.AutoSize = true;
            labelDoB.ForeColor = Color.Black;
            labelDoB.Location = new Point(93, 303);
            labelDoB.Margin = new Padding(2, 0, 2, 0);
            labelDoB.Name = "labelDoB";
            labelDoB.Size = new Size(122, 28);
            labelDoB.TabIndex = 3;
            labelDoB.Text = "Date of Birth";
            // 
            // checkBoxDiscount
            // 
            checkBoxDiscount.AutoSize = true;
            checkBoxDiscount.ForeColor = Color.Black;
            checkBoxDiscount.Location = new Point(263, 782);
            checkBoxDiscount.Margin = new Padding(2);
            checkBoxDiscount.Name = "checkBoxDiscount";
            checkBoxDiscount.Size = new Size(81, 32);
            checkBoxDiscount.TabIndex = 4;
            checkBoxDiscount.Text = " 10%";
            checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Location = new Point(263, 170);
            textBoxFirstName.Margin = new Padding(2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(322, 34);
            textBoxFirstName.TabIndex = 5;
            textBoxFirstName.Text = "Ivan";
            // 
            // textBoxSurname
            // 
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Location = new Point(263, 232);
            textBoxSurname.Margin = new Padding(2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(322, 34);
            textBoxSurname.TabIndex = 6;
            textBoxSurname.Text = "Korotkov";
            // 
            // comboBoxCarBrand
            // 
            comboBoxCarBrand.FlatStyle = FlatStyle.Flat;
            comboBoxCarBrand.FormattingEnabled = true;
            comboBoxCarBrand.Location = new Point(850, 170);
            comboBoxCarBrand.Margin = new Padding(2);
            comboBoxCarBrand.Name = "comboBoxCarBrand";
            comboBoxCarBrand.Size = new Size(300, 36);
            comboBoxCarBrand.TabIndex = 7;
            comboBoxCarBrand.Text = "BMW";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(720, 172);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 8;
            label1.Text = "Car Brand";
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.CalendarForeColor = Color.Black;
            dateTimePickerDoB.CalendarTitleForeColor = Color.Black;
            dateTimePickerDoB.Location = new Point(263, 297);
            dateTimePickerDoB.Margin = new Padding(2);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(322, 34);
            dateTimePickerDoB.TabIndex = 10;
            // 
            // labelCarModel
            // 
            labelCarModel.AutoSize = true;
            labelCarModel.ForeColor = Color.Black;
            labelCarModel.Location = new Point(720, 236);
            labelCarModel.Margin = new Padding(2, 0, 2, 0);
            labelCarModel.Name = "labelCarModel";
            labelCarModel.Size = new Size(103, 28);
            labelCarModel.TabIndex = 11;
            labelCarModel.Text = "Car Model";
            // 
            // comboBoxCarModel
            // 
            comboBoxCarModel.FlatStyle = FlatStyle.Flat;
            comboBoxCarModel.FormattingEnabled = true;
            comboBoxCarModel.Location = new Point(850, 232);
            comboBoxCarModel.Margin = new Padding(2);
            comboBoxCarModel.Name = "comboBoxCarModel";
            comboBoxCarModel.Size = new Size(300, 36);
            comboBoxCarModel.TabIndex = 12;
            comboBoxCarModel.Text = "M5 Competition Saloon";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.ForeColor = Color.Black;
            labelDiscount.Location = new Point(94, 786);
            labelDiscount.Margin = new Padding(2, 0, 2, 0);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(89, 28);
            labelDiscount.TabIndex = 13;
            labelDiscount.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(456, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(380, 54);
            label2.TabIndex = 14;
            label2.Text = "Insurance Company";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(720, 296);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 15;
            label3.Text = "Colour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(720, 366);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 16;
            label4.Text = "Year";
            // 
            // textBoxColour
            // 
            textBoxColour.BorderStyle = BorderStyle.FixedSingle;
            textBoxColour.Location = new Point(850, 296);
            textBoxColour.Margin = new Padding(2);
            textBoxColour.Name = "textBoxColour";
            textBoxColour.Size = new Size(300, 34);
            textBoxColour.TabIndex = 17;
            textBoxColour.Text = "Nardo Grey";
            // 
            // numericUpDownCarYear
            // 
            numericUpDownCarYear.Location = new Point(850, 367);
            numericUpDownCarYear.Margin = new Padding(2);
            numericUpDownCarYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownCarYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numericUpDownCarYear.Name = "numericUpDownCarYear";
            numericUpDownCarYear.Size = new Size(300, 34);
            numericUpDownCarYear.TabIndex = 2020;
            numericUpDownCarYear.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(720, 434);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 2021;
            label5.Text = "Engine Size";
            // 
            // numericUpDownEngineSize
            // 
            numericUpDownEngineSize.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownEngineSize.Location = new Point(850, 431);
            numericUpDownEngineSize.Margin = new Padding(2);
            numericUpDownEngineSize.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownEngineSize.Name = "numericUpDownEngineSize";
            numericUpDownEngineSize.Size = new Size(300, 34);
            numericUpDownEngineSize.TabIndex = 2022;
            numericUpDownEngineSize.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(94, 639);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 2023;
            label6.Text = "Driver License";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(94, 709);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 2024;
            label7.Text = "Penalty Points";
            // 
            // numericUpDownPenaltyPoints
            // 
            numericUpDownPenaltyPoints.Location = new Point(263, 709);
            numericUpDownPenaltyPoints.Margin = new Padding(2);
            numericUpDownPenaltyPoints.Name = "numericUpDownPenaltyPoints";
            numericUpDownPenaltyPoints.Size = new Size(322, 34);
            numericUpDownPenaltyPoints.TabIndex = 2025;
            // 
            // numericUpDownDriverLicense
            // 
            numericUpDownDriverLicense.Location = new Point(263, 637);
            numericUpDownDriverLicense.Margin = new Padding(2);
            numericUpDownDriverLicense.Name = "numericUpDownDriverLicense";
            numericUpDownDriverLicense.Size = new Size(322, 34);
            numericUpDownDriverLicense.TabIndex = 2026;
            numericUpDownDriverLicense.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(94, 367);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 2027;
            label8.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(263, 367);
            comboBoxGender.Margin = new Padding(4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(322, 36);
            comboBoxGender.TabIndex = 2028;
            comboBoxGender.Text = "Male";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(94, 436);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 28);
            label9.TabIndex = 2029;
            label9.Text = "Phone number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(94, 569);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(59, 28);
            label10.TabIndex = 2030;
            label10.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(263, 569);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(322, 34);
            textBoxEmail.TabIndex = 2031;
            textBoxEmail.Text = "K00299347@tus.ie";
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.FlatStyle = FlatStyle.Flat;
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Items.AddRange(new object[] { "Carlow", "Cavan", "Clare", "Cork", "Donegal", "Dublin", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Waterford", "Westmeath", "Wexford", "Wicklow" });
            comboBoxLocation.Location = new Point(263, 500);
            comboBoxLocation.Margin = new Padding(4);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(322, 36);
            comboBoxLocation.TabIndex = 2034;
            comboBoxLocation.Text = "Limerick";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(94, 500);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 28);
            label11.TabIndex = 2033;
            label11.Text = "Location";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(720, 504);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 28);
            label12.TabIndex = 2035;
            label12.Text = "Emission";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(720, 573);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(95, 28);
            label13.TabIndex = 2036;
            label13.Text = "Coverage";
            // 
            // comboBoxEmission
            // 
            comboBoxEmission.FlatStyle = FlatStyle.Flat;
            comboBoxEmission.FormattingEnabled = true;
            comboBoxEmission.Items.AddRange(new object[] { "High", "Medium", "Low" });
            comboBoxEmission.Location = new Point(850, 500);
            comboBoxEmission.Margin = new Padding(4);
            comboBoxEmission.Name = "comboBoxEmission";
            comboBoxEmission.Size = new Size(300, 36);
            comboBoxEmission.TabIndex = 2037;
            comboBoxEmission.Text = "High";
            // 
            // comboBoxCoverage
            // 
            comboBoxCoverage.FlatStyle = FlatStyle.Flat;
            comboBoxCoverage.FormattingEnabled = true;
            comboBoxCoverage.Items.AddRange(new object[] { "Fully Comprehensive", "Third Party Fire and Theft" });
            comboBoxCoverage.Location = new Point(850, 569);
            comboBoxCoverage.Margin = new Padding(4);
            comboBoxCoverage.Name = "comboBoxCoverage";
            comboBoxCoverage.Size = new Size(299, 36);
            comboBoxCoverage.TabIndex = 2038;
            comboBoxCoverage.Text = "Fully Comprehensive";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CalendarForeColor = Color.Black;
            dateTimePickerDate.CalendarTitleForeColor = Color.Black;
            dateTimePickerDate.Location = new Point(906, 765);
            dateTimePickerDate.Margin = new Padding(4);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(312, 34);
            dateTimePickerDate.TabIndex = 2039;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.ForeColor = Color.Black;
            Date.Location = new Point(819, 771);
            Date.Margin = new Padding(4, 0, 4, 0);
            Date.Name = "Date";
            Date.Size = new Size(53, 28);
            Date.TabIndex = 2040;
            Date.Text = "Date";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.WhiteSmoke;
            buttonSearch.FlatAppearance.BorderColor = Color.DarkGray;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Location = new Point(959, 842);
            buttonSearch.Margin = new Padding(4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(118, 36);
            buttonSearch.TabIndex = 2041;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxPhoneNumber.Location = new Point(263, 432);
            maskedTextBoxPhoneNumber.Margin = new Padding(4);
            maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(322, 34);
            maskedTextBoxPhoneNumber.TabIndex = 2042;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 245);
            ClientSize = new Size(1261, 915);
            Controls.Add(maskedTextBoxPhoneNumber);
            Controls.Add(buttonSearch);
            Controls.Add(Date);
            Controls.Add(dateTimePickerDate);
            Controls.Add(comboBoxCoverage);
            Controls.Add(comboBoxEmission);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboBoxLocation);
            Controls.Add(label11);
            Controls.Add(textBoxEmail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBoxGender);
            Controls.Add(label8);
            Controls.Add(numericUpDownDriverLicense);
            Controls.Add(numericUpDownPenaltyPoints);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericUpDownEngineSize);
            Controls.Add(label5);
            Controls.Add(numericUpDownCarYear);
            Controls.Add(textBoxColour);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelDiscount);
            Controls.Add(comboBoxCarModel);
            Controls.Add(labelCarModel);
            Controls.Add(dateTimePickerDoB);
            Controls.Add(label1);
            Controls.Add(comboBoxCarBrand);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxFirstName);
            Controls.Add(checkBoxDiscount);
            Controls.Add(labelDoB);
            Controls.Add(labelSurname);
            Controls.Add(labelFirstName);
            Controls.Add(buttonAddClient);
            Font = new Font("Segoe UI", 10F);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insurance Calculator";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEngineSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPenaltyPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDriverLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddClient;
        private Label labelFirstName;
        private Label labelSurname;
        private Label labelDoB;
        private CheckBox checkBoxDiscount;
        private TextBox textBoxFirstName;
        private TextBox textBoxSurname;
        private ComboBox comboBoxCarBrand;
        private Label label1;
        private DateTimePicker dateTimePickerDoB;
        private Label labelCarModel;
        private ComboBox comboBoxCarModel;
        private Label labelDiscount;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxColour;
        private NumericUpDown numericUpDownCarYear;
        private Label label5;
        private NumericUpDown numericUpDownEngineSize;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownPenaltyPoints;
        private NumericUpDown numericUpDownDriverLicense;
        private Label label8;
        private ComboBox comboBoxGender;
        private Label label9;
        private Label label10;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private Label label11;
        private ComboBox comboBoxLocation;
        private Label label12;
        private Label label13;
        private ComboBox comboBoxEmission;
        private ComboBox comboBoxCoverage;
        private DateTimePicker dateTimePickerDate;
        private Label Date;
        private Button buttonSearch;
        private MaskedTextBox maskedTextBoxPhoneNumber;
        //private MaskedTextBox textBoxPhoneNumber;
    }
}
