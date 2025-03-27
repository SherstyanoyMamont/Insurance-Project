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
            txtQuantity = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtCode = new TextBox();
            btnCancel = new Button();
            btnAccept = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(176, 254);
            txtQuantity.Margin = new Padding(6, 7, 6, 7);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(40, 31);
            txtQuantity.TabIndex = 42;
            txtQuantity.Tag = "Quantity";
            // 
            // label4
            // 
            label4.Location = new Point(73, 249);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 43);
            label4.TabIndex = 41;
            label4.Text = "Quantity";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(178, 177);
            txtPrice.Margin = new Padding(6, 7, 6, 7);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(90, 31);
            txtPrice.TabIndex = 35;
            txtPrice.Tag = "Price";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 105);
            txtDescription.Margin = new Padding(6, 7, 6, 7);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(324, 31);
            txtDescription.TabIndex = 34;
            txtDescription.Tag = "Description";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(178, 44);
            txtCode.Margin = new Padding(6, 7, 6, 7);
            txtCode.MaxLength = 4;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(90, 31);
            txtCode.TabIndex = 33;
            txtCode.Tag = "Code";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(336, 305);
            btnCancel.Margin = new Padding(6, 7, 6, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 43);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "&Cancel";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(176, 305);
            btnAccept.Margin = new Padding(6, 7, 6, 7);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(146, 43);
            btnAccept.TabIndex = 36;
            btnAccept.Text = "&Accept";
            // 
            // label3
            // 
            label3.Location = new Point(53, 172);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 43);
            label3.TabIndex = 40;
            label3.Text = "Price:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(53, 99);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 43);
            label2.TabIndex = 39;
            label2.Text = "Description:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(53, 35);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 43);
            label1.TabIndex = 38;
            label1.Text = "Code:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmAddModifyProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 412);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtCode);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddModifyProduct";
            Text = "frmAddModifyProduct";
            Load += frmAddModifyProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtCode;
        private Button btnCancel;
        private Button btnAccept;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}