namespace Insurance_Project
{
    partial class RegistrationForm
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
            Label label1;
            textBoxUsernameReg = new TextBox();
            Password = new Label();
            textBoxPasswordReg = new TextBox();
            label2 = new Label();
            textBoxConfirmPasswordReg = new TextBox();
            buttonRegister = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBoxRole = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 151);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBoxUsernameReg
            // 
            textBoxUsernameReg.Location = new Point(263, 144);
            textBoxUsernameReg.Name = "textBoxUsernameReg";
            textBoxUsernameReg.Size = new Size(236, 27);
            textBoxUsernameReg.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(144, 203);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // textBoxPasswordReg
            // 
            textBoxPasswordReg.Location = new Point(263, 196);
            textBoxPasswordReg.Name = "textBoxPasswordReg";
            textBoxPasswordReg.PasswordChar = '*';
            textBoxPasswordReg.Size = new Size(236, 27);
            textBoxPasswordReg.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 251);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 4;
            label2.Text = "Confirm Password";
            // 
            // textBoxConfirmPasswordReg
            // 
            textBoxConfirmPasswordReg.Location = new Point(263, 248);
            textBoxConfirmPasswordReg.Name = "textBoxConfirmPasswordReg";
            textBoxConfirmPasswordReg.PasswordChar = '*';
            textBoxConfirmPasswordReg.Size = new Size(236, 27);
            textBoxConfirmPasswordReg.TabIndex = 5;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(405, 363);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(94, 29);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 48);
            label3.Name = "label3";
            label3.Size = new Size(264, 41);
            label3.TabIndex = 7;
            label3.Text = "RegistrationForm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 298);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Manager", "Administrator" });
            comboBoxRole.Location = new Point(263, 295);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(236, 28);
            comboBoxRole.TabIndex = 9;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 423);
            Controls.Add(comboBoxRole);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxConfirmPasswordReg);
            Controls.Add(label2);
            Controls.Add(textBoxPasswordReg);
            Controls.Add(Password);
            Controls.Add(textBoxUsernameReg);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsernameReg;
        private Label Password;
        private TextBox textBoxPasswordReg;
        private Label label2;
        private TextBox textBoxConfirmPasswordReg;
        private Button buttonRegister;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxRole;
    }
}