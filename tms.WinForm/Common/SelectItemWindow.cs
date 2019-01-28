using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace tms.WinForm.Common
{
    public partial class SelectItemWindow : DevExpress.XtraEditors.XtraForm
    {
        public Dictionary<string, string> dic = new Dictionary<string, string>();
        public SelectItemWindow(DataTable dt,string tip="选择")
        {
            InitializeComponent();

            lbTip.Text = tip;
            
            gridControl1.DataSource = dt;
       
            if (dt.Rows.Count > 0)
            {
                gridView1.SelectRow(0);
             
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length == 0)
                return;

            int handle=  gridView1.GetSelectedRows()[0];
             
            foreach ( GridColumn column in gridView1.Columns)
            {  
                 dic.Add(column.FieldName, gridView1.GetRowCellValue(handle, column).ToString());
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}