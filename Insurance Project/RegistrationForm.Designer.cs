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
            TextBox textBoxUsernameReg;
            Password = new Label();
            textBoxPasswordReg = new TextBox();
            label2 = new Label();
            textBoxConfirmPasswordReg = new TextBox();
            buttonRegister = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBoxRole = new ComboBox();
            buttonSkipR = new Button();
            label1 = new Label();
            textBoxUsernameReg = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 189);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBoxUsernameReg
            // 
            textBoxUsernameReg.Location = new Point(329, 180);
            textBoxUsernameReg.Margin = new Padding(4);
            textBoxUsernameReg.Name = "textBoxUsernameReg";
            textBoxUsernameReg.Size = new Size(294, 31);
            textBoxUsernameReg.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(180, 254);
            Password.Margin = new Padding(4, 0, 4, 0);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // textBoxPasswordReg
            // 
            textBoxPasswordReg.Location = new Point(329, 245);
            textBoxPasswordReg.Margin = new Padding(4);
            textBoxPasswordReg.Name = "textBoxPasswordReg";
            textBoxPasswordReg.PasswordChar = '*';
            textBoxPasswordReg.Size = new Size(294, 31);
            textBoxPasswordReg.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 314);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 4;
            label2.Text = "Confirm Password";
            // 
            // textBoxConfirmPasswordReg
            // 
            textBoxConfirmPasswordReg.Location = new Point(329, 310);
            textBoxConfirmPasswordReg.Margin = new Padding(4);
            textBoxConfirmPasswordReg.Name = "textBoxConfirmPasswordReg";
            textBoxConfirmPasswordReg.PasswordChar = '*';
            textBoxConfirmPasswordReg.Size = new Size(294, 31);
            textBoxConfirmPasswordReg.TabIndex = 5;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(506, 454);
            buttonRegister.Margin = new Padding(4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(118, 36);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(313, 48);
            label3.TabIndex = 7;
            label3.Text = "RegistrationForm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 372);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Manager", "Administrator" });
            comboBoxRole.Location = new Point(329, 369);
            comboBoxRole.Margin = new Padding(4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(294, 33);
            comboBoxRole.TabIndex = 9;
            // 
            // buttonSkipR
            // 
            buttonSkipR.Location = new Point(374, 454);
            buttonSkipR.Name = "buttonSkipR";
            buttonSkipR.Size = new Size(112, 34);
            buttonSkipR.TabIndex = 12;
            buttonSkipR.Text = "Skip";
            buttonSkipR.UseVisualStyleBackColor = true;
            buttonSkipR.Click += buttonSkipR_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 529);
            Controls.Add(buttonSkipR);
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
            Margin = new Padding(4);
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
        private Button buttonSkipR;
    }
}