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
            txtClientPhone = new TextBox();
            txtClientName = new TextBox();
            btnCancel = new Button();
            btnAccept = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtInsuranceCode = new TextBox();
            SuspendLayout();
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(125, 106);
            txtClientPhone.Margin = new Padding(4);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(123, 23);
            txtClientPhone.TabIndex = 35;
            txtClientPhone.Tag = "Price";
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(125, 63);
            txtClientName.Margin = new Padding(4);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(123, 23);
            txtClientName.TabIndex = 34;
            txtClientName.Tag = "Description";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(235, 183);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 26);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "&Cancel";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(123, 183);
            btnAccept.Margin = new Padding(4);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(102, 26);
            btnAccept.TabIndex = 36;
            btnAccept.Text = "&Accept";
            // 
            // label3
            // 
            label3.Location = new Point(37, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 26);
            label3.TabIndex = 40;
            label3.Text = "Phone:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(37, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 39;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(37, 21);
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
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 247);
            Controls.Add(txtInsuranceCode);
            Controls.Add(txtClientPhone);
            Controls.Add(txtClientName);
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

        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnAccept;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtInsuranceCode;
        private TextBox txtClientName;
        private TextBox txtClientPhone;
    }
}