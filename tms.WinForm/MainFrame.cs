using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.XtraTabbedMdi;
using tms.WinForm.Purchase;
using tms.WinForm.Sample;
using System.Xml.Linq;
using System.Configuration;

namespace tms.WinForm
{
    public partial class MainFrame : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainFrame()
        {
            InitializeComponent();
            xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.WindowState = FormWindowState.Maximized;

            CommonUse.xmlAppSet= XElement.Load(Application.StartupPath + "\\Resources\\items.xml");
            CommonUse.connectionstring = ConfigurationManager.ConnectionStrings["Oracle"].ToString();

          //  if(UserInfo.type==UserType.customer)
            ribbonControl1.Pages[0].Groups[1].Visible = false;

        }

        public void ShowForm(Type type,  params object[] param)
        {
            bool find = false;
            foreach (XtraMdiTabPage p in xtraTabbedMdiManager1.Pages)
            {
                if (p.MdiChild.GetType() == type)
                {
                    xtraTabbedMdiManager1.SelectedPage = p;
                    find = true;
                    
                    break;
                }
            }
            if(!find)
            { 
                object obj =  type.Assembly.CreateInstance(type.ToString(),
                    false,System.Reflection.BindingFlags.CreateInstance,null,param, null, null);
                PropertyInfo propertyInfo = type.GetProperty("MdiParent");
                propertyInfo.SetValue(obj, this, null);
                MethodInfo methodinfo = type.GetMethod("Show", System.Type.EmptyTypes, null);
                
                methodinfo.Invoke(obj, null);
                 
               // xtraTabbedMdiManager1.SelectedPage.Text = caption;

            }
        }
        
        private void barBtnSampleTrans_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //样本交接复核

            //SampleTransfer form = new SampleTransfer();
            //form.MdiParent = this;
            //form.Show(); 
            
            ShowForm(typeof(SampleTransfer),  null);
        }

        private void barBtnSamplePrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //样本条码打印

            ShowForm(typeof(SampleBarCodePrint),   null); 
        }
         
        private void barBtnSampleHw_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //货位管理 
            ShowForm(typeof(SampleHwManager),   null); 
        }

        private void barBtnSampleStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //库存查询
       
            ShowForm(typeof(StockSearch), null); 
        }

        private void barBtnPurchaseRegist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //现采登记
            ShowForm(typeof(UserRegist),   null);
            
        }

        private void barBtnPurchaseSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ////现采订单处理  现采查询 一人显示一条记录。一个品种显示一条记录
            //ShowForm(typeof(OrderProcess),   null);

            ShowForm(typeof(OrderProcess), null);
        }

        private void barBtnLiraryImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(LibraryImport),   null);
        }

        private void barButtonLack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //差异处理
            ShowForm(typeof(LackProcess),   null);
        }

        private void barButtonTaskSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //任务查询
            ShowForm(typeof(TaskSearch), "");
        }

        private void barButtoneXjPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(MakeXjPlan),   null);
        }

        private void barButtonPKSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //盘库查询
             ShowForm(typeof(PKSearch), null);
        }

        
        private void barButtonExceptionSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //接口异常
            ShowForm(typeof(ExceptionSearch), null);
        }
    }
}