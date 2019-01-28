namespace tms.WinForm.Sample
{
    partial class ExceptionSearch
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
            this.btnExceptionSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.comboExceptionLx = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateEditBegin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.comboExceptionLx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExceptionSearch
            // 
            this.btnExceptionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExceptionSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnExceptionSearch.Appearance.Options.UseFont = true;
            this.btnExceptionSearch.Location = new System.Drawing.Point(751, 20);
            this.btnExceptionSearch.Name = "btnExceptionSearch";
            this.btnExceptionSearch.Size = new System.Drawing.Size(95, 34);
            this.btnExceptionSearch.TabIndex = 3;
            this.btnExceptionSearch.Text = "查询";
            this.btnExceptionSearch.Click += new System.EventHandler(this.btnExceptionSearch_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl15.Location = new System.Drawing.Point(21, 28);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(32, 19);
            this.labelControl15.TabIndex = 27;
            this.labelControl15.Text = "类型";
            // 
            // comboExceptionLx
            // 
            this.comboExceptionLx.Location = new System.Drawing.Point(59, 24);
            this.comboExceptionLx.Margin = new System.Windows.Forms.Padding(2);
            this.comboExceptionLx.Name = "comboExceptionLx";
            this.comboExceptionLx.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboExceptionLx.Properties.Appearance.Options.UseFont = true;
            this.comboExceptionLx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboExceptionLx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboExceptionLx.Size = new System.Drawing.Size(126, 26);
            this.comboExceptionLx.TabIndex = 0;
            // 
            // dateEditEnd
            // 
            this.dateEditEnd.EditValue = new System.DateTime(2018, 3, 31, 17, 34, 37, 995);
            this.dateEditEnd.Location = new System.Drawing.Point(457, 24);
            this.dateEditEnd.Name = "dateEditEnd";
            this.dateEditEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEditEnd.Properties.Appearance.Options.UseFont = true;
            this.dateEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEditEnd.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditEnd.Size = new System.Drawing.Size(126, 26);
            this.dateEditEnd.TabIndex = 2;
            // 
            // dateEditBegin
            // 
            this.dateEditBegin.EditValue = new System.DateTime(2018, 3, 31, 17, 34, 31, 451);
            this.dateEditBegin.Location = new System.Drawing.Point(305, 24);
            this.dateEditBegin.Name = "dateEditBegin";
            this.dateEditBegin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditBegin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEditBegin.Properties.Appearance.Options.UseFont = true;
            this.dateEditBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBegin.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEditBegin.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditBegin.Size = new System.Drawing.Size(126, 26);
            this.dateEditBegin.TabIndex = 1;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl13.Location = new System.Drawing.Point(436, 28);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(16, 19);
            this.labelControl13.TabIndex = 29;
            this.labelControl13.Text = "至";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl14.Location = new System.Drawing.Point(236, 28);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(64, 19);
            this.labelControl14.TabIndex = 30;
            this.labelControl14.Text = "生成时间";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(2, 100);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(955, 613);
            this.gridControl.TabIndex = 33;
            this.gridControl.TabStop = false;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // ExceptionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(957, 714);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.dateEditEnd);
            this.Controls.Add(this.dateEditBegin);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.btnExceptionSearch);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.comboExceptionLx);
            this.Name = "ExceptionSearch";
            this.Text = "异常查询";
            ((System.ComponentModel.ISupportInitialize)(this.comboExceptionLx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExceptionSearch;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.ComboBoxEdit comboExceptionLx;
        private DevExpress.XtraEditors.DateEdit dateEditEnd;
        private DevExpress.XtraEditors.DateEdit dateEditBegin;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    }
}
