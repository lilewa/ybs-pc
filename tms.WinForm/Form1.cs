using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tms.WinForm
{
    public partial class Form1 : Form
    {
        MainWebService.MainWebService service = new MainWebService.MainWebService();
        string errMsg;
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            service.ExecuteReturnInt(this.GetType().ToString(), "Test", new string[] { "p_p:" + DBNull.Value }, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            //service.ExecuteReturnInt(this.GetType().ToString(), "Test", new string[] { "p_p:" }, out errMsg);
            //if (!string.IsNullOrEmpty(errMsg))
            //{
            //    MessageBox.Show(errMsg);
            //    return;
            //}
        }
    }
}
