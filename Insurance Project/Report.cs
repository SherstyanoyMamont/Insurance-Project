using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Insurance_Project
{
    //2480 x 3508  // A4
    //1240 x 1754  // half A4
    public partial class Report : Form
    {
        private InsuranceCatalog Сatalog;
        public Report(InsuranceCatalog catalog)
        {
            InitializeComponent();
            Сatalog = catalog;

            this.Shown += Report_Shown;
        }

        private void Report_Shown(object sender, EventArgs e)
        {
            int catalogCount = Сatalog.ListInsurance.Count;

            if (catalogCount == 0)
            {
                MessageBox.Show("Нет данных для отображения!");
                return;
            }

            var lastInsurance = Сatalog.ListInsurance[catalogCount - 1];

            l_DocNumber.Text = lastInsurance.id.ToString();
            l_Vehicle.Text = lastInsurance.Client.Cars[0].Brand + " " + lastInsurance.Client.Cars[0].Model;
            l_StartDate.Text = lastInsurance.Client.DateTimeNow.ToShortDateString();
            l_ClientName.Text = lastInsurance.Client.FirstName + " " + lastInsurance.Client.LastName;
            l_ClientPhone.Text = lastInsurance.Client.PhoneNumber;
            l_FinalPrice.Text = $"{lastInsurance.FinalPrice} €";
        }

        public Bitmap PanelToBitmap(Panel RootPanel)
        {
            var sz = RootPanel.Size;

            Bitmap panelImage = new Bitmap(sz.Width, sz.Height);
            RootPanel.DrawToBitmap(panelImage, new Rectangle(0, 0, sz.Width, sz.Height));

            return panelImage;

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            Bitmap pageImage = PanelToBitmap(certificatePanel);
            pageImage.Save("test.jpg");


            PrintDocument pd = new PrintDocument();
            var pgs = pd.DefaultPageSettings;
            pgs.PaperSize = new PaperSize("Custom Size", certificatePanel.Width, certificatePanel.Height);
            pd.DefaultPageSettings = pgs;

            pd.PrintPage += delegate (object o, PrintPageEventArgs e)
            {
                e.Graphics.CompositingMode = (System.Drawing.Drawing2D.CompositingMode)CompositingMode.SourceOver;
                e.Graphics.CompositingQuality = (System.Drawing.Drawing2D.CompositingQuality)CompositingQuality.HighQuality;
                e.Graphics.DrawImage(pageImage, 0, 0, e.PageBounds.Width, e.PageBounds.Height);
            };

            pd.Print();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }

    public enum CompositingMode
    {
        SourceOver = 0,
        SourceCopy = 1
    }
    public enum CompositingQuality
    {
        Invalid = -1,
        Default = 0,
        HighSpeed = 1,
        HighQuality = 2,
        GammaCorrected = 3,
        AssumeLinear = 4
    }
}
