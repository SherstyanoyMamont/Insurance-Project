namespace Insurance_Project
{
    partial class frmAddModifyProduct
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
            txtPrice = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCode = new TextBox();
            btnCancel = new Button();
            btnAccept = new Button();
            label2 = new Label();
            label1 = new Label();
            txtInsuranceCode = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(178, 145);
            txtPrice.Margin = new Padding(6, 7, 6, 7);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(248, 23);
            txtPrice.TabIndex = 35;
            txtPrice.Tag = "Price";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(178, 88);
            txtPhoneNumber.Margin = new Padding(6, 7, 6, 7);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 23);
            txtPhoneNumber.TabIndex = 34;
            txtPhoneNumber.Tag = "Description";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(178, 24);
            txtCode.Margin = new Padding(6, 7, 6, 7);
            txtCode.MaxLength = 4;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(248, 23);
            txtCode.TabIndex = 33;
            txtCode.Tag = "Code";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(380, 247);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 26);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "&Cancel";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(268, 247);
            btnAccept.Margin = new Padding(4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(102, 26);
            btnAccept.TabIndex = 36;
            btnAccept.Text = "&Accept";
            btnAccept.Click += btnAccept_Click;
            // 
            // label2
            // 
            label2.Location = new Point(-3, 66);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 65);
            label2.TabIndex = 39;
            label2.Text = "Phone Number:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(13, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 26);
            label1.TabIndex = 38;
            label1.Text = "Code:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtInsuranceCode
            // 
            txtInsuranceCode.Location = new Point(123, 24);
            txtInsuranceCode.Margin = new Padding(4);
            txtInsuranceCode.Name = "txtInsuranceCode";
            txtInsuranceCode.Size = new Size(125, 23);
            txtInsuranceCode.TabIndex = 43;
            txtInsuranceCode.Tag = "Description";
            // 
            // label3
            // 
            label3.Location = new Point(24, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 26);
            label3.TabIndex = 40;
            label3.Text = "Phone:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 336);
            Controls.Add(txtPrice);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCode);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAddModifyProduct";
            Text = " ";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPrice;
        private TextBox txtPhoneNumber;
        private TextBox txtCode;
        private Button btnCancel;
        private Button btnAccept;
        private Label label2;
        private Label label1;
        private TextBox txtInsuranceCode;
        private TextBox txtClientName;
        private TextBox txtClientPhone;
        private Label label3;
    }
}