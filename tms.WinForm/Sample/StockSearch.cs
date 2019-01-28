using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tms.WinForm.Sample
{
    public partial class StockSearch : tms.WinForm.Common.BaseForm
    {
        public StockSearch()
        {
            InitializeComponent();

            SetFl();
            SetGhdw();
            SetHqqy();
            AppendKeyDownNoXml(this.Controls);
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

            if (txtHw.Text.Length > 0)
            {
                param.Add("p_hw:" + txtHw.Text);
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
            if (txtIsbn.Text.Length > 0)
            {
                param.Add("p_isbn:" + txtIsbn.Text);
            }

            DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchLtkf", param.ToArray(), out errMsg);
            gridControl1.DataSource = dt;

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
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
    }
}
