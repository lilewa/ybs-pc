using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tms.WinForm.Sample
{
    public partial class PKSearch : tms.WinForm.Common.BaseForm
    {
        public PKSearch()
        {
            InitializeComponent();
            SetHqqy();
            SetGhdw();
            SetMaskAndEnable();
            AppendKeyDownNoXml(this.Controls);
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


        private void SetMaskAndEnable()
        {
            txtXdBegin.Properties.Mask.EditMask = "[1-9]\\d{0,2}";
            txtXdBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx; 

            txtXdEnd.Properties.Mask.EditMask = "[1-9]\\d{0,2}";
            txtXdEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            
            txtShelfBegin.Properties.Mask.EditMask = "[1-9]\\d?";
            txtShelfBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

             
            txtShelfEnd.Properties.Mask.EditMask = "[1-9]\\d?";
            txtShelfEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>();
            int num;
            if (!string.IsNullOrWhiteSpace(lookUpEditHq.EditValue?.ToString())) 
            {
                param.Add("p_id_hqdy:" + lookUpEditHq.EditValue?.ToString());
            }

            if (!string.IsNullOrWhiteSpace(lookUpEditGhdw.EditValue?.ToString())) 
            {
                param.Add("p_id_ghdw:" + lookUpEditGhdw.EditValue?.ToString());
            }

            if (!string.IsNullOrWhiteSpace(txtXdBegin.Text))
            {
                param.Add("p_xdBegin:" + txtXdBegin.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtXdEnd.Text))
            {
                param.Add("p_xdEnd:" + txtXdEnd.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtShelfBegin.Text))
            {
                param.Add("p_shelfBegin:" + txtShelfBegin.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtShelfEnd.Text))
            {
                param.Add("p_shelfEnd:" + txtShelfEnd.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtDjBegin.Text))
            {
                if (!int.TryParse(txtDjBegin.Text, out num) || num<0 )
                {
                    MessageBox.Show("定价数字格式输入不正确");
                    return;
                }
                param.Add("p_djBegin:" + txtDjBegin.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtDjEnd.Text))
            {
                if (!int.TryParse(txtDjEnd.Text, out num) || num < 0)
                {
                    MessageBox.Show("定价数字格式输入不正确");
                    return;
                }
                param.Add("p_djEnd:" + txtDjEnd.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtChayiBegin.Text))
            {
                if (!int.TryParse(txtChayiBegin.Text, out num) || num < 0)
                {
                    MessageBox.Show("定价数字格式输入不正确");
                    return;
                }
                param.Add("p_chayiBegin:" + txtChayiBegin.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtChayiEnd.Text))
            {
                if (!int.TryParse(txtChayiEnd.Text, out num) || num < 0)
                {
                    MessageBox.Show("定价数字格式输入不正确");
                    return;
                }
                param.Add("p_chayiEnd:" + txtChayiEnd.Text);
            }

            DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchCy", param.ToArray(), out errMsg); 
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
        }
    }
}
