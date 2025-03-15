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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 139);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 206);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxUsernameLogin
            // 
            textBoxUsernameLogin.Location = new Point(223, 139);
            textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            textBoxUsernameLogin.Size = new Size(191, 27);
            textBoxUsernameLogin.TabIndex = 2;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.Location = new Point(219, 206);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.PasswordChar = '*';
            textBoxPasswordLogin.Size = new Size(195, 27);
            textBoxPasswordLogin.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(320, 284);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 48);
            label3.Name = "label3";
            label3.Size = new Size(97, 41);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 390);
            Controls.Add(label3);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPasswordLogin);
            Controls.Add(textBoxUsernameLogin);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}