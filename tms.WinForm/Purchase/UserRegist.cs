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
    public partial class UserRegist : BaseForm
    {
         
        public UserRegist()
        {
            InitializeComponent();

           DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "LoadLibrary", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            lookupLibraty.Properties.DataSource = dt; 
            lookupLibraty.Properties.DisplayMember = "名称"; 
            lookupLibraty.Properties.ValueMember = "编号";


            lookupLibraty2.Properties.DataSource = dt;
            lookupLibraty2.Properties.DisplayMember = "名称";
            lookupLibraty2.Properties.ValueMember = "编号";

            lookupPaylibrary.Properties.DataSource = dt; 
            lookupPaylibrary.Properties.DisplayMember = "名称"; 
            lookupPaylibrary.Properties.ValueMember = "编号";

            lookupPaylibrary2.Properties.DataSource = dt;
            lookupPaylibrary2.Properties.DisplayMember = "名称";
            lookupPaylibrary2.Properties.ValueMember = "编号";

            dt = service.ExecuteReturnTb("tms.Common.Common", "t_hqdy", null, out selectSql, out errMsg);

            repositoryItemCheckedComboBoxEdit1.DataSource= checkedComboBoxEditHq.Properties.DataSource = dt;
            repositoryItemCheckedComboBoxEdit1.ValueMember= checkedComboBoxEditHq.Properties.ValueMember = "编号";
            repositoryItemCheckedComboBoxEdit1.DisplayMember= checkedComboBoxEditHq.Properties.DisplayMember = "名称";
            string allValue = string.Join(",", dt.AsEnumerable().Select(dr => dr.Field<string>("编号")).ToArray());
            checkedComboBoxEditHq.SetEditValue(allValue);

             dt = service.ExecuteReturnTb(this.GetType().ToString(), "T_GPFLOWID", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            comboBoxEditQh.Properties.Items.AddRange(dt.AsEnumerable().Select(dr=>dr.Field<decimal>(0)).ToArray());



            this.AppendKeyDown(popupControlSearch.Controls);

           // spinEditPerson.EnterMoveNextControl 需要设置成false

           this.AppendKeyDown(popupContainerAdd.Controls);

        }
 
 
        //private void Search(string userid,string orderid)
        //{
        //    List<string> param = new List<string>();
        //    if (!string.IsNullOrWhiteSpace(userid))
        //    {
        //        param.Add("p_userid:"+ userid);
        //        param.Add("p_orderid:" + orderid);
        //        DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchUser", param.ToArray(), out selectSql, out errMsg);
        //        if (!string.IsNullOrEmpty(errMsg))
        //        {
        //            MessageBox.Show(errMsg);
        //            return;
        //        }
        //        if (gridView1.RowCount > 0)
        //        {
        //            (gridControl1.DataSource as DataTable).ImportRow(dt.Rows[0]);
        //        }
        //        else
        //        {
        //            gridControl1.DataSource = dt;
        //        }
        //    }
        //    else
        //    {
        //        if (lookupLibraty.EditValue != null && string.IsNullOrWhiteSpace(lookupLibraty.EditValue.ToString()))
        //        {
        //            param.Add("p_library:" + lookupLibraty.EditValue.ToString()); 
        //        }
        //        if (lookupPaylibrary.EditValue != null && string.IsNullOrWhiteSpace(lookupPaylibrary.EditValue.ToString()))
        //        { 
        //            param.Add("p_paylibrary:" + lookupPaylibrary.EditValue.ToString());
        //        }
                
        //        DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchUser", param.ToArray(), out selectSql, out errMsg);
        //        if (!string.IsNullOrEmpty(errMsg))
        //        {
        //            MessageBox.Show(errMsg);
        //            return;
        //        } 
        //        gridControl1.DataSource = dt;
        //    }
            
           
        //}

        private void ddbAdd_Click(object sender, EventArgs e)
        {
            //< parameter name = "p_library" type = "CHAR" direction = "in" ></ parameter >

            //< parameter name = "p_paylibrary" type = "CHAR" direction = "in" ></ parameter >

            //     < parameter name = "p_czybh" type = "CHAR" direction = "in" ></ parameter >
            string[] param = new string[4];
            if (lookupLibraty2.EditValue == null || string.IsNullOrWhiteSpace(lookupLibraty2.EditValue.ToString()))
            {
                MessageBox.Show("请输入图书馆");
                return;
            }
            if (lookupPaylibrary2.EditValue == null || string.IsNullOrWhiteSpace(lookupPaylibrary2.EditValue.ToString()))
            {
                MessageBox.Show("请输入结算图书馆");
                return;
            }
            param[0] = ("p_library:" + lookupLibraty2.EditValue.ToString().Trim());
            param[1] = ("p_paylibrary:" + lookupPaylibrary2.EditValue.ToString().Trim());
            param[2] = ("p_czybh:" + UserInfo.userid);
            param[3] = ("p_ids_hqdy:" + checkedComboBoxEditHq.EditValue?.ToString());
            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "PROC_ADDUSER", param, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            List<string> param2 = new List<string>();
            param2.Add("p_library:" + lookupLibraty2.EditValue.ToString().Trim());
            param2.Add("p_gpflowid:" + dt.Rows[0]["p_gpflowid"].ToString());
            dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchUser", param2.ToArray(), out errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            gridControl1.DataSource = dt;

           
        }

        private void ddbSearch_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>();
            if (comboBoxEditQh.SelectedIndex != 0)
            {
                param.Add("p_gpflowid:"+comboBoxEditQh.SelectedText);
            }
            if (!string.IsNullOrWhiteSpace(lookupLibraty.EditValue?.ToString())) 
            {
                param.Add("p_Libraty:" + lookupLibraty.EditValue?.ToString());
            }
            if (!string.IsNullOrWhiteSpace(lookupPaylibrary.EditValue?.ToString())) 
            {
                param.Add("p_PayLibraty:" + lookupPaylibrary.EditValue?.ToString());
            }
            if (dateEditBegin.EditValue != null)
            {
                param.Add("p_djBegin:" + dateEditBegin.DateTime.ToShortDateString());
            } 
            if (dateEditEnd.EditValue != null)
            {
                param.Add("p_p_djEnd:" + dateEditEnd.DateTime.AddDays(1).ToShortDateString());
            }

            DataTable dt = service.ExecuteDynamicSql(this.GetType().ToString(), "SearchUser", param.ToArray(), out errMsg);
            
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            gridControl1.DataSource = dt;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        { 
            string p_gpflowid = gridView1.GetRowCellValue(e.RowHandle, "馆配期号").ToString();
            string p_userid = gridView1.GetRowCellValue(e.RowHandle, "ID").ToString();
            string p_pwd = gridView1.GetRowCellValue(e.RowHandle, "密码").ToString();
            string p_ids_hqdy = gridView1.GetRowCellValue(e.RowHandle, "货区").ToString();

            List<string> param = new List<string>();
            param.Add("p_userid:"+ p_userid);
            param.Add("p_gpflowid:" + p_gpflowid);
            param.Add("p_pwd:" + p_pwd);
            param.Add("p_ids_hqdy:" + p_ids_hqdy);
            service.ExecuteReturnInt(this.GetType().ToString(), "UpdatePwdHq", param.ToArray(),  out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

        } 
       

        private void popupControlSearch_Enter(object sender, EventArgs e)
        {
           // comboBoxEditQh.Focus();
        }

        private void popupControlSearch_Popup(object sender, EventArgs e)
        {
          //  comboBoxEditQh.Focus();
        }

        private void comboBoxEditQh_Enter(object sender, EventArgs e)
        {
            Console.Write("1");
        }

        private void popupControlSearch_VisibleChanged(object sender, EventArgs e)
        {
            if(popupControlSearch.Visible)
            {

                popupControlSearch.Focus();
                comboBoxEditQh.Focus();
            }
                
        }
    }
}