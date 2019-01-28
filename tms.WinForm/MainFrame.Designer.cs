namespace tms.WinForm
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSampleTrans = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSamplePrint = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSampleHw = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPurchaseRegist = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSampleStock = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPurchaseDeal = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLiraryImport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLack = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTaskSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtoneXjPlan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPKSearch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExceptionSearch = new DevExpress.XtraBars.BarButtonItem();
            this.rbpSample = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpPurchase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnSampleTrans,
            this.barBtnSamplePrint,
            this.barBtnSampleHw,
            this.barBtnPurchaseRegist,
            this.barBtnSampleStock,
            this.barBtnPurchaseDeal,
            this.barBtnLiraryImport,
            this.barButtonLack,
            this.barButtonTaskSearch,
            this.barButtoneXjPlan,
            this.barButtonPKSearch,
            this.barButtonExceptionSearch});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpSample});
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(926, 147);
            // 
            // barBtnSampleTrans
            // 
            this.barBtnSampleTrans.Caption = "样本交接复核";
            this.barBtnSampleTrans.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSampleTrans.Glyph")));
            this.barBtnSampleTrans.Id = 1;
            this.barBtnSampleTrans.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSampleTrans.LargeGlyph")));
            this.barBtnSampleTrans.Name = "barBtnSampleTrans";
            this.barBtnSampleTrans.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSampleTrans.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSampleTrans_ItemClick);
            // 
            // barBtnSamplePrint
            // 
            this.barBtnSamplePrint.Caption = "样本条码打印";
            this.barBtnSamplePrint.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSamplePrint.Glyph")));
            this.barBtnSamplePrint.Id = 2;
            this.barBtnSamplePrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSamplePrint.LargeGlyph")));
            this.barBtnSamplePrint.Name = "barBtnSamplePrint";
            this.barBtnSamplePrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnSamplePrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSamplePrint_ItemClick);
            // 
            // barBtnSampleHw
            // 
            this.barBtnSampleHw.Caption = "货位管理";
            this.barBtnSampleHw.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSampleHw.Glyph")));
            this.barBtnSampleHw.Id = 5;
            this.barBtnSampleHw.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSampleHw.LargeGlyph")));
            this.barBtnSampleHw.Name = "barBtnSampleHw";
            this.barBtnSampleHw.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSampleHw_ItemClick);
            // 
            // barBtnPurchaseRegist
            // 
            this.barBtnPurchaseRegist.Caption = "现采登记";
            this.barBtnPurchaseRegist.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPurchaseRegist.Glyph")));
            this.barBtnPurchaseRegist.Id = 6;
            this.barBtnPurchaseRegist.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnPurchaseRegist.LargeGlyph")));
            this.barBtnPurchaseRegist.Name = "barBtnPurchaseRegist";
            this.barBtnPurchaseRegist.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPurchaseRegist_ItemClick);
            // 
            // barBtnSampleStock
            // 
            this.barBtnSampleStock.Caption = "库存查询";
            this.barBtnSampleStock.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSampleStock.Glyph")));
            this.barBtnSampleStock.Id = 7;
            this.barBtnSampleStock.Name = "barBtnSampleStock";
            this.barBtnSampleStock.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSampleStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSampleStock_ItemClick);
            // 
            // barBtnPurchaseDeal
            // 
            this.barBtnPurchaseDeal.Caption = "现采订单处理";
            this.barBtnPurchaseDeal.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPurchaseDeal.Glyph")));
            this.barBtnPurchaseDeal.Id = 8;
            this.barBtnPurchaseDeal.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnPurchaseDeal.LargeGlyph")));
            this.barBtnPurchaseDeal.Name = "barBtnPurchaseDeal";
            this.barBtnPurchaseDeal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPurchaseSearch_ItemClick);
            // 
            // barBtnLiraryImport
            // 
            this.barBtnLiraryImport.Caption = "馆藏书目导入";
            this.barBtnLiraryImport.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLiraryImport.Glyph")));
            this.barBtnLiraryImport.Id = 10;
            this.barBtnLiraryImport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnLiraryImport.LargeGlyph")));
            this.barBtnLiraryImport.Name = "barBtnLiraryImport";
            this.barBtnLiraryImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLiraryImport_ItemClick);
            // 
            // barButtonLack
            // 
            this.barButtonLack.Caption = "差异处理";
            this.barButtonLack.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonLack.Glyph")));
            this.barButtonLack.Id = 11;
            this.barButtonLack.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonLack.LargeGlyph")));
            this.barButtonLack.Name = "barButtonLack";
            this.barButtonLack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLack_ItemClick);
            // 
            // barButtonTaskSearch
            // 
            this.barButtonTaskSearch.Caption = "任务查询";
            this.barButtonTaskSearch.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonTaskSearch.Glyph")));
            this.barButtonTaskSearch.Id = 12;
            this.barButtonTaskSearch.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonTaskSearch.LargeGlyph")));
            this.barButtonTaskSearch.Name = "barButtonTaskSearch";
            this.barButtonTaskSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTaskSearch_ItemClick);
            // 
            // barButtoneXjPlan
            // 
            this.barButtoneXjPlan.Caption = "下架计划";
            this.barButtoneXjPlan.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtoneXjPlan.Glyph")));
            this.barButtoneXjPlan.Id = 13;
            this.barButtoneXjPlan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtoneXjPlan.LargeGlyph")));
            this.barButtoneXjPlan.Name = "barButtoneXjPlan";
            this.barButtoneXjPlan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtoneXjPlan_ItemClick);
            // 
            // barButtonPKSearch
            // 
            this.barButtonPKSearch.Caption = "盘库查询";
            this.barButtonPKSearch.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonPKSearch.Glyph")));
            this.barButtonPKSearch.Id = 14;
            this.barButtonPKSearch.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonPKSearch.LargeGlyph")));
            this.barButtonPKSearch.Name = "barButtonPKSearch";
            this.barButtonPKSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPKSearch_ItemClick);
            // 
            // barButtonExceptionSearch
            // 
            this.barButtonExceptionSearch.Caption = "异常查询";
            this.barButtonExceptionSearch.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonExceptionSearch.Glyph")));
            this.barButtonExceptionSearch.Id = 15;
            this.barButtonExceptionSearch.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonExceptionSearch.LargeGlyph")));
            this.barButtonExceptionSearch.Name = "barButtonExceptionSearch";
            this.barButtonExceptionSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExceptionSearch_ItemClick);
            // 
            // rbpSample
            // 
            this.rbpSample.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.rbpPurchase});
            this.rbpSample.Name = "rbpSample";
            this.rbpSample.Text = "样本室";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSampleTrans);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonTaskSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtoneXjPlan);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonLack);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSampleStock);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSampleHw);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSamplePrint);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonPKSearch);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonExceptionSearch);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "样本管理";
            // 
            // rbpPurchase
            // 
            this.rbpPurchase.ItemLinks.Add(this.barBtnPurchaseRegist);
            this.rbpPurchase.ItemLinks.Add(this.barBtnPurchaseDeal);
            this.rbpPurchase.ItemLinks.Add(this.barBtnLiraryImport);
            this.rbpPurchase.Name = "rbpPurchase";
            this.rbpPurchase.Text = "现采管理";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 654);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFrame";
            this.Ribbon = this.ribbonControl1;
            this.Text = "样本室管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnSampleTrans;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSample;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnSamplePrint;
        private DevExpress.XtraBars.BarButtonItem barBtnSampleHw;
        private DevExpress.XtraBars.BarButtonItem barBtnPurchaseRegist;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpPurchase;
        private DevExpress.XtraBars.BarButtonItem barBtnSampleStock;
        private DevExpress.XtraBars.BarButtonItem barBtnPurchaseDeal;
        private DevExpress.XtraBars.BarButtonItem barBtnLiraryImport;
        private DevExpress.XtraBars.BarButtonItem barButtonLack;
        private DevExpress.XtraBars.BarButtonItem barButtonTaskSearch;
        private DevExpress.XtraBars.BarButtonItem barButtoneXjPlan;
        private DevExpress.XtraBars.BarButtonItem barButtonPKSearch;
        private DevExpress.XtraBars.BarButtonItem barButtonExceptionSearch;
    }
}