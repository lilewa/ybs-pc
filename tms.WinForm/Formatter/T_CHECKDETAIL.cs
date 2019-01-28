using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tms.WinForm.Formatter
{
    public class T_CHECKDETAIL : IFormatProvider, ICustomFormatter
    { 
        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            
            string formatValue = arg.ToString();
            if (format == "JHFLAG")
            {
                if (formatValue == "0")
                {
                    return "未校核";
                }
                else if (formatValue == "1")
                {
                    return "已校核";
                }
              
            }
            else if (format == "DIRECTION")
            {
                if (formatValue == "0")
                {
                    return "无去向";
                }
                else if (formatValue == "1")
                {
                    return "本版区";
                }
                else if (formatValue == "2")
                {
                    return "外版区";
                }
                else if (formatValue == "3")
                {
                    return "专题区";
                }
                
            }
            return formatValue;
            
            //else
            //{
            //    return formatValue;
            //}

        }
    }
}
