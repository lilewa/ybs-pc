namespace tms.WinForm.Sample
{
    partial class SampleBarCodePrint
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.txtIsbn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsbn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCbny = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.BackColor = System.Drawing.Color.White;
            this.barCodeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barCodeControl1.Location = new System.Drawing.Point(364, 8);
            this.barCodeControl1.Margin = new System.Windows.Forms.Padding(2);
            this.barCodeControl1.Module = 1D;
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(7, 1, 7, 0);
            this.barCodeControl1.ShowText = false;
            this.barCodeControl1.Size = new System.Drawing.Size(130, 42);
            this.barCodeControl1.Symbology = code128Generator1;
            this.barCodeControl1.TabIndex = 0;
            this.barCodeControl1.Text = "1234444444";
            this.barCodeControl1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(612, 21);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 25);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(80, 25);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(163, 20);
            this.txtIsbn.TabIndex = 2;
            this.txtIsbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIsbn_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "书号";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(1, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 375);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsbn,
            this.colSm,
            this.colDj,
            this.ColBb,
            this.colCbny,
            this.colId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIsbn
            // 
            this.colIsbn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIsbn.AppearanceHeader.Options.UseFont = true;
            this.colIsbn.Caption = "书号";
            this.colIsbn.FieldName = "ISBN";
            this.colIsbn.Name = "colIsbn";
            this.colIsbn.Visible = true;
            this.colIsbn.VisibleIndex = 0;
            // 
            // colSm
            // 
            this.colSm.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSm.AppearanceHeader.Options.UseFont = true;
            this.colSm.Caption = "书名";
            this.colSm.FieldName = "SM";
            this.colSm.Name = "colSm";
            this.colSm.Visible = true;
            this.colSm.VisibleIndex = 1;
            // 
            // colDj
            // 
            this.colDj.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDj.AppearanceHeader.Options.UseFont = true;
            this.colDj.Caption = "定价";
            this.colDj.FieldName = "DJ";
            this.colDj.Name = "colDj";
            this.colDj.Visible = true;
            this.colDj.VisibleIndex = 2;
            // 
            // ColBb
            // 
            this.ColBb.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColBb.AppearanceHeader.Options.UseFont = true;
            this.ColBb.Caption = "版别";
            this.ColBb.FieldName = "BB";
            this.ColBb.Name = "ColBb";
            this.ColBb.Visible = true;
            this.ColBb.VisibleIndex = 3;
            // 
            // colCbny
            // 
            this.colCbny.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCbny.AppearanceHeader.Options.UseFont = true;
            this.colCbny.Caption = "出版年月";
            this.colCbny.FieldName = "CBNY";
            this.colCbny.Name = "colCbny";
            this.colCbny.Visible = true;
            this.colCbny.VisibleIndex = 4;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "ID";
            this.colId.FieldName = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 5;
            // 
            // SampleBarCodePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 444);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.barCodeControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SampleBarCodePrint";
            this.Text = "样本条码打印";
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.TextEdit txtIsbn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsbn;
        private DevExpress.XtraGrid.Columns.GridColumn colSm;
        private DevExpress.XtraGrid.Columns.GridColumn colDj;
        private DevExpress.XtraGrid.Columns.GridColumn ColBb;
        private DevExpress.XtraGrid.Columns.GridColumn colCbny;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}