namespace tms.WinForm
{
    partial class test2
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
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.link1 = new DevExpress.XtraPrinting.Link(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.DocumentSource = this.printingSystem1;
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(607, 559);
            this.documentViewer1.TabIndex = 0;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.link1});
            // 
            // link1
            // 
            this.link1.PrintingSystemBase = this.printingSystem1;
            this.link1.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateMarginalHeaderArea);
            this.link1.CreateDetailHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateDetailHeaderArea);
            this.link1.CreateDetailFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateDetailFooterArea);
            this.link1.CreateDetailArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateDetailArea);
            // 
            // test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 559);
            this.Controls.Add(this.documentViewer1);
            this.Name = "test2";
            this.Text = "test2";
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.Link link1;
    }
}