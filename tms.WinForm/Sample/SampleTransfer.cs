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
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using tms.WinForm.Formatter;
using tms.WinForm.Common;

namespace tms.WinForm.Sample
{
    public partial class SampleTransfer : BaseForm
    {
        
        string rqh;
        string sumNum;
        string[] arrDjh;
        public SampleTransfer()
        {
             
            InitializeComponent();
            GridView view= gridControl1.MainView as GridView;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsBehavior.Editable = false;
            view.BestFitColumns();


            GridColumn colDirection = view.Columns["去向"];
            GridColumn colStatus = view.Columns["状态"];

            colDirection.DisplayFormat.FormatType = FormatType.Custom;
            colDirection.DisplayFormat.FormatString = "DIRECTION";
            colDirection.DisplayFormat.Format = new T_CHECKDETAIL();

            colStatus.DisplayFormat.FormatType = FormatType.Custom;
            colStatus.DisplayFormat.FormatString = "JHFLAG";
            colStatus.DisplayFormat.Format = new T_CHECKDETAIL();


            view.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] {
                 new GridColumnSortInfo(colStatus, ColumnSortOrder.Ascending),
            new GridColumnSortInfo(colDirection, ColumnSortOrder.Ascending) 
            });

           // PopulateDjh(true,null);

        }

        private void PopulateDjh(bool retrieve,string filter)
        {
            if (retrieve)
            {
                DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchRqh", new string[] { "p_djh:" + txtRqh.Text }, out selectSql, out errMsg);
                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg); 
                    return; 
                }
                arrDjh = dt.AsEnumerable().Select(dr => dr.Field<string>(0)).ToArray();
            }
          //  comboDjh.Properties.Items.Clear();
            if (filter != null)
            {
              //  comboDjh.Properties.Items.AddRange(arrDjh);
            }
            else
            {
               // comboDjh.Properties.Items.AddRange(arrDjh.Where(item => item.Contains(filter)).ToArray());
            }
        }

        private void RetrieveDjMx( bool recursion )
        {
            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchDj", new string[] { "p_djh:%" + txtRqh.Text+"%" }, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                txtRqh.Focus();
                txtRqh.SelectAll();
                return;

            }
            string selectDjh = "";
            if (dt.Rows.Count > 1)
            {
                SelectItemWindow form = new SelectItemWindow(dt);
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                selectDjh = form.dic["单据号"];

            }
            else if (dt.Rows.Count == 0)
            {
                if (!recursion)
                {
                    MessageBox.Show("没有这张单据");
                    return;
                }
                dt = service.ExecuteReturnTb(this.GetType().ToString(), "PROC_TRANS_YBSJH3", null, out selectSql, out errMsg);
                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg);
                    txtRqh.Focus();
                    txtRqh.SelectAll();
                    return;
                }

                RetrieveDjMx(false);
            }
            else
            {
                selectDjh = dt.Rows[0]["单据号"].ToString();
            }
            
            Clear();
            RefreshDjMx(selectDjh);

            //GridView view = gridControl1.MainView as GridView;
            //view.Columns["ZT"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            //GridColumnSummaryItem siTotal = new GridColumnSummaryItem();
            //siTotal.SummaryType = SummaryItemType.Count;
            //siTotal.DisplayFormat = "({0} records)";

            //view.Columns["ISBN"].SummaryItem.Collection.Add(siTotal);

            //view.OptionsView.ShowFooter = true;
        }

        private void RefreshDjMx(string djh)
        {

            List<string> param = new List<string>();
            param.Add("p_djh:" + djh);
            param.Add("p_rqh:" + djh);
            param.Add("p_topic:" + (ckbTopic.Checked ? "1" : "0"));
            service.ExecuteReturnInt(this.GetType().ToString(), "PROC_CHANGEDIRECTION", param.ToArray(), out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);

                return;
            }


            DataTable dt = service.ExecuteReturnTb(this.GetType().ToString(), "SearchDjMx", new string[] { "p_djh:" + djh }, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                txtRqh.Focus();
                txtRqh.SelectAll();
                return;
            }
            //if (!arrDjh.Contains(txtRqh.Text))
            //{
            //    PopulateDjh(true, null);
            //}

            rqh = txtRqh.Text = djh;
            gridControl1.DataSource = dt;

            gridView1.FocusedRowHandle = gridView1.RowCount - 1;

             
            txtIsbn.Focus();
            txtIsbn.SelectAll();
        }

        private void txtRqh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter&& !string.IsNullOrWhiteSpace(txtRqh.Text))
            {
                RetrieveDjMx(true); 
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (view.RowCount == 0) return;
            if (e.RowHandle < 0) return;

            string zt = view.GetRowCellDisplayText(e.RowHandle, "状态");
            //  string zt = view.GetRowCellValue(e.RowHandle, "状态").ToString();
            if (zt == "已校核")
            {
                string ps = view.GetRowCellValue(e.RowHandle, "破损").ToString();
                if (ps == "破损")
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
                }
                
            } 
            else
            {
                string direction = view.GetRowCellDisplayText(e.RowHandle, "去向");
                if (direction == "无去向")
                    e.Appearance.BackColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtIsbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtIsbn.Text))
            { 
                if (string.IsNullOrWhiteSpace(rqh))
                {
                    return;
                }
                 
                GridView view = gridControl1.MainView as GridView;
                if (view == null) return;
                if (view.RowCount == 0) return;
              
               int lastJh =-1,rowHandle = 0;
                string sameIsbn = "0";
                bool find = false;
                bool bdirection=false ;
                do
                {
                    rowHandle = view.LocateByDisplayText(rowHandle, view.Columns["ISBN"], txtIsbn.Text);
                    if (rowHandle < 0)
                    {
                        if (find)
                        {
                           
                            view.FocusedRowHandle = lastJh;
                            if (bdirection)
                            {
                                MessageBox.Show("已经校核过了");
                            }
                            else
                            {
                                MessageBox.Show("无去向不能校核");
                            }
                               
                            txtIsbn.Focus();
                            txtIsbn.SelectAll();
                            return;
                        }
                        else
                        {
                            view.FocusedRowHandle = -1;
                            MessageBox.Show("当前书目不在此箱，请重新扫描！");
                            txtIsbn.Focus();
                            txtIsbn.SelectAll();
                            return;
                        }
                       
                    }
                    else
                    {
                        lastJh = rowHandle;
                        find = true;
                        sameIsbn = view.GetRowCellValue(rowHandle, "SAMEISBN").ToString();
                        string direction = view.GetRowCellDisplayText(rowHandle, "去向").ToString();
                        string zt = view.GetRowCellDisplayText(rowHandle, "状态").ToString();
                        if (direction == "无去向")
                        {
                            rowHandle++;
                            bdirection = false;
                            continue;
                        }
                        bdirection = true;
                        if (sameIsbn == "1")
                        {
                            if (zt == "未校核")
                            {
                                break;
                            }
                            else
                            {
                                rowHandle++;
                                continue;
                            }
                        }
                        else
                        {
                            if (zt == "未校核")
                            {
                                break;
                            }
                            else
                            {
                                view.FocusedRowHandle = rowHandle;
                                MessageBox.Show("已经校核过了");
                                txtIsbn.Focus();
                                txtIsbn.SelectAll();
                                return;
                            }
                        } 
                    }

                } while (rowHandle>=0);

                if (sameIsbn == "1")
                {
                    List<string> param1 = new List<string>();
                    param1.Add("p_isbn:" + txtIsbn.Text);
                    param1.Add("p_djh:" + rqh);
                     DataTable dt =  service.ExecuteReturnTb(this.GetType().ToString(), "SearchSameIsbn", param1.ToArray(), out selectSql, out errMsg);
                    if (!string.IsNullOrEmpty(errMsg))
                    {
                        MessageBox.Show(errMsg);
                        txtIsbn.Focus();
                        txtIsbn.SelectAll();
                        return;
                    }
                    // DataRow[] drs= (gridControl1.DataSource as DataTable).Select("isbn='"+ txtIsbn.Text+"' and 状态='0'");
                    //SelectItemWindow form = new SelectItemWindow(drs.CopyToDataTable());
                    SelectItemWindow form = new SelectItemWindow(dt);
                    if (form.ShowDialog() != DialogResult.OK)
                        return;

                    string selectId = form.dic["ID"];
                    rowHandle = view.LocateByDisplayText(0, view.Columns["ID"], selectId);
                }

                view.FocusedRowHandle = rowHandle;

                string sm = view.GetRowCellValue(rowHandle, "书名").ToString();
                string dj = view.GetRowCellValue(rowHandle, "定价").ToString();
                string id= view.GetRowCellValue(rowHandle, "ID").ToString();
                txtSm.Text = sm;
                txtDj.Text = dj;
                 
                List<string> param = new List<string>();
                param.Add("p_id:" + id);
                param.Add("p_djh:" + rqh);
                param.Add("p_ps:" + (ckbPs.Checked?"1":"0"));
                param.Add("p_jhczy:" + UserInfo.userid);
                param.Add("p_jhname:" + UserInfo.username);

                int rows= service.ExecuteReturnInt(this.GetType().ToString(), "UpdateJH", param.ToArray(), out errMsg);
                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg);
                    txtIsbn.Focus();
                    txtIsbn.SelectAll();
                    return;
                }
                if (rows == 0)
                {
                    MessageBox.Show("更新失败");
                    txtIsbn.Focus();
                    txtIsbn.SelectAll();
                    return;
                }
                if (ckbPs.Checked)
                {
                    ckbPs.Checked = false;
                    view.SetRowCellValue(rowHandle, view.Columns["破损"], "破损");
                }
                view.SetRowCellValue(rowHandle, view.Columns["状态"], "已校核");
                txtIsbn.Focus();
                txtIsbn.SelectAll();  
                
                
            }
               
        }

       

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //GridView view = gridControl1.MainView as GridView;
            //string filterString = "[ZT]  Is Null";
            //view.Columns["ZT"].FilterInfo = new ColumnFilterInfo(filterString);
            GridView view = gridControl1.MainView as GridView;
            if (view.RowCount == 0)
                return;

            if (string.IsNullOrWhiteSpace(rqh))
                return;

            int rowHandle = view.LocateByDisplayText(0, view.Columns["去向"], "无去向");
            if (rowHandle >= 0)
            {
                view.FocusedRowHandle = rowHandle;
                DialogResult dlr = MessageBox.Show("无去向的品种无法入库，是否确认？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlr == DialogResult.No) 
                    return;
                 
             
            }

            gridView1.UpdateCurrentRow();

            DataTable dt = gridControl1.DataSource as DataTable;

  
            for(int i= 0;i< dt.Rows.Count;i++)
            {
                if (dt.Rows[i]["去向"].ToString() != "0" && dt.Rows[i]["状态"].ToString() == "0")
                {

                    view.GetRowHandle(i);
                    view.FocusedRowHandle = rowHandle;
                    DialogResult dlr = MessageBox.Show("还有未校核的书是否确认？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dlr == DialogResult.No)
                        return;

                    break;
                }
            }

            //rowHandle = view.LocateByDisplayText(0, view.Columns["状态"], "未校核");
            //if(rowHandle>0)
            //{
            //    view.FocusedRowHandle = rowHandle;
            //  DialogResult dlr=  MessageBox.Show("还有未校核的书是否确认？","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            //  if(dlr==DialogResult.No) 
            //        return;


            //}
            List<string> param = new List<string>();
            param.Add("p_djh:" + rqh);
            param.Add("p_rqh:" + rqh);
            param.Add("p_czybh:" + UserInfo.userid);
            param.Add("p_committype:single");
            param.Add("p_sumnum:0");
            service.ExecuteReturnInt(this.GetType().ToString(), "PROC_JH_YBS", param.ToArray(), out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                
                return;
            }
            gridControl1.DataSource = null;
            rqh = "";
            txtRqh.Text = "";
            Clear();
            txtRqh.Focus();
        }

        private void Clear()
        {
            txtIsbn.Text = "";
            txtDj.Text = "";
            txtSm.Text = "";
            txtTotal.Text = "";
            ckbTopic.Checked = false;
            ckbPs.Checked = false;

        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
           
            string sm = gridView1.GetRowCellValue(e.RowHandle, "书名").ToString();
            string dj = gridView1.GetRowCellValue(e.RowHandle, "定价").ToString();
            txtSm.Text = sm;
            txtDj.Text = dj;
        }
       
        private void ckbTopic_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.LocateByDisplayText(0, gridView1.Columns["状态"], "已校核");
            if (rowHandle >= 0)
            {
                MessageBox.Show("已经开始校核,不能改变去向");
                return;
            }

            DialogResult dlr = MessageBox.Show("是否改变去向?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
            if (dlr == DialogResult.No)
             return;

            ckbTopic.Checked = !ckbTopic.Checked;

            // 专题 ckbTopic.Checked  
            RefreshDjMx(rqh);
        }

        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            GridView view = gridControl1.MainView as GridView;


            if (view.RowCount == 0)
                return;

            DataTable dt= gridControl1.DataSource as DataTable;
                sumNum = dt.AsEnumerable().Where(dr => dr.Field<string>("去向") != "0" && dr.Field<string>("破损") != "破损").
                  Select(dr => dr.Field<decimal>("册数")).Sum().ToString();
            if (txtTotal.Text != sumNum)
            {
                MessageBox.Show("总册数不对");
                return;
            }
             
            List<string> param = new List<string>();
           
            param.Add("p_djh:" + rqh); 
            param.Add("p_jhczy:" + UserInfo.userid);
            param.Add("p_jhname:" + UserInfo.username);
            
            service.ExecuteReturnInt(this.GetType().ToString(), "UpdateJHBulk", param.ToArray(), out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);

                return;
            }
            //  txtRqh_KeyDown(sender, new KeyEventArgs(Keys.Enter));

            DataTable dt2 = service.ExecuteReturnTb(this.GetType().ToString(), "SearchDjMx", new string[] { "p_djh:" + rqh }, out selectSql, out errMsg);
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                txtRqh.Focus();
                txtRqh.SelectAll();
                return;
            } 
            gridControl1.DataSource = dt2;

            gridView1.FocusedRowHandle = gridView1.RowCount - 1;


        }

        private void ckbPs_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
                return;
            //int rowHanlde= gridView1.LocateByDisplayText(0, gridView1.Columns["状态"], "已校核");
            //if (rowHanlde < 0)
            //{
            //    MessageBox.Show("请先撤销已校核的品种");
            //    return;
            //}
            DialogResult dlr = MessageBox.Show("是否改变扫描图书破损标记?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
            if (dlr == DialogResult.No)
                return;

            ckbPs.Checked = !ckbPs.Checked;
        }

      

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo ghi = gridView1.CalcHitInfo(new Point(e.X, e.Y));
                if (!ghi.InRow)  // 判断光标是否在行内  
                    return;
                string zt = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "状态");
                //  string zt = view.GetRowCellValue(e.RowHandle, "状态").ToString();
                if (zt == "未校核")
                    return;

                DialogResult dlr = MessageBox.Show("是否撤销校核？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlr == DialogResult.No)
                    return;

                string id = gridView1.GetFocusedRowCellValue("ID").ToString();
             
                List<string> param = new List<string>();
                param.Add("p_id:" + id);
                param.Add("p_djh:" + rqh);
                
               service.ExecuteReturnInt(this.GetType().ToString(), "CancelJH", param.ToArray(), out errMsg);
                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg);
                     
                }
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["状态"], "未校核");
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["破损"], "正常");
                txtIsbn.Focus();
                txtIsbn.SelectAll();
            }
               
           
        }

        

        //string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        //gridView1.ExportToXlsx(dir+"\\wl.xlsx");


    }
}