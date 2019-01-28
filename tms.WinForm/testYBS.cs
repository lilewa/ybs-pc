using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tms.WinForm
{
    public partial class testYBS : Form
    {
        MainWebService.MainWebServiceSoapClient service = new MainWebService.MainWebServiceSoapClient();
        string errMsg;
        public testYBS()
        {
            InitializeComponent();

            DataTable dt= service.ExecuteReturnTb(this.GetType().ToString(), "Test", null, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            gridControl1.DataSource = dt;

        }
    }
}
