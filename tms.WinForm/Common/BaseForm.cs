using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Collections;

namespace tms.WinForm.Common
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {

        protected MainWebService.MainWebService service;
        protected string errMsg;
        protected string selectSql;
        protected  XElement formXml;
        public BaseForm()
        {
            InitializeComponent();
            service = new MainWebService.MainWebService();

            if(CommonUse.xmlAppSet!=null)
            formXml = CommonUse.xmlAppSet.XPathSelectElement("/" + this.GetType().Namespace + "/" + this.GetType().Name);


        }

        protected virtual void AppendKeyDown(IEnumerable ctls)
        {
            XElement xel = formXml.Element("TabIndex");
            if (xel == null)
                return;

          var  tabindex = xel.Elements().Select((el, index) => new { Name = el.Name, Index = index }).
                ToDictionary(el => el.Name.ToString(), el => el.Index);
            foreach (Control ctl in ctls)
            {
                if (tabindex.ContainsKey(ctl.Name))
                {
                    ctl.TabIndex = tabindex[ctl.Name];
                }
                else
                {
                    ctl.TabIndex = 99;
                }
                ctl.Tag = false;
                ctl.KeyDown += Enter_KeyDown;
            }
        }

        protected virtual void AppendKeyDownNoXml(IEnumerable ctls)
        { 
            foreach (Control ctl in ctls)
            {
                if (ctl is BaseEdit || ctl is BaseButton)
                {
                    ctl.KeyDown += Enter_KeyDown;
                    ctl.Tag = false;
                }   
            }
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            bool cancel = (bool)((Control)sender).Tag;

            if (!cancel)
                SendKeys.Send("{Tab}");
        }

        protected virtual void PopulateComboBox(IEnumerable ctls)
        {
            if (formXml == null)
                return;
            foreach (Control ctl in  ctls)
            {
                ComboBoxEdit combobox = ctl as ComboBoxEdit;
                if (combobox == null)
                    continue;

                if (formXml.Element(combobox.Name) == null)
                    return;

                var dataSource = from node in formXml.
                        Element(combobox.Name).Elements()
                                 select new ComboBoxItem4Dev
                                 { name = node.Name.ToString(), id = node.Value };
                combobox.Properties.Items.AddRange(dataSource.ToArray());
                combobox.SelectedIndex = 0;

            }
        }
    }

   
}