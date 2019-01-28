using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Collections.Concurrent;
using System.Diagnostics;
using DevExpress.Utils;

namespace tms.WinForm.Purchase
{
    public partial class LibraryImport : DevExpress.XtraEditors.XtraForm
    {
        MainWebService.MainWebService service = new MainWebService.MainWebService();
        string errMsg;
        int uploadPart;
        public LibraryImport()
        {
            InitializeComponent();
            listView1.Columns.Add("hao");
        }
      
        private void btnImport_Click(object sender, EventArgs e)
        {

         
           OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "txt files (*.txt)|*.txt";
            if (dlg.ShowDialog() != DialogResult.OK)   
                return;



             uploadPart = 0;
             Stopwatch Watch = new Stopwatch();
            Watch.Start();
             
            List<string[]>list=File.ReadAllLines(dlg.FileName).Select(line => line.Split(',')).ToList();

            //DataTable dtPart = new DataTable();
            //dtPart.TableName = "T_ISBN";
            //dtPart.Columns.Add("isbn");
            //dtPart.Columns.Add("bb");
            //list.ForEach(r => dtPart.Rows.Add(r.Cast<object>().ToArray()));
            //string s = service.BulkInsertTable(new string[] { "isbn:isbn", "bb:bb" }, dtPart);
            progressPanel1.Visible = true;

            listView1.Items.Add(Watch.Elapsed.ToString());
            Task.Factory.StartNew(delegate ()
            {

                int numPart = 50000;
                int taskNum = (int)Math.Ceiling(list.Count / (double)numPart);
                Task[] task = new Task[taskNum];
                try
                {

                    for (int i = 0; i < taskNum; i++)
                    {
                        DataTable dtPart = new DataTable();
                        dtPart.TableName = "T_ISBN";
                        dtPart.Columns.Add("isbn");
                        dtPart.Columns.Add("bb");
                        int k = i;
                        if (i == taskNum - 1)
                        {
                            list.Skip(i * numPart).ToList().ForEach(r => dtPart.Rows.Add(r.Cast<object>().ToArray()));

                        }
                        else
                        {
                            list.Skip(i * numPart).Take(numPart).ToList().ForEach(r => dtPart.Rows.Add(r.Cast<object>().ToArray()));

                        }
                        task[i] = Task.Factory.StartNew(delegate ()
                        {


                            service.BulkInsertTable(new string[] { "isbn:isbn", "bb:bb" }, dtPart);


                           // Thread.Sleep(k * 1000);
                            this.Invoke((MethodInvoker)(() => { uploadPart += 1; progressPanel1.Description = "正在上传" + uploadPart.ToString() + "/" + taskNum.ToString(); }));
                        });

                    }
                }
                catch (AggregateException ex)
                {
                    foreach (Exception innerex in ex.InnerExceptions)
                    {
                        listView1.Items.Add(innerex.Message);
                    }
                }
                Task.WaitAll(task);
                

                this.Invoke((MethodInvoker)(() => { progressPanel1.Visible = false; listView1.Items.Add(Watch.Elapsed.ToString()); }));
                MessageBox.Show("wan");
                Watch.Stop();
            });

            //listView1.Items.Add(Watch.Elapsed.ToString());

        }

      
    }
}