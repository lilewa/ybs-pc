using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.Xml.Linq;
using System.Xml.XPath;
using tms.WinForm.Common;

namespace tms.WinForm.Sample
{
    public partial class SampleHwManager : BaseForm
    {
   
        DataTable dtSource, dtOrigin;
        string printHw, printDisplayHw;
        Bitmap bitmap;
        PrintingSystem printingSystem = new PrintingSystem();
        Link link;
       // XElement formXml;
        Dictionary<string, List<string>> dictHwLimit;
        public SampleHwManager()
        {
            
            InitializeComponent();
            
            //XElement doc = XElement.Load(Application.StartupPath + "\\Resources\\items.xml");
            //formXml = doc.XPathSelectElement("/" + this.GetType().Namespace + "/" + this.GetType().Name);

            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            SetMaskAndEnable();
            SetFl();
            SetHqqy();
            SetGhdw();
            Inityyyymm();
            InitPrint();
            InitHwLimit();

            AppendKeyDownNoXml(popupContainerAdd.Controls);
            AppendKeyDownNoXml(popupControlSearch.Controls);
        }
        private void SetMaskAndEnable()
        { 
            txtXdBegin.Properties.Mask.EditMask = "[1-9]\\d{0,2}";
            txtXdBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtXdBegin2.Properties.Mask.EditMask = "[1-9]\\d{0,2}";
            txtXdBegin2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtXdEnd.Properties.Mask.EditMask = "[1-9]\\d{0,2}";
            txtXdEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtXdEnd2.Properties.Mask.EditMask = "[1-9]\\d{0,2}";
            txtXdEnd2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtShelfBegin.Properties.Mask.EditMask = "[1-9]\\d?";
            txtShelfBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtShelfBegin2.Properties.Mask.EditMask = "[1-9]\\d?";
            txtShelfBegin2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtShelfEnd.Properties.Mask.EditMask = "[1-9]\\d?";
            txtShelfEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtShelfEnd2.Properties.Mask.EditMask = "[1-9]\\d?";
            txtShelfEnd2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtCengBegin.Properties.Mask.EditMask = "[1-9]\\d?";
            txtCengBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtCengBegin2.Properties.Mask.EditMask = "[1-9]\\d?";
            txtCengBegin2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtCengEnd2.Properties.Mask.EditMask = "[1-9]\\d?";
            txtCengEnd2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtLieBegin.Properties.Mask.EditMask = "[1-9]\\d?";
            txtLieBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtLieBegin2.Properties.Mask.EditMask = "[1-9]\\d?";
            txtLieBegin2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

            txtLieEnd2.Properties.Mask.EditMask = "[1-9]\\d?";
            txtLieEnd2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;

             
            lookUpEditFl.DataBindings.Add("Enabled", ckbFl, "Checked");
            lookUpEditHy.DataBindings.Add("Enabled", ckbGhdw, "Checked"); 
            lookUpEdityyyymm.DataBindings.Add("Enabled", ckbyyyymm, "Checked");
        }

        private void SetFl()
        {
            DataTable dt = service.ExecuteReturnTb("tms.Common.Common", "ybsfl_t_fl", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            repositoryItemLookUpEdit2.DisplayMember = "名称";
            repositoryItemLookUpEdit2.ValueMember = "编号";
            repositoryItemLookUpEdit2.DataSource = dt;
            repositoryItemLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

            lookUpEditFl.Properties.DisplayMember = "名称";
            lookUpEditFl.Properties.ValueMember = "编号";
            lookUpEditFl.Properties.DataSource = dt; 
            lookUpEditFl.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

        }

        private void SetHqqy()
        {
           DataTable  dt = service.ExecuteReturnTb(this.GetType().ToString(), "hqdy", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            lookUpEditHq.Properties.DataSource = dt; 
            lookUpEditHq.Properties.DisplayMember = "名称"; 
            lookUpEditHq.Properties.ValueMember = "编号";
            lookUpEditHq.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

            lookUpEditHq2.Properties.DataSource = dt; 
            lookUpEditHq2.Properties.DisplayMember = "名称"; 
            lookUpEditHq2.Properties.ValueMember = "编号";
            lookUpEditHq2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }

        private void SetGhdw()
        {
            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "t_ghdw", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            repositoryItemLookUpEdit3.DisplayMember = "名称";
            repositoryItemLookUpEdit3.ValueMember = "编号";
            repositoryItemLookUpEdit3.DataSource = dt;
            repositoryItemLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

            lookUpEditHy.Properties.DisplayMember = "名称";
            lookUpEditHy.Properties.ValueMember = "编号";
            lookUpEditHy.Properties.DataSource = dt;  
            lookUpEditHy.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;


        }

        private void Inityyyymm()
        {
            var dataSource = from node in formXml.Element(lookUpEdityyyymm.Name).Elements() select new { 名称 = node.Name.ToString(), 编号 = node.Value };
            lookUpEdityyyymm.Properties.ValueMember = "编号";
            lookUpEdityyyymm.Properties.DisplayMember = "名称";
            lookUpEdityyyymm.Properties.DataSource = dataSource.ToArray();

            
            repositoryItemLookUpEdit1.ValueMember = "编号";
            repositoryItemLookUpEdit1.DisplayMember = "名称";
            repositoryItemLookUpEdit1.DataSource = dataSource.ToArray();
 
          
        }

        private void InitPrint()
        {
            printingSystem = new PrintingSystem();
            link = new Link();
            printingSystem.Links.Add(link);
            bitmap = new Bitmap(barCodeControl1.Width, barCodeControl1.Height);
            link.CreateDetailArea += Link_CreateDetailArea;
        }

        private void InitHwLimit()
        {
            //dictHwLimit = formXml.Element("HwLimit").Elements()
            //     .ToDictionary(el => el.Name.ToString(), el => el.Elements().
            //     Select(child=>child.Name.ToString()).ToList());

            DataTable dt = service.ExecuteReturnTb( this.GetType().ToString(), "T_HQLIMIT", null, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);

                return;
            } 
            dictHwLimit = dt.AsEnumerable().GroupBy(dr => dr.Field<string>("lx_hqdy")).
                ToDictionary(g=>g.Key, g =>g.Select(dr => dr.Field<string>("item")).ToList());

            
        }

        private void Link_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            int y = 0;
            BrickGraphics brickGraphics = e.Graph;
            barCodeControl1.Text = printHw;
            barCodeControl1.DrawToBitmap(bitmap, barCodeControl1.ClientRectangle);
            brickGraphics.DrawImage(bitmap, barCodeControl1.ClientRectangle, BorderSide.None, Color.Transparent);

            y += barCodeControl1.Height;
            TextBrick textBrick = brickGraphics.DrawString(printDisplayHw, Color.Black, new RectangleF(0, y, 130, 15), BorderSide.None);
            textBrick.StringFormat = textBrick.StringFormat.ChangeAlignment(StringAlignment.Center);

            //y += brickGraphics.Font.Height;
            //brickGraphics.DrawString("定价:00", Color.Black, new RectangleF(0, y, 130, 15), BorderSide.None);

        }
        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Columns.GridColumn colDisplayHw = gridView1.Columns.ColumnByFieldName("货位");
            DevExpress.XtraGrid.Columns.GridColumn colHW = gridView1.Columns.ColumnByFieldName("HW");
            foreach (int handle in gridView1.GetSelectedRows())
            {
                  printDisplayHw = gridView1.GetRowCellDisplayText(handle, colDisplayHw).ToString();
                  printHw = gridView1.GetRowCellDisplayText(handle, colHW).ToString();
                //MessageBox.Show("display"+printDisplayHw);
                //MessageBox.Show("hw" + printHw);
                link.Print("");
            } 
        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            gridView1.UpdateCurrentRow();
            DataTable dt = dtSource.GetChanges();
            if (dt == null || dt.Rows.Count == 0)
                return;
            List<string[]> param = new List<string[]>();
            foreach (DataRow dr in dt.Rows)
            {
                //   < parameter name = "p_hw" type = "CHAR" direction = "in" ></ parameter >

                //< parameter name = "p_hqlx" type = "CHAR" direction = "in" ></ parameter >

                //     < parameter name = "p_fl" type = "CHAR" direction = "in" ></ parameter >

                //          < parameter name = "p_ghdw" type = "CHAR" direction = "in" ></ parameter >

                //     < parameter name = "p_yyyymm" type = "NUMBER" direction = "in" ></ parameter >
                // 货源,id_fl 分类,lx 类型,id_span 年月
                string[] singleParam = new string[5];
                singleParam[0] = "p_hw:"+dr["hw"].ToString();
                singleParam[1] = "p_hqlx:" + dr["类型"].ToString();

                bool change=false;
                DataRow[] drOrigin= dtOrigin.Select("hw='"+dr["hw"].ToString()+"'");
                if (drOrigin[0]["分类"].ToString() != dr["分类"].ToString())
                {
                    singleParam[2] = "p_fl:"+ dr["分类"].ToString();
                    change = true;
                }
                else
                {
                    singleParam[2] = "p_fl:nochange";
                }

                if (drOrigin[0]["货源"].ToString() != dr["货源"].ToString())
                {
                    singleParam[3] = "p_ghdw:"+dr["货源"].ToString();
                    change = true;
                }
                else
                {
                    singleParam[3] = "p_ghdw:nochange";
                }

                if (drOrigin[0]["年月"].ToString() != dr["年月"].ToString())
                {
                    singleParam[4] = "p_yyyymm:"+dr["年月"].ToString();
                    change = true;
                }
                else
                {
                    singleParam[4] = "p_yyyymm:nochange";
                }

                if (change)
                { 
                    param.Add(singleParam);
                }
              
            }
            if (param.Count > 0)
            {
                string errMsg = service.ExecuteTrans(this.GetType().ToString(), "PROC_YBS_SETHW", param.ToArray());
                if (!string.IsNullOrWhiteSpace(errMsg))
                {
                    MessageBox.Show(errMsg);
                    return;
                }
            }
            dtSource.AcceptChanges();
            dtOrigin = dtSource.Copy();
            MessageBox.Show("保存成功");
        }



        private void ddbSearch_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>();

            if (!string.IsNullOrWhiteSpace(lookUpEditHq2.EditValue?.ToString()))
            {
                param.Add("p_hqbh:" + lookUpEditHq2.EditValue?.ToString());
            }
            if (!string.IsNullOrWhiteSpace(txtXdBegin2.Text))
            {
                param.Add("p_xdBegin:" + txtXdBegin2.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtXdEnd2.Text))
            {
                param.Add("p_xdEnd:" + txtXdEnd2.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtShelfBegin2.Text))
            {
                param.Add("p_shelfBegin:" + txtShelfBegin2.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtShelfEnd2.Text))
            {
                param.Add("p_shelfEnd:" + txtShelfEnd2.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtCengBegin2.Text))
            {
                param.Add("p_cengBegin:" + txtCengBegin2.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtCengEnd2.Text))
            {
                param.Add("p_cengEnd:" + txtCengEnd2.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtLieBegin2.Text))
            {
                param.Add("p_lieBegin:" + txtLieBegin2.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtLieEnd2.Text))
            {
                param.Add("p_lieEnd:" + txtLieEnd2.Text);
            }
            //if (param.Count == 0)
            //{
            //    MessageBox.Show("请输入查询条件");
            //    return;
            //}

            dtSource= service.ExecuteDynamicSql(this.GetType().ToString(), "SearchHw", param.ToArray(), out errMsg); 
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;

            }
            dtOrigin = dtSource.Copy();
            gridControl1.DataSource = dtSource;
            
        }

        private void ddbAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lookUpEditHq.EditValue?.ToString()))
            {
                MessageBox.Show("请选择货区");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtXdBegin.Text))
            {
                MessageBox.Show("请输入起始巷道");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtXdEnd.Text))
            {
                MessageBox.Show("请输入结束巷道");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtShelfBegin.Text))
            {
                MessageBox.Show("请输入起始货架");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtShelfEnd.Text))
            {
                MessageBox.Show("请输入结束货架");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCengBegin.Text))
            {
                MessageBox.Show("请输入层");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLieBegin.Text))
            {
                MessageBox.Show("请输入列");
                return;
            }

            List<string> param = new List<string>();
            param.Add("p_hqbh:" + lookUpEditHq.EditValue?.ToString());
            param.Add("p_ywbmbh:000001");// + /*lookUpEditHq.GetColumnValue("YWBMBH").ToString()*///);
            param.Add("p_xdbegin:" + txtXdBegin.Text);
            param.Add("p_xdend:" + txtXdEnd.Text);
            param.Add("p_shelfbegin:" + txtShelfBegin.Text);
            param.Add("p_shelfend:" + txtShelfEnd.Text);
            param.Add("p_ceng:" + txtCengBegin.Text);
            param.Add("p_lie:" + txtLieBegin.Text);
            param.Add("p_override:0");

            service.ExecuteReturnInt(this.GetType().ToString(), "PROC_ADDHW_YBS", param.ToArray(), out errMsg);

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            else
            {
                txtCengEnd2.Text = txtCengBegin.Text;
                txtLieEnd2.Text = txtLieBegin.Text;

                txtCengBegin2.Text = "1";
                txtLieBegin2.Text = "1";

                lookUpEditHq2.EditValue = lookUpEditHq.EditValue;
                txtXdBegin2.Text = txtXdBegin.Text;
                txtXdEnd2.Text = txtXdEnd.Text;
                txtShelfBegin2.Text = txtShelfBegin.Text;
                txtShelfEnd2.Text = txtShelfEnd.Text;
                

                ddbSearch_Click(null, null);


            }
        }

        private void ddbAdd_ArrowButtonClick(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCengBegin.Text) || string.IsNullOrWhiteSpace(txtCengBegin.Text))
            {
                   
                txtCengBegin.Text = formXml.Element(txtCengBegin.Name).Value;
                txtLieBegin.Text = formXml.Element(txtLieBegin.Name).Value;
            }
        }

        private void ddbBulk_Click(object sender, EventArgs e)
        {
           
            foreach (int handle in gridView1.GetSelectedRows())
            {
                string lx = gridView1.GetRowCellValue(handle,gridView1.Columns["类型"]).ToString();

                if (ckbFl.Checked)
                {
                    if (dictHwLimit[lx].Contains("分类"))
                    {
                        gridView1.SetRowCellValue(handle, gridView1.Columns["分类"], lookUpEditFl.EditValue);
                    }
                }
                if (ckbGhdw.Checked)
                {
                    if (dictHwLimit[lx].Contains("货源"))
                    {
                        gridView1.SetRowCellValue(handle, gridView1.Columns["货源"], lookUpEditHy.EditValue);
                    }
                }
                if (ckbyyyymm.Checked)
                {
                    if (dictHwLimit[lx].Contains("年月"))
                    {
                        gridView1.SetRowCellValue(handle, gridView1.Columns["年月"], lookUpEdityyyymm.EditValue);
                    }
                }
                
            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            //if (e.Column.FieldName == "分类" || e.Column.FieldName == "货源" || e.Column.FieldName == "年月")
            //{
            //    string lx = gridView1.GetRowCellValue(e.RowHandle, "类型").ToString();

            //    if (!dictHwLimit[lx].Contains(e.Column.FieldName))
            //        e.Appearance.BackColor = Color.LightGray;
            //}
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
          
            string caption = gridView1.FocusedColumn.Caption;
            if (caption == "分类" || caption == "货源" || caption == "年月")
            {
                string lx = gridView1.GetFocusedRowCellValue(gridView1.Columns["类型"]).ToString();

                if (!dictHwLimit[lx].Contains(caption))
                    e.Cancel = true;
            }

        }
    }
}