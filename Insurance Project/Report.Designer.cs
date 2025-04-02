using System.Windows.Forms.PropertyGridInternal;

namespace Insurance_Project
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Report));

            this.BtnPrint = new System.Windows.Forms.Button();
            this.scrollContainerPanel = new System.Windows.Forms.Panel();
            this.certificatePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.l_FinalPrice = new System.Windows.Forms.Label();
            this.l_ClientPhone = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_Vehicle = new System.Windows.Forms.Label();
            this.l_DocNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.l_ClientName = new System.Windows.Forms.Label();
            this.l_StartDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();

            // ---------- Форма Report -----------
            // Цвет фона – тот же, что и у главной формы
            // Можно задать Font = new Font("Segoe UI", 10F), как в главной
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 245);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Размеры по умолчанию
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            // Если хотите, чтобы форма минимально растягивалась под содержимое, можно включить AutoSize,
            // но обычно достаточно управлять в Report_Load
            // this.AutoSize = true;
            // this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.ClientSize = new System.Drawing.Size(910, 1194);
            this.Controls.Add(this.scrollContainerPanel);
            this.Controls.Add(this.BtnPrint);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 240);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load2);

            //
            // BtnPrint
            //
            this.BtnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.BtnPrint.Location = new System.Drawing.Point(8, 8);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(112, 34);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            // Настраиваем стиль кнопки
            this.BtnPrint.FlatStyle = FlatStyle.Flat;
            this.BtnPrint.BackColor = Color.WhiteSmoke;
            this.BtnPrint.ForeColor = Color.Black;
            this.BtnPrint.FlatAppearance.BorderColor = Color.DarkGray;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);

            //
            // scrollContainerPanel
            //
            this.scrollContainerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.scrollContainerPanel.AutoScroll = true;
            this.scrollContainerPanel.BackColor = System.Drawing.Color.FromArgb(230, 230, 235); // чуть темнее, чем форма
            this.scrollContainerPanel.Location = new System.Drawing.Point(14, 48);
            this.scrollContainerPanel.Name = "scrollContainerPanel";
            this.scrollContainerPanel.Padding = new System.Windows.Forms.Padding(5, 15, 5, 25);
            this.scrollContainerPanel.Size = new System.Drawing.Size(884, 1134);
            this.scrollContainerPanel.TabIndex = 1;

            //
            // certificatePanel
            //
            // Сам «лист» договора делаем белым, как чистый лист
            this.certificatePanel.BackColor = System.Drawing.Color.White;
            this.certificatePanel.Controls.Add(this.panel3);
            this.certificatePanel.Controls.Add(this.panel2);
            this.certificatePanel.Location = new System.Drawing.Point(8, 18);
            this.certificatePanel.Name = "certificatePanel";
            this.certificatePanel.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.certificatePanel.Size = new System.Drawing.Size(850, 1100);
            this.certificatePanel.TabIndex = 0;

            //
            // panel3
            //
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.l_FinalPrice);
            this.panel3.Controls.Add(this.l_ClientPhone);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.l_Vehicle);
            this.panel3.Controls.Add(this.l_DocNumber);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.l_ClientName);
            this.panel3.Controls.Add(this.l_StartDate);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(20, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 924);
            this.panel3.TabIndex = 24;

            // Все label’ы делаем с чёрным (или тёмно-серым) ForeColor
            // label17
            this.label17.ForeColor = Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 816);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(798, 95);
            this.label17.TabIndex = 28;
            this.label17.Text = resources.GetString("label17.Text");

            // label13
            this.label13.ForeColor = Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 563);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(771, 110);
            this.label13.TabIndex = 27;
            this.label13.Text = resources.GetString("label13.Text");

            // label16
            this.label16.ForeColor = Color.Black;
            this.label16.Location = new System.Drawing.Point(16, 393);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(615, 170);
            this.label16.TabIndex = 26;
            this.label16.Text = resources.GetString("label16.Text");

            // label12
            this.label12.ForeColor = Color.Black;
            this.label12.Location = new System.Drawing.Point(16, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(771, 97);
            this.label12.TabIndex = 25;
            this.label12.Text = resources.GetString("label12.Text");

            // l_FinalPrice
            this.l_FinalPrice.AutoSize = true;
            this.l_FinalPrice.ForeColor = Color.Black;
            this.l_FinalPrice.Location = new System.Drawing.Point(357, 156);
            this.l_FinalPrice.Name = "l_FinalPrice";
            this.l_FinalPrice.Size = new System.Drawing.Size(61, 23);
            this.l_FinalPrice.TabIndex = 24;
            this.l_FinalPrice.Text = "<Price>";

            // l_ClientPhone
            this.l_ClientPhone.AutoSize = true;
            this.l_ClientPhone.ForeColor = Color.Black;
            this.l_ClientPhone.Location = new System.Drawing.Point(357, 130);
            this.l_ClientPhone.Name = "l_ClientPhone";
            this.l_ClientPhone.Size = new System.Drawing.Size(70, 23);
            this.l_ClientPhone.TabIndex = 23;
            this.l_ClientPhone.Text = "<Phone>";

            // pictureBox1
            this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
            this.pictureBox1.Location = new System.Drawing.Point(398, 733);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 50);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;

            // label4
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "1.   Document Number :";

            // label14
            this.label14.AutoSize = true;
            this.label14.ForeColor = Color.Black;
            this.label14.Location = new System.Drawing.Point(16, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "2.   Description of Vehicle :";

            // label15
            this.label15.AutoSize = true;
            this.label15.ForeColor = Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "3.   Name of Policyholder :";

            // label1
            this.label1.ForeColor = Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "4.   Effective Date of Commencement:";

            // l_Vehicle
            this.l_Vehicle.AutoSize = true;
            this.l_Vehicle.ForeColor = Color.Black;
            this.l_Vehicle.Location = new System.Drawing.Point(357, 49);
            this.l_Vehicle.Name = "l_Vehicle";
            this.l_Vehicle.Size = new System.Drawing.Size(80, 23);
            this.l_Vehicle.TabIndex = 1;
            this.l_Vehicle.Text = "<Vehicle>";

            // l_DocNumber
            this.l_DocNumber.AutoSize = true;
            this.l_DocNumber.ForeColor = Color.Black;
            this.l_DocNumber.Location = new System.Drawing.Point(357, 22);
            this.l_DocNumber.Name = "l_DocNumber";
            this.l_DocNumber.Size = new System.Drawing.Size(123, 23);
            this.l_DocNumber.TabIndex = 1;
            this.l_DocNumber.Text = "<DOC Number>";

            // label11
            this.label11.ForeColor = Color.Black;
            this.label11.Location = new System.Drawing.Point(2, 816);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(798, 95);
            this.label11.TabIndex = 21;

            // label10
            this.label10.ForeColor = Color.Black;
            this.label10.Location = new System.Drawing.Point(398, 793);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = " Underwriter";

            // l_ClientName
            this.l_ClientName.AutoSize = true;
            this.l_ClientName.ForeColor = Color.Black;
            this.l_ClientName.Location = new System.Drawing.Point(357, 77);
            this.l_ClientName.Name = "l_ClientName";
            this.l_ClientName.Size = new System.Drawing.Size(112, 23);
            this.l_ClientName.TabIndex = 1;
            this.l_ClientName.Text = "<ClientName>";

            // l_StartDate
            this.l_StartDate.AutoSize = true;
            this.l_StartDate.ForeColor = Color.Black;
            this.l_StartDate.Location = new System.Drawing.Point(357, 104);
            this.l_StartDate.Name = "l_StartDate";
            this.l_StartDate.Size = new System.Drawing.Size(97, 23);
            this.l_StartDate.TabIndex = 1;
            this.l_StartDate.Text = "<StartDate>";

            // label9
            this.label9.ForeColor = Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 693);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 90);
            this.label9.TabIndex = 21;
            this.label9.Text = "      Munster Motor Insurance\n      Thomond Parc House\n      Limerick";

            // label3
            this.label3.ForeColor = Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 60);
            this.label3.TabIndex = 16;
            this.label3.Text = "5.   Phone Number\n     Total Price:";

            // label8
            this.label8.ForeColor = Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(771, 110);
            this.label8.TabIndex = 20;

            // label5
            this.label5.ForeColor = Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(771, 108);
            this.label5.TabIndex = 18;

            // label7
            this.label7.ForeColor = Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(615, 134);
            this.label7.TabIndex = 19;

            // label6
            this.label6.ForeColor = Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(771, 81);
            this.label6.TabIndex = 18;
            this.label6.Text = "7.   Limitations ...";
            this.label6.Click += new System.EventHandler(this.label6_Click);

            //
            // panel2 (верхняя шапка, с надписью и логотипом)
            //
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 131);
            this.panel2.TabIndex = 23;

            //
            // label2 (заголовок)
            //
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.label2.ForeColor = Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Certificate Motor Insurance";

            //
            // Добавляем всё на форму
            //
            this.scrollContainerPanel.Controls.Add(this.certificatePanel);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.certificatePanel.ResumeLayout(false);
            this.scrollContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void Report_Load2(object sender, EventArgs e)
        {
            // Мы хотим сделать так, чтобы форма была ровно по размеру certificatePanel,
            // но не выходила за границы экрана.
            // Учитываем, что scrollContainerPanel отнимает часть места, поэтому
            // посчитаем разницу между текущим размером формы и реальной областью scrollContainerPanel.

            // Дополнительное пространство, которое занимает рамка, заголовок формы и т.п.
            int extraWidth = this.Width - this.scrollContainerPanel.Width;
            int extraHeight = this.Height - this.scrollContainerPanel.Height;

            // Желаемая ширина и высота, чтобы лист поместился «точь-в-точь»
            int desiredWidth = this.certificatePanel.Width + extraWidth + 20;  // + небольшой отступ
            int desiredHeight = this.certificatePanel.Height + extraHeight + 20;

            // Теперь убедимся, что не выходим за границы экрана.
            var workingArea = Screen.GetWorkingArea(this);
            int finalWidth = Math.Min(desiredWidth, workingArea.Width);
            int finalHeight = Math.Min(desiredHeight, workingArea.Height);

            // Устанавливаем новый размер
            this.Size = new Size(finalWidth, finalHeight);

            // Если документ всё равно больше доступной высоты,
            // то в scrollContainerPanel уже включён AutoScroll = true (скролл работает).
        }

        #endregion
        private Button BtnPrint;
        private Panel certificatePanel;
        private Label l_DocNumber;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private Panel scrollContainerPanel;
        private Label l_Vehicle;
        private Label l_StartDate;
        private Label l_ClientName;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label label14;
        private Label label15;
        private Label l_FinalPrice;
        private Label l_ClientPhone;
        private Label label13;
        private Label label16;
        private Label label12;
        private Label label17;
    }
}