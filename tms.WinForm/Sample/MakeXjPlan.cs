using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tms.WinForm.Common;

namespace tms.WinForm.Sample
{
    public partial class MakeXjPlan : BaseForm
    {
        KeyMouseMessageFilter filter;
        DataTable t_issueXjplan;
        string insert_t_issueXjplan;
        public MakeXjPlan()
        {
            InitializeComponent();
            filter = new KeyMouseMessageFilter();
           
            filter.KeyorMousePut += FlyoutPanelToggle;
            SetFl();
            SetGhdw();
            SetHqqy();

            AppendKeyDown(flyoutPanel1.Controls);
        }

        private void MakeXjPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.RemoveMessageFilter(filter);
        }

        private void FlyoutPanelToggle()
        {
            if (flyoutPanel1.IsPopupOpen)
            {
                flyoutPanel1.HidePopup();
            }
            else
            {
                flyoutPanel1.ShowPopup();
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>();
            if (!string.IsNullOrWhiteSpace(lookUpEditGhdw.EditValue?.ToString())) 
            {
                param.Add("p_ghdw:" + lookUpEditGhdw.EditValue?.ToString());
            }

            if (!string.IsNullOrWhiteSpace(lookUpEditHq.EditValue?.ToString())) 
            {
                param.Add("p_hq:" + lookUpEditHq.EditValue?.ToString());
            }

            if (!string.IsNullOrWhiteSpace(lookUpEditYbsfl.EditValue?.ToString())) 
            {
                param.Add("p_fl:" + lookUpEditYbsfl.EditValue?.ToString());
            }

            if (!string.IsNullOrWhiteSpace(txtSm.Text))
            {
                param.Add("p_sm:%" + txtSm.Text + "%");
            }
            if (!string.IsNullOrWhiteSpace(txtIsbn.Text))
            {
                param.Add("p_isbn:" + txtIsbn.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtDjBegin.Text))
            {
                param.Add("p_djBegin:" + txtDjBegin.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtDjEnd.Text))
            {
                param.Add("p_djEnd:" + txtDjEnd.Text);
            }
            if (dateEditShBegin.EditValue != null)
            {
                param.Add("p_yyyyBegin:" + dateEditShBegin.DateTime.Year.ToString());
                param.Add("p_mmBegin:" + dateEditShBegin.DateTime.Month.ToString());
            }

            if (dateEditShEnd.EditValue != null)
            {
                param.Add("p_yyyyEnd:" + dateEditShEnd.DateTime.Year.ToString());
                param.Add("p_mmEnd:" + dateEditShEnd.DateTime.Month.ToString());
            }

            if (dateEditCbnyBegin.EditValue != null)
            {
                param.Add("p_cbnyBegin:" + dateEditCbnyBegin.DateTime.ToString("yyyy.MM"));
            }

            if (dateEditCbnyEnd.EditValue != null)
            {
                param.Add("p_cbnyEnd:" + dateEditCbnyEnd.DateTime.ToString("yyyy.MM"));

            }

            //if (param.Count == 0)
            //{
            //    MessageBox.Show("请输入查询条件");
            //    return;
            //}

            DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchLtkf", param.ToArray(), out errMsg);
            gridControl1.DataSource = dt;

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            gridView1.SelectAll();
            flyoutPanel1.HidePopup();
        }

        private void btnTaskSearch_Click(object sender, EventArgs e)
        {
            MainFrame form = (this.Parent.Parent as MainFrame);
            form.ShowForm(typeof(TaskSearch), "下架任务");
        }

        private void SetFl()
        {
            DataTable dt = service.ExecuteReturnTb("tms.Common.Common", "ybsfl_t_fl", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            lookUpEditYbsfl.Properties.DisplayMember = "名称";
            lookUpEditYbsfl.Properties.ValueMember = "编号";
            lookUpEditYbsfl.Properties.DataSource = dt;

        }

        private void SetHqqy()
        {
            DataTable dt = service.ExecuteReturnTb("tms.Common.Common", "t_hqdy", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            lookUpEditHq.Properties.DataSource = dt; 
            lookUpEditHq.Properties.DisplayMember = "名称"; 
            lookUpEditHq.Properties.ValueMember = "编号";
        }

        private void SetGhdw()
        {
            DataTable dt = service.ExecuteReturnTb("tms.Common.Common", "t_ghdw", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }


            lookUpEditGhdw.Properties.DisplayMember = "名称";
            lookUpEditGhdw.Properties.ValueMember = "编号";
            lookUpEditGhdw.Properties.DataSource = dt;

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
                return;

            if (gridView1.SelectedRowsCount == 0)
                return;

            if (t_issueXjplan == null)
            {
                t_issueXjplan = service.ExecuteReturnTb(this.GetType().ToString(), "t_issueXjplan", null, out insert_t_issueXjplan, out errMsg);
                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg);
                    return;

                }
            }
            else
            {
                t_issueXjplan.Rows.Clear();
                t_issueXjplan.AcceptChanges();
            }
            
            string guid = Guid.NewGuid().ToString();
            foreach (int rowhandle in gridView1.GetSelectedRows())
            {

                string[] rowItem = new string[6];
                rowItem[0] = gridView1.GetRowCellValue(rowhandle, "ID").ToString();
                rowItem[1] = gridView1.GetRowCellValue(rowhandle, "货位").ToString();
                rowItem[2] = gridView1.GetRowCellValue(rowhandle, "册数").ToString(); 
                rowItem[3] = gridView1.GetRowCellValue(rowhandle, "码洋").ToString();
                rowItem[4] = gridView1.GetRowCellValue(rowhandle, "ID_HQDY").ToString();
                rowItem[5] = guid;
                t_issueXjplan.Rows.Add(rowItem);
            }
            service.ExecuteUpdate(insert_t_issueXjplan, t_issueXjplan, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            service.ExecuteReturnInt(this.GetType().ToString(), "PROC_ISSUEXJPLAN", new string[] { "p_guid:" + guid, "p_czybh:"+UserInfo.userid }, out errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            MessageBox.Show("下达成功");
            gridView1.DeleteSelectedRows();


        }

        private void MakeXjPlan_Activated(object sender, EventArgs e)
        {
            Application.AddMessageFilter(filter);
        }

        private void MakeXjPlan_Deactivate(object sender, EventArgs e)
        {
            Application.RemoveMessageFilter(filter);
        }
    }
}
