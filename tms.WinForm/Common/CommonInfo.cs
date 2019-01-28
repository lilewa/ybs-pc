using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace tms.WinForm
{
    public class UserInfo
    {
       public static string userid;
       public static string username;
       public static string ywbmbh;
        public static UserType type; //0:
    }

    public enum UserType
    {
       local,
       customer
    }

    public class CommonUse
    {
        public static XElement xmlAppSet;
        public static string connectionstring;
    }
}
