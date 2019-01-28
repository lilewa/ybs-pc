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
using System.Xml.Linq;
using System.Xml.XPath;
using DevExpress.XtraTab;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using tms.WinForm.Formatter;

namespace tms.WinForm.Sample
{
    public partial class TaskSearch : BaseForm
    {
         
        public TaskSearch(string pageName)
        {
            InitializeComponent(); 
            PopulateComboBox();
            dateEditSjEnd.DateTime = DateTime.Now;
            dateEditSJBegin.DateTime = DateTime.Now.AddDays(-10);

            LoadGhdw();
            LoadHqdy();
            if (pageName.Length>0)
            {
                foreach (XtraTabPage p in xtraTabControl1.TabPages)
                {
                    if (p.Text == pageName)
                    {
                        xtraTabControl1.SelectedTabPage = p;
                        break;
                    }
                }
            }

            foreach (XtraTabPage p in xtraTabControl1.TabPages)
            {
                AppendKeyDownNoXml(p.Controls);
            }

            GridColumn colDirection = gridViewJhmx.Columns["去向"];
         
            colDirection.DisplayFormat.FormatType = FormatType.Custom;
            colDirection.DisplayFormat.FormatString = "DIRECTION";
            colDirection.DisplayFormat.Format = new T_CHECKDETAIL();
        }

        private void LoadGhdw()
        {
            DataTable dt = service.ExecuteReturnTb("tms.Common.Common", "t_ghdw", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                
                return;
            }

            lookUpSjGhdw.Properties.DataSource = dt;
            lookUpSjGhdw.Properties.ValueMember = "编号";
            lookUpSjGhdw.Properties.DisplayMember = "名称";

            lookUpJHGhdw.Properties.DataSource = dt;
            lookUpJHGhdw.Properties.ValueMember = "编号";
            lookUpJHGhdw.Properties.DisplayMember = "名称";

           
        }

        private void LoadHqdy()
        {
           DataTable dt= service.ExecuteReturnTb("tms.Common.Common", "t_hqdy", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                
                return;
            }

            lookUpEditHq.Properties.DataSource = dt;
            lookUpEditHq.Properties.ValueMember = "编号";
            lookUpEditHq.Properties.DisplayMember = "名称";

            lookUpXjHq.Properties.DataSource = dt;
            lookUpXjHq.Properties.ValueMember = "编号";
            lookUpXjHq.Properties.DisplayMember = "名称";
           

        }

        private void PopulateComboBox()
        { 
            foreach (XtraTabPage p in xtraTabControl1.TabPages )
            { 
                base.PopulateComboBox(p.Controls); 
            }
        }

        private void btnSeachSj_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>();

            
            if (comboSjLx.SelectedIndex != 0)
            {
                param.Add("p_lx:"  +(comboSjLx.SelectedItem as ComboBoxItem4Dev).id);
            }
            
            param.Add("p_zt:" + (comboSjStatus.SelectedItem as ComboBoxItem4Dev).id);
            if (!string.IsNullOrWhiteSpace(lookUpEditHq.EditValue?.ToString())) 
            {
                param.Add("p_hqbh:" + lookUpEditHq.EditValue?.ToString());
            }

            if (!string.IsNullOrWhiteSpace(lookUpSjGhdw.EditValue?.ToString())) 
            {
                param.Add("p_ghdw:" + lookUpSjGhdw.EditValue?.ToString());
            }

            if(dateEditSJBegin.EditValue!=null) 
            param.Add("p_SjBegin:" + dateEditSJBegin.DateTime.ToShortDateString());

            if (dateEditSjEnd.EditValue != null)
                param.Add("p_SjEnd:" + dateEditSjEnd.DateTime.AddDays(1).ToShortDateString());

            

           DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchSj", param.ToArray(), out errMsg);
            
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            gridControl1.DataSource = dt;
        }

        private void btnLack_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
                return;

            if (gridView1.GetFocusedRowCellValue("ZT").ToString() == "1")
                MessageBox.Show("任务已经完成，不能做缺收处理");

            
            List<string> param = new List<string>();

             string flowid = gridView1.GetFocusedRowCellValue("FLOWID").ToString();
            param.Add("p_flowid:"+flowid);
            param.Add("p_czybh:"+UserInfo.userid);
            int rowhandle = gridView1.FocusedRowHandle;
            service.ExecuteReturnInt(this.GetType().ToString(), "PROC_SJLACKBOOK", param.ToArray(), out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);

                return;
            }
            else
            {
                MessageBox.Show("操作成功！");
                gridView1.DeleteRow(rowhandle);
            
            }
        }

        private void btnJHSearch_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>(); 
         
            if(comboJhZt.SelectedIndex!=0)
            { 
                param.Add("p_zt:" + (comboJhZt.SelectedItem as ComboBoxItem4Dev).id);
            }
            
            if (txtDjh.Text.Length>0)
            {
                param.Add("p_djh:" + txtDjh.Text);
            }

            if (!string.IsNullOrWhiteSpace(lookUpJHGhdw.EditValue?.ToString())) 
            {
                param.Add("p_ghdw:" + lookUpJHGhdw.EditValue?.ToString());
            }

            if (dateEditJHBgin.EditValue != null)
                param.Add("p_JhBegin:" + dateEditJHBgin.DateTime.ToShortDateString());

            if (dateEditJHEnd.EditValue != null)
                param.Add("p_JhEnd:" + dateEditJHEnd.DateTime.AddDays(1).ToShortDateString());



            DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchJH", param.ToArray(), out errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            gridControlJH.DataSource = dt;
        }

       
        private void gridViewJh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewJh.RowCount == 0)
                return;

            string djh = gridViewJh.GetFocusedRowCellValue("单据号").ToString();

            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchJHMx", new string[] { "p_djh:" + djh }, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            } 
            gridControlJHMx.DataSource = dt;

        }

        private void btnXjSearch_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>();

            if (comboXjZt.SelectedIndex != 0)
            {
                param.Add("p_zt:" + (comboXjZt.SelectedItem as ComboBoxItem4Dev).id);
            }

            if (!string.IsNullOrWhiteSpace(lookUpXjHq.EditValue?.ToString())) 
            {
                param.Add("p_hq:" + lookUpXjHq.EditValue?.ToString());
            }
             
     

            if (dateEditXjBegin.EditValue != null)
                param.Add("p_XjBegin:" + dateEditXjBegin.DateTime.ToShortDateString());

            if (dateEditXjEnd.EditValue != null)
                param.Add("p_XjEnd:" + dateEditXjEnd.DateTime.AddDays(1).ToShortDateString());



            DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchXj", param.ToArray(), out errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            gridControlXj.DataSource = dt;
        }

        private void gridViewXj_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewXj.RowCount == 0)
                return;
            string flowid = gridViewXj.GetFocusedRowCellValue("任务号").ToString();

            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchXjMx", new string[] { "p_flowid:" + flowid }, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            gridControlXjMx.DataSource = dt;
        }

       
    }
}