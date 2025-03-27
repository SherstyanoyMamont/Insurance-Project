namespace Insurance_Project
{
    partial class SearchForm
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
            listBox1 = new ListBox();
            buttonFiend = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dgvProducts = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(14, 642);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1452, 429);
            listBox1.TabIndex = 0;
            // 
            // buttonFiend
            // 
            buttonFiend.Location = new Point(1213, 539);
            buttonFiend.Margin = new Padding(2);
            buttonFiend.Name = "buttonFiend";
            buttonFiend.Size = new Size(112, 34);
            buttonFiend.TabIndex = 1;
            buttonFiend.Text = "Fiend";
            buttonFiend.UseVisualStyleBackColor = true;
            buttonFiend.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 539);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(834, 31);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 510);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 3;
            label1.Text = "Input full name:";
            // 
            // dgvProducts
            // 
            dgvProducts.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(14, 14);
            dgvProducts.Margin = new Padding(2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1311, 481);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1080, 539);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "&Add Product";
            btnAdd.Click += btnAdd_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 602);
            Controls.Add(btnAdd);
            Controls.Add(dgvProducts);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonFiend);
            Controls.Add(listBox1);
            Margin = new Padding(2);
            Name = "SearchForm";
            Text = "SearchForm";
            Load += SearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonFiend;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dgvProducts;
        private Button btnAdd;
    }
}