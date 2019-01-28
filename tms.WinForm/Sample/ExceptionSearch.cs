using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tms.WinForm.Common;

namespace tms.WinForm.Sample
{
    public partial class ExceptionSearch : tms.WinForm.Common.BaseForm
    {
        public ExceptionSearch()
        {
            InitializeComponent();
            PopulateComboBox(this.Controls);

            dateEditEnd.DateTime = DateTime.Now;
            dateEditBegin.DateTime = DateTime.Now.AddDays(-10);

            AppendKeyDownNoXml(this.Controls);
        }

        private void btnExceptionSearch_Click(object sender, EventArgs e)
        {

            string[] param = new string[2];
            param[0] = "p_dateBegin:" + dateEditBegin.DateTime.ToShortDateString(); 
            param[1]= "p_dateEnd:" + dateEditEnd.DateTime.AddDays(1).ToShortDateString() ;

            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), 
                (comboExceptionLx.SelectedItem as ComboBoxItem4Dev).id,param, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            gridControl.DataSource = dt;
            gridView.PopulateColumns();
        }
    }
}
