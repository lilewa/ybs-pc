namespace tms.WinForm.Sample
{
    partial class PKSearch
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
            this.lookUpEditHq = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtXdBegin = new DevExpress.XtraEditors.TextEdit();
            this.txtXdEnd = new DevExpress.XtraEditors.TextEdit();
            this.txtShelfEnd = new DevExpress.XtraEditors.TextEdit();
            this.txtShelfBegin = new DevExpress.XtraEditors.TextEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDjBegin = new DevExpress.XtraEditors.TextEdit();
            this.txtDjEnd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtChayiBegin = new DevExpress.XtraEditors.TextEdit();
            this.txtChayiEnd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditGhdw = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditHq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXdBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXdEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShelfEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShelfBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChayiBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChayiEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGhdw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditHq
            // 
            this.lookUpEditHq.Location = new System.Drawing.Point(71, 27);
            this.lookUpEditHq.Name = "lookUpEditHq";
            this.lookUpEditHq.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpEditHq.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lookUpEditHq.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditHq.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditHq.Properties.NullText = "";
            this.lookUpEditHq.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditHq.Size = new System.Drawing.Size(189, 24);
            this.lookUpEditHq.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(35, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "货区";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Location = new System.Drawing.Point(632, 71);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(15, 18);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "至";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(519, 30);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "巷道";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Location = new System.Drawing.Point(632, 30);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 18);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "至";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Location = new System.Drawing.Point(519, 71);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 18);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "货架";
            // 
            // txtXdBegin
            // 
            this.txtXdBegin.Location = new System.Drawing.Point(555, 31);
            this.txtXdBegin.Margin = new System.Windows.Forms.Padding(2);
            this.txtXdBegin.Name = "txtXdBegin";
            this.txtXdBegin.Properties.Mask.EditMask = "[1-9]\\d{0,2}";
            this.txtXdBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtXdBegin.Size = new System.Drawing.Size(73, 20);
            this.txtXdBegin.TabIndex = 2;
            // 
            // txtXdEnd
            // 
            this.txtXdEnd.Location = new System.Drawing.Point(663, 31);
            this.txtXdEnd.Margin = new System.Windows.Forms.Padding(2);
            this.txtXdEnd.Name = "txtXdEnd";
            this.txtXdEnd.Size = new System.Drawing.Size(73, 20);
            this.txtXdEnd.TabIndex = 3;
            // 
            // txtShelfEnd
            // 
            this.txtShelfEnd.Location = new System.Drawing.Point(663, 69);
            this.txtShelfEnd.Margin = new System.Windows.Forms.Padding(2);
            this.txtShelfEnd.Name = "txtShelfEnd";
            this.txtShelfEnd.Size = new System.Drawing.Size(73, 20);
            this.txtShelfEnd.TabIndex = 9;
            // 
            // txtShelfBegin
            // 
            this.txtShelfBegin.Location = new System.Drawing.Point(555, 70);
            this.txtShelfBegin.Margin = new System.Windows.Forms.Padding(2);
            this.txtShelfBegin.Name = "txtShelfBegin";
            this.txtShelfBegin.Size = new System.Drawing.Size(73, 20);
            this.txtShelfBegin.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(871, 28);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(871, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDjBegin
            // 
            this.txtDjBegin.Location = new System.Drawing.Point(70, 70);
            this.txtDjBegin.Margin = new System.Windows.Forms.Padding(2);
            this.txtDjBegin.Name = "txtDjBegin";
            this.txtDjBegin.Size = new System.Drawing.Size(73, 20);
            this.txtDjBegin.TabIndex = 4;
            // 
            // txtDjEnd
            // 
            this.txtDjEnd.Location = new System.Drawing.Point(185, 70);
            this.txtDjEnd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDjEnd.Name = "txtDjEnd";
            this.txtDjEnd.Size = new System.Drawing.Size(73, 20);
            this.txtDjEnd.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(35, 71);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "定价";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(154, 72);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(15, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "至";
            // 
            // txtChayiBegin
            // 
            this.txtChayiBegin.Location = new System.Drawing.Point(317, 72);
            this.txtChayiBegin.Margin = new System.Windows.Forms.Padding(2);
            this.txtChayiBegin.Name = "txtChayiBegin";
            this.txtChayiBegin.Size = new System.Drawing.Size(73, 20);
            this.txtChayiBegin.TabIndex = 6;
            // 
            // txtChayiEnd
            // 
            this.txtChayiEnd.Location = new System.Drawing.Point(429, 71);
            this.txtChayiEnd.Margin = new System.Windows.Forms.Padding(2);
            this.txtChayiEnd.Name = "txtChayiEnd";
            this.txtChayiEnd.Size = new System.Drawing.Size(73, 20);
            this.txtChayiEnd.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Location = new System.Drawing.Point(281, 73);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 18);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "差异";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Location = new System.Drawing.Point(398, 73);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(15, 18);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "至";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(-2, 115);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1019, 617);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn14});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn1.FieldName = "书名";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 171;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.FieldName = "盘库数";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 59;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.FieldName = "差异数";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 58;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.FieldName = "货位";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 126;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn5.FieldName = "供货商";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 147;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.FieldName = "定价";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 63;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn12.AppearanceHeader.Options.UseFont = true;
            this.gridColumn12.FieldName = "ISBN";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 101;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn14.AppearanceHeader.Options.UseFont = true;
            this.gridColumn14.FieldName = "库存数";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 56;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Location = new System.Drawing.Point(266, 31);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(45, 18);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "供货商";
            // 
            // lookUpEditGhdw
            // 
            this.lookUpEditGhdw.Location = new System.Drawing.Point(317, 27);
            this.lookUpEditGhdw.Name = "lookUpEditGhdw";
            this.lookUpEditGhdw.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpEditGhdw.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lookUpEditGhdw.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditGhdw.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGhdw.Properties.NullText = "";
            this.lookUpEditGhdw.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditGhdw.Size = new System.Drawing.Size(189, 24);
            this.lookUpEditGhdw.TabIndex = 1;
            // 
            // PKSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1019, 732);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtChayiEnd);
            this.Controls.Add(this.txtXdBegin);
            this.Controls.Add(this.txtDjEnd);
            this.Controls.Add(this.txtChayiBegin);
            this.Controls.Add(this.txtXdEnd);
            this.Controls.Add(this.txtDjBegin);
            this.Controls.Add(this.txtShelfEnd);
            this.Controls.Add(this.txtShelfBegin);
            this.Controls.Add(this.lookUpEditGhdw);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.lookUpEditHq);
            this.Controls.Add(this.labelControl3);
            this.Name = "PKSearch";
            this.Text = "盘库查询";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditHq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXdBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXdEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShelfEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShelfBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChayiBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChayiEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGhdw.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditHq;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtXdBegin;
        private DevExpress.XtraEditors.TextEdit txtXdEnd;
        private DevExpress.XtraEditors.TextEdit txtShelfEnd;
        private DevExpress.XtraEditors.TextEdit txtShelfBegin;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtDjBegin;
        private DevExpress.XtraEditors.TextEdit txtDjEnd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtChayiBegin;
        private DevExpress.XtraEditors.TextEdit txtChayiEnd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
     
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditGhdw;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}
