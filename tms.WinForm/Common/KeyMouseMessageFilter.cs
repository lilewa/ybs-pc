using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tms.WinForm.Common
{
    public class KeyMouseMessageFilter : IMessageFilter
    {
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_RBUTTONDOWN = 0x204;
        private const int WM_MBUTTONDOWN = 0x207;
        private const int WM_NCLBUTTONDOWN = 0x0A1;
        private const int WM_NCRBUTTONDOWN = 0x0A4;
        private const int WM_NCMBUTTONDOWN = 0x0A7;


        public delegate void KeyorMousePutHandler();
        public event KeyorMousePutHandler KeyorMousePut ;

        public List<Keys> keys = new List<Keys>();
        public List<MouseButtons> mouseButton = new List<MouseButtons>();
        bool IMessageFilter.PreFilterMessage(ref Message m)
        {

            switch (m.Msg)
            {
              
                case WM_RBUTTONDOWN: 
                case WM_NCRBUTTONDOWN:
                
                    OnKeyorMousePut();  
                    break;
                    
                default:
                    return false;
            }
           
            //不响应
            return true;
        }

        private void OnKeyorMousePut()
        {
            KeyorMousePut?.Invoke();
        }
    }
}
