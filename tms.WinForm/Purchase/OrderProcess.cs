using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using tms.WinForm.Common;

namespace tms.WinForm.Purchase
{
    public partial class OrderProcess : BaseForm
    {
        
        public OrderProcess()
        {
            InitializeComponent();
            
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            // string orderid=   gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["订单号"]).ToString();

            // e.ChildList = new List<Object> { new { ISBN = "123", SM = "312" } };
            //e.ChildList = new DataTable().AsDataView();

            
          DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "GetOrderDetail", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            e.ChildList = dt.AsDataView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "GetOrder", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            gridControl1.DataSource = dt;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
           e.RelationCount = 1;
        }
        
        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;

        }

        //string err = service.ExecuteTrans(this.GetType().ToString(), "simpleButton1_Click",
        //     new string[][] { new string[] { "p_flowid:3" }, new string[] { "p_flowid:1" } });

        
    }
}