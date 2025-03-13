namespace Insurance_Project
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEngineSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPenaltyPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDriverLicense).BeginInit();
            SuspendLayout();
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(849, 628);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(112, 34);
            buttonAddClient.TabIndex = 0;
            buttonAddClient.Text = "Add Client";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(51, 162);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(97, 25);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            labelFirstName.Click += label1_Click;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(51, 218);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(82, 25);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname";
            // 
            // labelDoB
            // 
            labelDoB.AutoSize = true;
            labelDoB.Location = new Point(51, 274);
            labelDoB.Name = "labelDoB";
            labelDoB.Size = new Size(112, 25);
            labelDoB.TabIndex = 3;
            labelDoB.Text = "Date of Birth";
            // 
            // checkBoxDiscount
            // 
            checkBoxDiscount.AutoSize = true;
            checkBoxDiscount.Location = new Point(247, 628);
            checkBoxDiscount.Name = "checkBoxDiscount";
            checkBoxDiscount.Size = new Size(78, 29);
            checkBoxDiscount.TabIndex = 4;
            checkBoxDiscount.Text = " 10%";
            checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(188, 156);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(321, 31);
            textBoxFirstName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(188, 215);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(321, 31);
            textBoxSurname.TabIndex = 6;
            // 
            // comboBoxCarBrand
            // 
            comboBoxCarBrand.FormattingEnabled = true;
            comboBoxCarBrand.Location = new Point(687, 151);
            comboBoxCarBrand.Name = "comboBoxCarBrand";
            comboBoxCarBrand.Size = new Size(300, 33);
            comboBoxCarBrand.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(557, 154);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 8;
            label1.Text = "Car Brand";
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Location = new Point(188, 266);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(321, 31);
            dateTimePickerDoB.TabIndex = 10;
            // 
            // labelCarModel
            // 
            labelCarModel.AutoSize = true;
            labelCarModel.Location = new Point(557, 212);
            labelCarModel.Name = "labelCarModel";
            labelCarModel.Size = new Size(94, 25);
            labelCarModel.TabIndex = 11;
            labelCarModel.Text = "Car Model";
            // 
            // comboBoxCarModel
            // 
            comboBoxCarModel.FormattingEnabled = true;
            comboBoxCarModel.Location = new Point(687, 209);
            comboBoxCarModel.Name = "comboBoxCarModel";
            comboBoxCarModel.Size = new Size(300, 33);
            comboBoxCarModel.TabIndex = 12;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(65, 628);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(82, 25);
            labelDiscount.TabIndex = 13;
            labelDiscount.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 43);
            label2.Name = "label2";
            label2.Size = new Size(351, 48);
            label2.TabIndex = 14;
            label2.Text = "Insurance Company";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(557, 266);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 15;
            label3.Text = "Colour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 315);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 16;
            label4.Text = "Year";
            // 
            // textBoxColour
            // 
            textBoxColour.Location = new Point(687, 266);
            textBoxColour.Name = "textBoxColour";
            textBoxColour.Size = new Size(300, 31);
            textBoxColour.TabIndex = 17;
            // 
            // numericUpDownCarYear
            // 
            numericUpDownCarYear.Location = new Point(687, 316);
            numericUpDownCarYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownCarYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numericUpDownCarYear.Name = "numericUpDownCarYear";
            numericUpDownCarYear.Size = new Size(300, 31);
            numericUpDownCarYear.TabIndex = 2020;
            numericUpDownCarYear.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 365);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 2021;
            label5.Text = "Engine Size";
            // 
            // numericUpDownEngineSize
            // 
            numericUpDownEngineSize.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownEngineSize.Location = new Point(687, 365);
            numericUpDownEngineSize.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownEngineSize.Name = "numericUpDownEngineSize";
            numericUpDownEngineSize.Size = new Size(300, 31);
            numericUpDownEngineSize.TabIndex = 2022;
            numericUpDownEngineSize.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 322);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 2023;
            label6.Text = "Driver License";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 371);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 2024;
            label7.Text = "Penalty Points";
            // 
            // numericUpDownPenaltyPoints
            // 
            numericUpDownPenaltyPoints.Location = new Point(188, 371);
            numericUpDownPenaltyPoints.Name = "numericUpDownPenaltyPoints";
            numericUpDownPenaltyPoints.Size = new Size(321, 31);
            numericUpDownPenaltyPoints.TabIndex = 2025;
            // 
            // numericUpDownDriverLicense
            // 
            numericUpDownDriverLicense.Location = new Point(188, 320);
            numericUpDownDriverLicense.Name = "numericUpDownDriverLicense";
            numericUpDownDriverLicense.Size = new Size(321, 31);
            numericUpDownDriverLicense.TabIndex = 2026;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 710);
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
            Name = "Form1";
            Text = "Form1";
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
    }
}
