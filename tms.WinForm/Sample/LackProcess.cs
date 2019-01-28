using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using System.Xml.XPath;
using tms.WinForm.Common;

namespace tms.WinForm.Sample
{
    public partial class LackProcess : BaseForm
    {
       
    
        
        public LackProcess()
        {
            InitializeComponent(); 
            gridView1.BestFitColumns(); 
            PopulateComboBox(this.Controls);
           

            DataTable dt = service.ExecuteReturnTb("tms.Common.Common", "t_user", null, out selectSql, out errMsg); 
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
          
            lookUpEditUser.Properties.DataSource = dt; 
            lookUpEditUser.Properties.ValueMember = "编号";
            lookUpEditUser.Properties.DisplayMember = "名称";

            this.AppendKeyDown(this.Controls);

        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>();
            if (comboLackLx.SelectedIndex !=0)
            {
                param.Add("p_lx:" + (comboLackLx.SelectedItem as ComboBoxItem4Dev).id); 
            }
            if (comboPrint.SelectedIndex != 0)
            {
                param.Add("p_print:" + (comboPrint.SelectedItem as ComboBoxItem4Dev).id);
            }
            if (comboConfirm.SelectedIndex != 0)
            {
                param.Add("p_confirm:" + (comboConfirm.SelectedItem as ComboBoxItem4Dev).id);
            }
            if (dateEditBegin.EditValue != null)
            { 
                param.Add("p_begin:" + dateEditBegin.DateTime.ToShortDateString());
            }
            if (dateEditEnd.EditValue!=null)
            {
                param.Add("p_end:" + dateEditEnd.DateTime.AddDays(1).ToShortDateString());
            }
            if (txtDjh.Text.Trim().Length > 0)
            {
                param.Add("p_djh:%" + txtDjh.Text+"%");
            }

            if (!string.IsNullOrWhiteSpace(lookUpEditUser.EditValue?.ToString())) 
            {
                param.Add("p_czybh:" + lookUpEditUser.EditValue?.ToString());
            }
            Query(param.ToArray());
        }

        private void Query(string[] param)
        {

            DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchLack", param, out errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            gridControl1.DataSource = dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
                return;
            gridView1.Print();
            List<string[]> param = new List<string[]>();
            foreach (int rowhandle in gridView1.GetSelectedRows())
            {
                if (gridView1.GetRowCellValue(rowhandle, "打印").ToString() == "已打印")
                    continue;
                string[] singleParam = new string[2];
                singleParam[0] = "p_tbname:" + gridView1.GetRowCellValue(rowhandle, "SOURCETABLE").ToString();
                singleParam[1] = "p_flowid:" + gridView1.GetRowCellValue(rowhandle, "SOURCEID").ToString();
                param.Add(singleParam);
            }
            if (param.Count == 0)
                return;
            string errMsg = service.ExecuteTrans(this.GetType().ToString(), "UpdatePrintFlag", param.ToArray());
            if (!string.IsNullOrWhiteSpace(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            btnSearch_Click(null, null);
        }

    }
}