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
using tms.WinForm.Common;

namespace tms.WinForm.Sample
{
    public partial class SampleBarCodePrint : BaseForm
    {
       
        Bitmap bitmap;
        PrintingSystem printingSystem = new PrintingSystem();
        Link link; 
        string code;
        string dj;
        public SampleBarCodePrint()
        {
            InitializeComponent();
            printingSystem = new PrintingSystem();
            link = new Link(); 
            printingSystem.Links.Add(link);
            bitmap = new Bitmap(barCodeControl1.Width, barCodeControl1.Height);
            link.CreateDetailArea += Link_CreateDetailArea;
            
          
        }

        private void txtIsbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtIsbn.Text))
            {
                DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchBookPrint", new string[] { "p_isbn:" + txtIsbn.Text }, out selectSql, out errMsg);
                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg);
                    return;

                } 
                gridControl1.DataSource = dt;
            }
        }

        private void Link_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            int y = 0;
            BrickGraphics brickGraphics = e.Graph;
            barCodeControl1.Text = "201801310001";
            barCodeControl1.DrawToBitmap(bitmap, barCodeControl1.ClientRectangle);
            brickGraphics.DrawImage(bitmap, barCodeControl1.ClientRectangle , BorderSide.None,Color.Transparent);

            y += barCodeControl1.Height;
           TextBrick textBrick =  brickGraphics.DrawString(barCodeControl1.Text, Color.Black, new RectangleF(0, y, 130, 15), BorderSide.None);
           textBrick.StringFormat = textBrick.StringFormat.ChangeAlignment(StringAlignment.Center);

            y += brickGraphics.Font.Height;
            brickGraphics.DrawString("定价:00", Color.Black, new RectangleF(0, y, 130, 15), BorderSide.None);

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            link.Print("");
        }
    }
}