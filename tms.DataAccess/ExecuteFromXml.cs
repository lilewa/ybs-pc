using System;
using System.Collections;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using System.Xml;
using System.Collections.Generic;


namespace tms.DataAccess
{
    public class ExecuteFromXml
    {
        public static int ExecuteReturnInt(string spaceAndForm, string funcName, string[] dicParams, out string errMsg)
        {

            Dictionary<string, object> dic = new Dictionary<string, object>();
            if (dicParams != null)
            {
                for (int i = 0; i < dicParams.Length; i++)
                {
                    string[] strToDic = dicParams[i].Split(new char[] { ':' }, 2);
                    dic.Add(strToDic[0], strToDic[1]);
                }
            }
            errMsg = string.Empty;
            int place = spaceAndForm.LastIndexOf('.');

            string location = "/root/" + spaceAndForm.Substring(0, place) + "/" + spaceAndForm.Substring(place + 1) + "/" + funcName;
            XmlNode node = OracleHelper.dataAccessXml.SelectSingleNode(location);

            int paraCount = node.SelectNodes("parameter").Count;//xml中参数个数
            OracleParameter[] oracleParam = { };
            if (paraCount != 0)
            {
                oracleParam = new OracleParameter[paraCount];
            }

            CommandType cmdType = new CommandType();
            string sql = "";//过程名或sql语句
            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                if (node.ChildNodes[i].Name == "parameter")
                {
                    oracleParam[i] = new OracleParameter();
                    OracleType paramType = (OracleType)Enum.Parse(typeof(OracleType), node.ChildNodes[i].Attributes["type"].Value, true);
                    oracleParam[i].OracleType = paramType;
                    oracleParam[i].ParameterName = node.ChildNodes[i].Attributes["name"].Value;
                    if (node.ChildNodes[i].Attributes["direction"].Value == "out")
                    {
                        oracleParam[i].Direction = ParameterDirection.Output;
                        oracleParam[i].Size = 500;
                    }
                    else
                    {
                        if (dic.ContainsKey(oracleParam[i].ParameterName))
                        {
                            oracleParam[i].Value = dic[oracleParam[i].ParameterName];
                        }
                        else
                        {
                            errMsg = "未给出参数" + oracleParam[i].ParameterName + "的值";
                            return 0;
                        }
                    }
                }
                else if (node.ChildNodes[i].Name == "commandType")
                {
                    cmdType = (CommandType)Enum.Parse(typeof(CommandType), node.ChildNodes[i].InnerText, true);

                }
                else
                {
                    sql = node.ChildNodes[i].InnerText;
                }
            }
            try
            {
                int returnVal = OracleHelper.ExecuteNonQuery(cmdType, sql, oracleParam);
                if (cmdType == CommandType.StoredProcedure)
                {
                    if (oracleParam[paraCount - 1].Value.ToString().Trim().ToLower() != "ok")
                    {
                        errMsg = oracleParam[paraCount - 1].Value.ToString();
                        return 0;
                    }
                }
                return returnVal;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            return 0;
        }

        public static DataTable ExecuteReturnTb(string spaceAndForm, string funcName, string[] dicParams, out string selectSql, out string errMsg)
        {
            selectSql = string.Empty;
            Dictionary<string, object> dic = new Dictionary<string, object>();
            //if (!string.IsNullOrEmpty(dicParams))
            //{
            //    string[] jsonParam = dicParams.Split(',');

            //    for (int i = 0; i < jsonParam.Length; i++)
            //    {
            //        string[] strToDic = jsonParam[i].Split(new char[] { ':' }, 2);
            //        dic.Add(strToDic[0], strToDic[1]);
            //    }
            //}
            string v_sql=string.Empty;
            int v_count = 0;
            if (dicParams != null)
            {
                for (int i = 0; i < dicParams.Length; i++)
                {
                    string[] strToDic = dicParams[i].Split(new char[] { ':' }, 2);
                    if (strToDic[1].ToString().Contains("1=1"))
                    {
                        v_sql = v_sql +" and "+ strToDic[1].ToString();
                        v_count = v_count + 1;
                    }
                        dic.Add(strToDic[0], strToDic[1]);

                }
            }
            errMsg = string.Empty;
            int outParaStartIndex = -1; //oracleParam中out参数的其实序号
            int place = spaceAndForm.LastIndexOf('.');

            string location = "/root/" + spaceAndForm.Substring(0, place) + "/" + spaceAndForm.Substring(place + 1) + "/" + funcName;
            XmlNode node = OracleHelper.dataAccessXml.SelectSingleNode(location);

            int paraCount = node.SelectNodes("parameter").Count;//xml中参数个数

            DataTable dt = new DataTable();
            OracleParameter[] oracleParam = { };
            if (paraCount - v_count != 0)
            {
                oracleParam = new OracleParameter[paraCount - v_count];
            }

            CommandType cmdType = new CommandType();
            string sql = "";//过程名或sql语句
            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                //<parameter name="bjlsh" type="Char" direction="in"></parameter> 
                //<commandType>Text</commandType>
                //<sql>update t_dfbj set wcbj='0' where bjlsh=:bjlsh</sql>
                if (node.ChildNodes[i].Name == "parameter" && node.ChildNodes[i].Attributes["name"].Value!="p_sql")
                {
                    oracleParam[i] = new OracleParameter();
                    OracleType paramType = (OracleType)Enum.Parse(typeof(OracleType), node.ChildNodes[i].Attributes["type"].Value, true);
                    oracleParam[i].OracleType = paramType;
                    oracleParam[i].ParameterName = node.ChildNodes[i].Attributes["name"].Value;
                    if (node.ChildNodes[i].Attributes["direction"].Value == "out")
                    {
                        //存储过程多个返回值放到datatable中返回。
                        dt.Columns.Add(node.ChildNodes[i].Attributes["name"].Value);
                        oracleParam[i].Direction = ParameterDirection.Output;
                        oracleParam[i].Size = 500;
                        if (outParaStartIndex == -1)//oracleParam中out参数的其实序号
                        {
                            outParaStartIndex = i;
                        }
                    }
                    else
                    {  
                            oracleParam[i].Value = dic[oracleParam[i].ParameterName];
                    }
                }
                else if (node.ChildNodes[i].Name == "commandType")
                {
                    cmdType = (CommandType)Enum.Parse(typeof(CommandType), node.ChildNodes[i].InnerText, true);

                }
                else if (node.ChildNodes[i].Name == "sql")
                {
                    selectSql= sql = node.ChildNodes[i].InnerText+v_sql;
                }
            }
            try
            {
                if (cmdType == CommandType.StoredProcedure)
                {
                    int returnVal = OracleHelper.ExecuteNonQuery(cmdType, sql, oracleParam);
                    if (oracleParam[paraCount - 1].Value.ToString().Trim().ToLower() != "ok")
                    {
                        errMsg = oracleParam[paraCount - 1].Value.ToString();
                        dt = null;
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = outParaStartIndex; i < oracleParam.Length; i++)
                        {
                            dr[i - outParaStartIndex] = oracleParam[i].Value;
                        }
                        dt.Rows.Add(dr);
                        dt.TableName = "1";
                    }

                }
                else
                {
                    dt = OracleHelper.ExecuteDataset(cmdType, sql, oracleParam).Tables[0];
                }
                return dt;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return null;
            }

        }

        public static string ExecuteTrans(string spaceAndForm, string funcName, string[][] param)
        {
            string errMsg = string.Empty;
            //获取xml文件中的指定节点
            int place = spaceAndForm.LastIndexOf('.');
            string location = "/root/" + spaceAndForm.Substring(0, place) + "/" + spaceAndForm.Substring(place + 1) + "/" + funcName;
            XmlNode node = OracleHelper.dataAccessXml.SelectSingleNode(location);

            // 根据xml准备command
            OracleCommand command = new OracleCommand();


            int paraCount = node.SelectNodes("parameter").Count;//xml中参数个数 
            OracleParameter[] oracleParam = { };
            if (paraCount != 0)
            {
                oracleParam = new OracleParameter[paraCount];
            }

            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                //<parameter name="bjlsh" type="Char" direction="in"></parameter> 
                //<commandType>Text</commandType>
                //<sql>update t_dfbj set wcbj='0' where bjlsh=:bjlsh<l>
                if (node.ChildNodes[i].Name == "parameter")
                {
                    oracleParam[i] = new OracleParameter();
                    OracleType paramType = (OracleType)Enum.Parse(typeof(OracleType), node.ChildNodes[i].Attributes["type"].Value, true);
                    oracleParam[i].OracleType = paramType;
                    oracleParam[i].ParameterName = node.ChildNodes[i].Attributes["name"].Value;
                    if (node.ChildNodes[i].Attributes["direction"].Value == "out")
                    {
                        oracleParam[i].Direction = ParameterDirection.Output;
                        oracleParam[i].Size = 500;
                    }
                    command.Parameters.Add(oracleParam[i]);

                }
                else if (node.ChildNodes[i].Name == "commandType")
                {
                    command.CommandType = (CommandType)Enum.Parse(typeof(CommandType), node.ChildNodes[i].InnerText, true);

                }
                else
                {
                    command.CommandText = node.ChildNodes[i].InnerText;
                }
            }
            using (OracleConnection connection = new OracleConnection(OracleHelper.LocalConnectionString))
            {
                connection.Open();

                OracleTransaction transaction;

                // Start a local transaction
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                // Assign transaction object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {

                    //foreach (string jsonParam in jsonParams)
                    //{
                    //    string[] splitJsonParam = jsonParam.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //    Dictionary<string, object> dic = new Dictionary<string, object>();
                    //    for (int i = 0; i < splitJsonParam.Length; i++)
                    //    {
                    //        string[] strToDic = splitJsonParam[i].Split(new char[] { ':' }, 2);
                    //        dic.Add(strToDic[0], strToDic[1]);
                    //    }
                    //    foreach (OracleParameter p in command.Parameters)
                    //    {
                    //        if (p.Direction != ParameterDirection.Output)
                    //        {
                    //            p.Value = dic[p.ParameterName];
                    //        }
                    //    }
                    //    command.ExecuteNonQuery();
                    //}
                    foreach (string[] jsonParam in param)
                    {
                        Dictionary<string, object> dic = Param2Dic(jsonParam);

                        foreach (OracleParameter p in command.Parameters)
                        {
                            if (p.Direction != ParameterDirection.Output)
                            {
                                p.Value = dic[p.ParameterName];
                            }
                        }
                        command.ExecuteNonQuery();
                        if (command.CommandType == CommandType.StoredProcedure)
                        {

                            if (oracleParam[paraCount - 1].Value.ToString().Trim().ToLower() != "ok")
                            {
                                errMsg = oracleParam[paraCount - 1].Value.ToString();
                                transaction.Rollback();
                                return errMsg;
                            }
                        }
                    }
                    transaction.Commit();
                    return errMsg;

                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return errMsg = e.Message;


                }
            }

        }

       
        public static int ExecuteNonQuery(string sql, out string errMsg)
        {
            try
            {
                errMsg = string.Empty;
                int count = OracleHelper.ExecuteNonQuery(CommandType.Text, sql);
                return count;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return 0;
            }

        }

        public static DataTable ExecuteDataset(string sql, out string errMsg)
        {
            
            try
            {
                errMsg = string.Empty;
                DataTable dt = OracleHelper.ExecuteDataset(CommandType.Text, sql).Tables[0];
                dt.TableName = "1";
                return dt;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return new DataTable() ;
            }

        }

        public static DataTable ExecuteCheckBoxTable(string spaceAndForm, string funcName, string[] dicParams, out string errMsg)
        {

            errMsg = string.Empty;
            Dictionary<string, object> dic = Param2Dic(dicParams);

            XmlNode node = SearchXml(spaceAndForm, funcName);
            if (node == null)
            {
                errMsg = "xml中未找到节点";
                return null;
            }

            XmlNode nodesql = node.SelectSingleNode("sql");
            string sql = nodesql.InnerText;
            int paraCount = dic.Count;//xml中参数个数
            OracleParameter[] oracleParam = new OracleParameter[paraCount];
            int k = 0;
            foreach (string key in dic.Keys)
            {
                XmlNode nodeParam = node.SelectSingleNode("parameter[@name='" + key + "']");
                if (nodeParam == null)
                {
                    errMsg = "xml中未提供" + key;
                    return null;
                }
                sql += nodeParam.Attributes["condition"].Value;

                oracleParam[k] = new OracleParameter();
                OracleType paramType = (OracleType)Enum.Parse(typeof(OracleType), nodeParam.Attributes["type"].Value, true);
                oracleParam[k].OracleType = paramType;
                oracleParam[k].ParameterName = key;
                oracleParam[k].Value = dic[key];
                k++;
            }
            XmlNode lastsql = node.SelectSingleNode("lastsql");
            if (lastsql != null)
            {
                sql = sql + " " + lastsql.InnerText;
            }
            try
            {
                DataTable dt = OracleHelper.CheckBoxTable(sql, oracleParam);
                dt.TableName = "1";
                return dt;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return null;
            }

        }
        public static DataTable SearchTbSqlWhere(string spaceAndForm, string funcName, string sqlWhere, out string errMsg)
        {
            try
            {
                errMsg = string.Empty;
                string sql = "";//过程名或sql语句
                DataTable dt = new DataTable();
                int place = spaceAndForm.LastIndexOf('.');
                //location=/root/JGWL.WindowsForm.WLGoosArrival/Form_Fhmx_Excel/btnReceive
                string location = "/root/" + spaceAndForm.Substring(0, place) + "/" + spaceAndForm.Substring(place + 1) + "/" + funcName;
                XmlNode node = OracleHelper.dataAccessXml.SelectSingleNode(location);
                for (int i = 0; i < node.ChildNodes.Count; i++)
                {
                    if (node.ChildNodes[i].Name == "sql")
                    {
                        sql = node.ChildNodes[i].InnerText + " " + sqlWhere;
                    }
                }
                dt = OracleHelper.ExecuteDataset(CommandType.Text, sql).Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return null;
            }

        }

        public static DataTable ExecuteDynamicSql(string spaceAndForm, string funcName, string[] dicParams, out string errMsg)
        {

            errMsg = string.Empty;
            Dictionary<string, object> dic = Param2Dic(dicParams);

            XmlNode node = SearchXml(spaceAndForm, funcName);
            if (node == null)
            {
                errMsg = "xml中未找到节点";
                return null;
            }

            XmlNode nodesql = node.SelectSingleNode("sql");
            string sql = nodesql.InnerText;
            int paraCount = dic.Count;//xml中参数个数
            OracleParameter[] oracleParam = new OracleParameter[paraCount];
            int k = 0;
            foreach (string key in dic.Keys)
            {
                XmlNode nodeParam = node.SelectSingleNode("parameter[@name='" + key + "']");
                if (nodeParam == null)
                {
                    errMsg = "xml中未提供" + key;
                    return null;
                }
                sql += nodeParam.Attributes["condition"].Value;

                oracleParam[k] = new OracleParameter();
                OracleType paramType = (OracleType)Enum.Parse(typeof(OracleType), nodeParam.Attributes["type"].Value, true);
                oracleParam[k].OracleType = paramType;
                oracleParam[k].ParameterName = key;
                oracleParam[k].Value = dic[key];
                k++;
            }
            XmlNode lastsql = node.SelectSingleNode("lastsql");
            if (lastsql != null)
            {
                sql = sql + " " + lastsql.InnerText;
            }
            try
            {
                DataTable dt = OracleHelper.ExecuteDataset(CommandType.Text, sql, oracleParam).Tables[0];
                dt.TableName = "1";
                return dt;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return null;
            }

        }

        private static XmlNode SearchXml(string spaceAndForm, string funcName)
        {

            int place = spaceAndForm.LastIndexOf('.');
            //location=/root/JGWL.WindowsForm.WLGoosArrival/Form_Fhmx_Excel/btnReceive
            string location = "/root/" + spaceAndForm.Substring(0, place) + "/" + spaceAndForm.Substring(place + 1) + "/" + funcName;
            XmlNode node = OracleHelper.dataAccessXml.SelectSingleNode(location);
            return node;
        }

        private static Dictionary<string, object> Param2Dic(string[] dicParams)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();

            if (dicParams != null)
            {

                for (int i = 0; i < dicParams.Length; i++)
                {
                    string[] strToDic = dicParams[i].Split(new char[] { ':' }, 2);
                    dic.Add(strToDic[0], strToDic[1]);
                }
            }

            return dic;

        }

        public static int ExecuteUpdate(string selectSql, DataTable changedDt, out string errMsg)
        {
            using (OracleConnection connection = new OracleConnection(OracleHelper.LocalConnectionString))
            {
                errMsg = string.Empty;
                OracleDataAdapter myDataAdapter = new OracleDataAdapter();

                myDataAdapter.SelectCommand = new OracleCommand(selectSql, connection);
                OracleCommandBuilder cb = new OracleCommandBuilder(myDataAdapter);
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    myDataAdapter.Fill(dt);

                    //Code to modify data in DataSet goes here... 
                    //Without the OracleCommandBuilder this line would fail.
                    return myDataAdapter.Update(changedDt);
                    // Call the overload that takes a connection in place of the connection string
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                    return -1;
                }
            }

        }


        //public static string BulkInsertTable( string[] columnMappings,DataTable dt)
        //{
        //    string errMsg = string.Empty;

        //    using (Oracle.DataAccess.Client.OracleConnection connection = new Oracle.DataAccess.Client.OracleConnection(OracleHelper.LocalConnectionString))
        //    {
          
        //        try
        //        { 
        //            connection.Open();
        //            Oracle.DataAccess.Client.OracleBulkCopy bc = new Oracle.DataAccess.Client.OracleBulkCopy(connection);
        //            bc.DestinationTableName = dt.TableName; 
        //            for (int i = 0; i < columnMappings.Length; i++)
        //            {
        //                string[] sourceDestination = columnMappings[i].Split(new char[] { ':' }, 2); 
        //                bc.ColumnMappings.Add(sourceDestination[0], sourceDestination[1]);
        //            }
        //            bc.WriteToServer(dt);

        //        }
        //        catch (Exception ex)
        //        {
        //            errMsg = ex.Message;
        //        }
                 
        //    }

        //    return errMsg;

        //}
    }
}
