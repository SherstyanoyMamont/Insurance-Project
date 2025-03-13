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
            labelFirstName.Location = new Point(111, 160);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(97, 25);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            labelFirstName.Click += label1_Click;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(111, 216);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(82, 25);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname";
            // 
            // labelDoB
            // 
            labelDoB.AutoSize = true;
            labelDoB.Location = new Point(111, 282);
            labelDoB.Name = "labelDoB";
            labelDoB.Size = new Size(112, 25);
            labelDoB.TabIndex = 3;
            labelDoB.Text = "Date of Birth";
            // 
            // checkBoxDiscount
            // 
            checkBoxDiscount.AutoSize = true;
            checkBoxDiscount.Location = new Point(293, 443);
            checkBoxDiscount.Name = "checkBoxDiscount";
            checkBoxDiscount.Size = new Size(78, 29);
            checkBoxDiscount.TabIndex = 4;
            checkBoxDiscount.Text = " 10%";
            checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(293, 157);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(300, 31);
            textBoxFirstName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(293, 216);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(300, 31);
            textBoxSurname.TabIndex = 6;
            // 
            // comboBoxCarBrand
            // 
            comboBoxCarBrand.FormattingEnabled = true;
            comboBoxCarBrand.Location = new Point(293, 329);
            comboBoxCarBrand.Name = "comboBoxCarBrand";
            comboBoxCarBrand.Size = new Size(300, 33);
            comboBoxCarBrand.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 332);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 8;
            label1.Text = "Car Brand";
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Location = new Point(293, 277);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(300, 31);
            dateTimePickerDoB.TabIndex = 10;
            // 
            // labelCarModel
            // 
            labelCarModel.AutoSize = true;
            labelCarModel.Location = new Point(111, 390);
            labelCarModel.Name = "labelCarModel";
            labelCarModel.Size = new Size(94, 25);
            labelCarModel.TabIndex = 11;
            labelCarModel.Text = "Car Model";
            // 
            // comboBoxCarModel
            // 
            comboBoxCarModel.FormattingEnabled = true;
            comboBoxCarModel.Location = new Point(293, 387);
            comboBoxCarModel.Name = "comboBoxCarModel";
            comboBoxCarModel.Size = new Size(300, 33);
            comboBoxCarModel.TabIndex = 12;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(111, 443);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 710);
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
    }
}
