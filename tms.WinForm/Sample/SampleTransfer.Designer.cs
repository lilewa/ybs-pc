namespace tms.WinForm.Sample
{
    partial class SampleTransfer
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
            this.txtRqh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCbny = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIsbn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ckbTopic = new System.Windows.Forms.CheckBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.ckbPs = new System.Windows.Forms.CheckBox();
            this.txtSm = new DevExpress.XtraEditors.TextEdit();
            this.txtDj = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRqh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDj.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRqh
            // 
            this.txtRqh.Location = new System.Drawing.Point(66, 8);
            this.txtRqh.Margin = new System.Windows.Forms.Padding(2);
            this.txtRqh.Name = "txtRqh";
            this.txtRqh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRqh.Properties.Appearance.Options.UseFont = true;
            this.txtRqh.Size = new System.Drawing.Size(172, 26);
            this.txtRqh.TabIndex = 0;
            this.txtRqh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRqh_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(11, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "单据号";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(1, 91);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(996, 601);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.colISBN,
            this.colSm,
            this.colDj,
            this.colCbny,
            this.colZt,
            this.colID,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colZt, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.FieldName = "破损";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 78;
            // 
            // colISBN
            // 
            this.colISBN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colISBN.AppearanceHeader.Options.UseFont = true;
            this.colISBN.Caption = "ISBN";
            this.colISBN.FieldName = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 1;
            this.colISBN.Width = 185;
            // 
            // colSm
            // 
            this.colSm.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSm.AppearanceHeader.Options.UseFont = true;
            this.colSm.Caption = "书名";
            this.colSm.FieldName = "书名";
            this.colSm.Name = "colSm";
            this.colSm.Visible = true;
            this.colSm.VisibleIndex = 2;
            this.colSm.Width = 236;
            // 
            // colDj
            // 
            this.colDj.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDj.AppearanceHeader.Options.UseFont = true;
            this.colDj.Caption = "定价";
            this.colDj.FieldName = "定价";
            this.colDj.Name = "colDj";
            this.colDj.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "定价", "码洋:{0:0.##}")});
            this.colDj.Visible = true;
            this.colDj.VisibleIndex = 3;
            this.colDj.Width = 101;
            // 
            // colCbny
            // 
            this.colCbny.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCbny.AppearanceHeader.Options.UseFont = true;
            this.colCbny.FieldName = "货位";
            this.colCbny.Name = "colCbny";
            this.colCbny.Visible = true;
            this.colCbny.VisibleIndex = 4;
            this.colCbny.Width = 109;
            // 
            // colZt
            // 
            this.colZt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colZt.AppearanceHeader.Options.UseFont = true;
            this.colZt.FieldName = "状态";
            this.colZt.Name = "colZt";
            this.colZt.Visible = true;
            this.colZt.VisibleIndex = 5;
            this.colZt.Width = 90;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 8;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.FieldName = "去向";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "SAMEISBN";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "供货商";
            this.gridColumn3.FieldName = "供货商";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 174;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(66, 47);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIsbn.Properties.Appearance.Options.UseFont = true;
            this.txtIsbn.Size = new System.Drawing.Size(172, 26);
            this.txtIsbn.TabIndex = 1;
            this.txtIsbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIsbn_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(28, 47);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "书号";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.Location = new System.Drawing.Point(854, 16);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 43);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "提交";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(283, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "书名:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(283, 47);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 19);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "定价:";
            // 
            // ckbTopic
            // 
            this.ckbTopic.AutoCheck = false;
            this.ckbTopic.AutoSize = true;
            this.ckbTopic.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ckbTopic.Location = new System.Drawing.Point(726, 46);
            this.ckbTopic.Margin = new System.Windows.Forms.Padding(2);
            this.ckbTopic.Name = "ckbTopic";
            this.ckbTopic.Size = new System.Drawing.Size(76, 23);
            this.ckbTopic.TabIndex = 4;
            this.ckbTopic.Text = "专题区";
            this.ckbTopic.UseVisualStyleBackColor = true;
            this.ckbTopic.Click += new System.EventHandler(this.ckbTopic_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(424, 50);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 19);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "总册数";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(485, 47);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Size = new System.Drawing.Size(74, 26);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyDown);
            // 
            // ckbPs
            // 
            this.ckbPs.AutoCheck = false;
            this.ckbPs.AutoSize = true;
            this.ckbPs.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ckbPs.Location = new System.Drawing.Point(616, 46);
            this.ckbPs.Margin = new System.Windows.Forms.Padding(2);
            this.ckbPs.Name = "ckbPs";
            this.ckbPs.Size = new System.Drawing.Size(60, 23);
            this.ckbPs.TabIndex = 7;
            this.ckbPs.Text = "破损";
            this.ckbPs.UseVisualStyleBackColor = true;
            this.ckbPs.Click += new System.EventHandler(this.ckbPs_Click);
            // 
            // txtSm
            // 
            this.txtSm.Location = new System.Drawing.Point(325, 8);
            this.txtSm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSm.Name = "txtSm";
            this.txtSm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSm.Properties.Appearance.Options.UseFont = true;
            this.txtSm.Properties.ReadOnly = true;
            this.txtSm.Size = new System.Drawing.Size(477, 26);
            this.txtSm.TabIndex = 1;
            this.txtSm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIsbn_KeyDown);
            // 
            // txtDj
            // 
            this.txtDj.Location = new System.Drawing.Point(325, 47);
            this.txtDj.Margin = new System.Windows.Forms.Padding(2);
            this.txtDj.Name = "txtDj";
            this.txtDj.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDj.Properties.Appearance.Options.UseFont = true;
            this.txtDj.Properties.ReadOnly = true;
            this.txtDj.Size = new System.Drawing.Size(76, 26);
            this.txtDj.TabIndex = 6;
            this.txtDj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyDown);
            // 
            // SampleTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 694);
            this.Controls.Add(this.ckbPs);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDj);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.ckbTopic);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSm);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtRqh);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SampleTransfer";
            this.Text = "样本交接复核";
            ((System.ComponentModel.ISupportInitialize)(this.txtRqh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDj.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRqh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtIsbn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colSm;
        private DevExpress.XtraGrid.Columns.GridColumn colDj;
        private DevExpress.XtraGrid.Columns.GridColumn colCbny;
        private DevExpress.XtraGrid.Columns.GridColumn colZt;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.CheckBox ckbTopic;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.CheckBox ckbPs;
        private DevExpress.XtraEditors.TextEdit txtSm;
        private DevExpress.XtraEditors.TextEdit txtDj;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}