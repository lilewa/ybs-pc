using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using tms.WinForm.Common;

namespace tms.WinForm
{
  

    public partial class test3 : BaseForm
    {
        
        List<MyRecord> dataSource = new List<MyRecord>();
        RepositoryItemSpinEdit riSpinEdit = new RepositoryItemSpinEdit();
        RepositoryItemCalcEdit riCalcEdit = new RepositoryItemCalcEdit();
        RepositoryItemTextEdit riTextEdit = new RepositoryItemTextEdit();
        RepositoryItem[] inplaceEditors;

        // In-place editors used in display and edit modes respectively.
        RepositoryItem editorForDisplay, editorForEditing;

        public test3()
        {
            InitializeComponent();
            inplaceEditors = new RepositoryItem[] { riSpinEdit, riTextEdit, riCalcEdit };

            editorForDisplay = new RepositoryItemProgressBar();
            editorForEditing = new RepositoryItemSpinEdit();
            gridView1.GridControl.RepositoryItems.AddRange(
              new RepositoryItem[] { editorForDisplay, editorForEditing });
           
        }

        private void test3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                dataSource.Add(new MyRecord((i + 1) * i, (i + 1) * i + 10, (i + 1) * i + 20));
            gridControl1.DataSource = dataSource;
            ColumnView cv = gridControl1.MainView as ColumnView;
            cv.RowCount.ToString();
            cv.AddNewRow();
          
            //gridControl1.RepositoryItems.Add(riSpinEdit);
            //gridControl1.RepositoryItems.Add(riCalcEdit);
            //gridControl1.RepositoryItems.Add(riTextEdit);

            //GridView gridView1 = gridControl1.MainView as GridView;

            //gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

            //riTextEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //riTextEdit.DisplayFormat.FormatString = "c2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "t_user", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            gridControl1.DataSource = dt;
         
            //RepositoryItemHyperLinkEdit repHyperLink = new RepositoryItemHyperLinkEdit();
            //gridControl1.RepositoryItems.Add(repHyperLink);
            //(gridControl1.MainView as GridView).Columns["KFBH"].ColumnEdit = repHyperLink;
            ////customize the editor
            //repHyperLink.LinkColor = Color.Maroon;
            // repHyperLink.Caption = "Click to e-mail";

            gridView1.Columns["KFBH"].ColumnEdit = editorForDisplay;
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {

        }

        private void gridView1_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            e.PreviewText = "Item: " + e.PreviewText + "; Units: " + view.GetRowCellDisplayText(e.RowHandle,   view.Columns["Column1"]) + ".";
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "KFBH")
                e.RepositoryItem = editorForEditing;
        }
    }

    public class MyRecord
    {
        public MyRecord(int val1, int val2, int val3)
        {
            Column1 = val1;
            Column2 = val2;
            Column3 = val3;
        }
        public int Column1 { get; set; }
        public int Column2 { get; set; }
        public int Column3 { get; set; }
    }
}