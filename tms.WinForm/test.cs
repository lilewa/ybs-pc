using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System.Drawing.Printing;
using tms.WinForm.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Xml.Linq;
using System.Xml.XPath;

namespace tms.WinForm
{
    public partial class test : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        XElement formXml;
        Dictionary<string, int> tabindex = new Dictionary<string, int>();
        public test()
        {
            InitializeComponent();
            XElement doc = XElement.Load(Application.StartupPath + "\\Resources\\items.xml");
            formXml = doc.XPathSelectElement("/" + this.GetType().Namespace + "/" + this.GetType().Name);
            PopulateComboBox();
            comboBoxEdit1.Properties.Items.Add("123");
            comboBoxEdit1.Properties.Items.Add("123");//, "456", "789"

            comboBoxEdit1.Properties.Items.Add("456");

            comboBoxEdit1.Properties.Items.Add("789");



            //comboBoxEdit1.Properties.Items = new string[] { "", "", "" };

            //DevExpress.XtraEditors.Controls.ComboBoxItemCollection coll = comboBoxEdit1.Properties.Items;
            //coll.Add("123");//, "456", "789"

            //coll.Add("456");

            //coll.Add("789");


            dt.Columns.Add("Name");
            dt.Columns.Add("Value");
            dt.Rows.Add("name1", "1");
            dt.Rows.Add("name2", "2");
            checkedComboBoxEdit1.Properties.DataSource = dt;
            checkedComboBoxEdit1.Properties.DisplayMember = "Name";
            checkedComboBoxEdit1.Properties.DisplayMember = "Value";
             checkedComboBoxEdit1.SetEditValue("1,2");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PrintingSystem printingSystem = new PrintingSystem();

            // Create a link and add it to the printing system's collection of links.
            Link link = new Link();
            printingSystem.Links.Add(link);

            // Subscribe to the events to customize the detail and marginal page header sections of a document.
            link.CreateDetailArea += Link_CreateDetailArea;
            link.CreateMarginalHeaderArea += Link_CreateMarginalHeaderArea;

            // Create a document and show it in the document preview.
            link.ShowPreview();
        }

        private void Link_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            // Specify required settings for the brick graphics.
            BrickGraphics brickGraphics = e.Graph;
            BrickStringFormat format = new BrickStringFormat(StringAlignment.Near, StringAlignment.Center);
            brickGraphics.StringFormat = format;
            brickGraphics.BorderColor = SystemColors.ControlDark;

            // Declare bricks.
            ImageBrick imageBrick;
            TextBrick textBrick;
            CheckBoxBrick checkBrick;
            Brick brick;

            // Declare text strings.
            string[] rows = { "Species No:", "Length (cm):", "Category:", "Common Name:", "Species Name:" },
                desc = { "90070", "30", "Angelfish", "Blue Angelfish", "Pomacanthus nauarchus" };

            string note = "Habitat is around boulders, caves, coral ledges and crevices in shallow waters. " +
                "Swims alone or in groups. Its color changes dramatically from juvenile to adult. The mature" +
                " adult fish can startle divers by producing a powerful drumming or thumping sound intended " +
                "to warn off predators. Edibility is good. Range is the entire Indo-Pacific region.";

            // Define the image to display.
            // Image img = Image.FromFile(@"..\..\angelfish.png");
            Image img = new Bitmap(1,1) ;//= Properties.Resources.excel32;
            // Start creation of a non-separable group of bricks.
            brickGraphics.BeginUnionRect();

            // Display the image.
            imageBrick = brickGraphics.DrawImage(img, new RectangleF(0, 0, 250, 150), BorderSide.All, Color.Transparent);
            imageBrick.Hint = "Blue Angelfish";
            textBrick = brickGraphics.DrawString("1", Color.Blue, new RectangleF(5, 5, 30, 15), BorderSide.All);
            textBrick.StringFormat = textBrick.StringFormat.ChangeAlignment(StringAlignment.Center);

            // Display a checkbox.
            checkBrick = brickGraphics.DrawCheckBox(new RectangleF(5, 145, 10, 10), BorderSide.All, Color.White, true);

            // Create a set of bricks, representing a column with species names.
            brickGraphics.BackColor = Color.FromArgb(153, 204, 255);
            brickGraphics.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
            for (int i = 0; i < 5; i++)
            {

                // Draw a VisualBrick representing borders for the following TextBrick.
                brick = brickGraphics.DrawRect(new RectangleF(256, 32 * i, 120, 32), BorderSide.All,
                    Color.Transparent, Color.Empty);

                // Draw the TextBrick with species names.
                textBrick = brickGraphics.DrawString(rows[i], Color.Black, new RectangleF(258, 32 * i + 2, 116, 28),
                    BorderSide.All);
            }

            // Create a set of bricks representing a column with the species characteristics.
            brickGraphics.Font = new Font("Arial", 11, FontStyle.Bold);
            brickGraphics.BackColor = Color.White;
            for (int i = 0; i < 5; i++)
            {
                brick = brickGraphics.DrawRect(new RectangleF(376, 32 * i, brickGraphics.ClientPageSize.Width - 376, 32),
                    BorderSide.All,
                Color.Transparent, brickGraphics.BorderColor);

                // Draw a TextBrick with species characteristics.
                textBrick = brickGraphics.DrawString(desc[i], Color.Indigo, new RectangleF(378, 32 * i + 2,
                    brickGraphics.ClientPageSize.Width - 380, 28),
                BorderSide.All);

                // For text bricks containing numeric data, set text alignment to Far.
                if (i < 2) textBrick.StringFormat =
                    textBrick.StringFormat.ChangeAlignment(StringAlignment.Far);
            }

            // Drawing the TextBrick with notes.
            brickGraphics.Font = new Font("Arial", 8);
            brickGraphics.BackColor = Color.Cornsilk;
            textBrick = brickGraphics.DrawString(note, Color.Black, new RectangleF(new PointF(0, 160), new
                SizeF(brickGraphics.ClientPageSize.Width, 40)), BorderSide.All);
            textBrick.StringFormat = textBrick.StringFormat.ChangeLineAlignment(StringAlignment.Near);
            textBrick.Hint = note;

            // Finish the creation of a non-separable group of bricks.
            brickGraphics.EndUnionRect();
        }

        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            // Specify required settings for the brick graphics.
            BrickGraphics brickGraphics = e.Graph;
            brickGraphics.BackColor = Color.White;
            brickGraphics.Font = new Font("Arial", 8);

            // Declare bricks.
            PageInfoBrick pageInfoBrick;
            PageImageBrick pageImageBrick;

            // Declare text strings.
            string devexpress = "XtraPrintingSystem by Developer Express Inc.";

            // Define the image to display.
            //Image pageImage = Image.FromFile(@"..\..\logo.png");
            Image pageImage=new Bitmap(1, 1);//= Properties.Resources.excel32;

            // Display the DevExpress text string.
            SizeF size = brickGraphics.MeasureString(devexpress);
            pageInfoBrick = brickGraphics.DrawPageInfo(PageInfo.None, devexpress, Color.Black, new RectangleF(new
                PointF(/*343 -*/ 100-(size.Width - pageImage.Width) / 2, pageImage.Height + 3), size), BorderSide.None);
            pageInfoBrick.Alignment = BrickAlignment.Center;

            // Display the PageImageBrick containing the DevExpress logo.
            pageImageBrick = brickGraphics.DrawPageImage(pageImage, new RectangleF(1, 0,
                pageImage.Width, pageImage.Height), BorderSide.None, Color.Transparent);
            //pageImageBrick.Alignment = BrickAlignment.Center;

            // Set the rectangle for a page info brick. 
            RectangleF r = RectangleF.Empty;
            r.Height = 20;

            // Display the PageInfoBrick containing date-time information. Date-time information is displayed
            // in the left part of the MarginalHeader section using the FullDateTimePattern.
            pageInfoBrick = brickGraphics.DrawPageInfo(PageInfo.DateTime, "{0:F}", Color.Black, r, BorderSide.None);
            pageInfoBrick.Alignment = BrickAlignment.Near;

            // Display the PageInfoBrick containing the page number among total pages. The page number
            // is displayed in the right part of the MarginalHeader section.
            pageInfoBrick = brickGraphics.DrawPageInfo(PageInfo.NumberOfTotal, "Page {0} of {1}", Color.Black, r,
                 BorderSide.None);
            pageInfoBrick.Alignment = BrickAlignment.Far;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //ListViewLink lwLink = new ListViewLink();
            //lwLink.ListView = listView1;
            //PrintingSystem printingSystem1 = new PrintingSystem();
            //printingSystem1.Links.Add(lwLink);
            ////lwLink.ShowPreviewDialog();
            

            //PrintDocument prtdoc = new PrintDocument();
            //string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;//获取默认的打印机名
            ////"Microsoft XPS Document Writer"
            //lwLink.Print("");
        }

        private void test_Load(object sender, EventArgs e)
        {
            textEdit3.Focus();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
           string s=   Guid.NewGuid().ToString();
            MessageBox.Show(s);
        }

        private void comboBoxEdit1_TextChanged(object sender, EventArgs e)
        {
            string[] items = comboBoxEdit1.Properties.Items.Cast<string>().Where(item => item.Contains(comboBoxEdit1.Text)).ToArray();
            comboBoxEdit1.Properties.Items.Clear();
            comboBoxEdit1.Properties.Items.AddRange(items);
            if(items.Length>0)
            comboBoxEdit1.ShowPopup();


        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //string connectionstring = ConfigurationManager.ConnectionStrings["Oracle"].ToString();
            // using (OracleConnection conn = new OracleConnection(connectionstring))
            // {
            //     conn.Open();
            //     using (OracleCommand cmd = conn.CreateCommand())
            //     {
            //         cmd.CommandText = "select * from t_ghdw";
            //         // cmd.Parameters.AddRange(parameters);
            //         OracleDataAdapter da = new OracleDataAdapter(cmd);
            //        // DataTable dt = new DataTable();
            //         da.Fill(dt);
            //     }
            // }

           MessageBox.Show( checkedComboBoxEdit1.EditValue.ToString());
        }

        private void PopulateComboBox()
        {
            XElement xel = formXml.Element("TabIndex");
            if (xel == null)
                return;

            tabindex = xel.Elements().Select((el, index) => new { Name = el.Name, Index = index }).ToDictionary(el => el.Name.ToString(), el => el.Index);
            foreach (Control ctl in this.Controls)
            {
                if (tabindex.ContainsKey(ctl.Name))
                {
                    ctl.TabIndex = tabindex[ctl.Name];
                }
                else
                {
                    ctl.TabIndex = 99;
                }
                ctl.Tag = false;
                ctl.KeyDown += Enter_KeyDown;
            }
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            bool cancel = (bool)((Control)sender).Tag;

            if (!cancel)
                SendKeys.Send("{Tab}");
        }

        private void textEdit4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textEdit4.Text == "1")
                {
                    textEdit4.Tag = true;
                }
                else
                {
                    textEdit4.Tag = false;
                }
            }
        }

        private void test_MouseDown(object sender, MouseEventArgs e)
        {
            // label1.Text = (int)label1.Text;

            
        }

        private void test_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void test_MouseCaptureChanged(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }


      
    }
}