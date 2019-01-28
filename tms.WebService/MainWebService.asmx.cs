using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using tms.DataAccess;

namespace JGWL.WebService
{
    /// <summary>
    /// MainWebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class MainWebService : System.Web.Services.WebService
    { 

        [WebMethod(Description = "执行单条insert,delete,update,返回错误信息的存储过程")]
        public int ExecuteReturnInt(string spaceAndForm, string funcName, string[]  dicParams, out string errMsg)
        {

            return ExecuteFromXml.ExecuteReturnInt(spaceAndForm, funcName, dicParams, out   errMsg);
        }

        [WebMethod(Description = "执行单条select,返回多个信息的存储过程")]
        public DataTable ExecuteReturnTb(string spaceAndForm, string funcName, string[]  dicParams, out string selectSql,  out string errMsg)
        {

            return ExecuteFromXml.ExecuteReturnTb(spaceAndForm, funcName, dicParams, out   selectSql, out   errMsg);
        }

         [WebMethod(Description = "执行事务，用字符串数组作为每次调用的参数，调用相同的sql语句或是存储过程")]
        public string ExecuteTrans(string spaceAndForm, string funcName, string[][] param)
        {

            return ExecuteFromXml.ExecuteTrans(spaceAndForm, funcName, param);
        }
         [WebMethod(Description = "动态sql查询")]
         public DataTable ExecuteDynamicSql(string spaceAndForm, string funcName, string[] dicParams, out string errMsg)
         {
             return ExecuteFromXml.ExecuteDynamicSql(spaceAndForm, funcName, dicParams, out   errMsg);
         }

          [WebMethod(Description = "直接执行sql语句 return dt")]
         public DataTable ExecuteDataset(string sql, out string errMsg)
         {
             return ExecuteFromXml.ExecuteDataset(sql, out errMsg);
         }

          //[WebMethod(Description = "根据 sql查询")]
          //public DataTable SearchSql(string sql, out string errMsg)
          //{
          //    errMsg = string.Empty;
          //    try
          //    {
          //        return OracleHelper.ExecuteDataset(CommandType.Text, sql).Tables[0];
          //    }
          //    catch (Exception ex)
          //    {
          //        errMsg = ex.Message;
          //        return null;
          //    }
          //}

          [WebMethod(Description = "haha")]
          public DataTable ExecuteCheckBoxTable(string spaceAndForm, string funcName, string[] dicParams, out string errMsg)
          {
              return ExecuteFromXml.ExecuteCheckBoxTable(spaceAndForm, funcName, dicParams, out   errMsg);
          }

          [WebMethod(Description = "根据输入的条件查询")]
          public DataTable SearchTbSqlWhere(string spaceAndForm, string funcName, string sqlWhere, out string errMsg)
          {
              return ExecuteFromXml.SearchTbSqlWhere(spaceAndForm, funcName, sqlWhere, out errMsg);
          }

          [WebMethod(Description = "执行 ")]
          public int ExecuteUpdate(string selectSql, DataTable changedDt, out string errMsg)
          {
              return ExecuteFromXml.ExecuteUpdate(selectSql, changedDt, out errMsg);
          }

            //[WebMethod(Description = "执行 ")]
            //public string BulkInsertTable(string[] columnMappings, DataTable dt)
            //{
            //  return ExecuteFromXml.BulkInsertTable(columnMappings, dt); 
            //}
    }
}



//[WebMethod(Description = "直接执行sql语句")]
//public int ExecuteNonQuery(string sql, out string errMsg)
//{
//    return ExecuteFromXml.ExecuteNonQuery(sql, out errMsg);
//}
