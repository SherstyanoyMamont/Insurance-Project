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
            button1 = new Button();
            labelFirstName = new Label();
            labelSurname = new Label();
            labelDoB = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelCarModel = new Label();
            comboBox2 = new ComboBox();
            labelDiscount = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(849, 628);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Add Client";
            button1.UseVisualStyleBackColor = true;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(293, 443);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 31);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(293, 329);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 33);
            comboBox1.TabIndex = 7;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(293, 277);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 10;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(293, 387);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 33);
            comboBox2.TabIndex = 12;
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
            Controls.Add(comboBox2);
            Controls.Add(labelCarModel);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(labelDoB);
            Controls.Add(labelSurname);
            Controls.Add(labelFirstName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelFirstName;
        private Label labelSurname;
        private Label labelDoB;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label labelCarModel;
        private ComboBox comboBox2;
        private Label labelDiscount;
        private Label label2;
    }
}
