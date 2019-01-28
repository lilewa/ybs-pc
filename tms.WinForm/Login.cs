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

namespace tms.WinForm
{
    public partial class Login : BaseForm
    { 

        public Login()
        {
            InitializeComponent();
            service = new MainWebService.MainWebService();
            this.KeyPreview = true;
            //txtUser.Focus();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUser.Text.Trim().Length > 0)
            { 
                txtPwd.Focus(); 
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtUser.Focused && txtUser.Text.Trim().Length >0)
                {
                    txtPwd.Focus();
                }
                
                else if(txtPwd.Focused)
                {
                    if (txtUser.Text.Trim().Length == 0)
                    {
                        txtUser.Focus();
                    }
                    else if (txtPwd.Text.Trim().Length > 0)
                    {
                        btnLogin_Click(null, null);
                    }
                }

            }
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().Length == 0)
                return;

            if (txtPwd.Text.Trim().Length == 0)
                return;

            List<string> param = new List<string>();
            param.Add("p_czybh:" + txtUser.Text);
            param.Add("p_password:" + txtPwd.Text);

            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "RF_LOGIN", param.ToArray(), out selectSql, out errMsg);
            
            if (!string.IsNullOrEmpty(errMsg))
            {
                //登录出错
                MessageBox.Show(errMsg);
                txtPwd.Text = string.Empty;
                txtUser.Focus();
                txtUser.SelectAll();
                return;
            }
            UserInfo.userid = txtUser.Text;
            UserInfo.username = dt.Rows[0]["p_name"].ToString(); 
            UserInfo.type = (UserType)Enum.Parse(typeof(UserType), dt.Rows[0]["p_lx"].ToString(),true);
            DialogResult = DialogResult.OK;

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
        }
    }
}