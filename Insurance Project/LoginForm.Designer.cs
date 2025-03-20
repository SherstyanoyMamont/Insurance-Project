namespace Insurance_Project
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsernameLogin = new TextBox();
            textBoxPasswordLogin = new TextBox();
            buttonLogin = new Button();
            label3 = new Label();
            buttonSkip = new Button();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 174);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 258);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxUsernameLogin
            // 
            textBoxUsernameLogin.Location = new Point(279, 174);
            textBoxUsernameLogin.Margin = new Padding(4);
            textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            textBoxUsernameLogin.Size = new Size(238, 31);
            textBoxUsernameLogin.TabIndex = 2;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.Location = new Point(274, 258);
            textBoxPasswordLogin.Margin = new Padding(4);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.PasswordChar = '*';
            textBoxPasswordLogin.Size = new Size(243, 31);
            textBoxPasswordLogin.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(400, 355);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(118, 36);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 48);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // buttonSkip
            // 
            buttonSkip.Location = new Point(274, 355);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(112, 34);
            buttonSkip.TabIndex = 11;
            buttonSkip.Text = "Skip";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(139, 355);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(112, 34);
            buttonRegister.TabIndex = 12;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 488);
            Controls.Add(buttonRegister);
            Controls.Add(buttonSkip);
            Controls.Add(label3);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPasswordLogin);
            Controls.Add(textBoxUsernameLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsernameLogin;
        private TextBox textBoxPasswordLogin;
        private Button buttonLogin;
        private Label label3;
        private Button buttonSkip;
        private Button buttonRegister;
    }
}