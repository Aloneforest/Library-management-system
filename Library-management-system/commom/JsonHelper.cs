using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

namespace Common
{
    public class JsonHelper
    {
        public static string DataSetToJson(DataTable dt)
        {
            string json = string.Empty;
            try
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    return "";
                }
                json = "{";
                json += "'table" + 1 + "':[";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    json += "{";
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        json += "'" + dt.Columns[j].ColumnName + "':'" + dt.Rows[i][j].ToString() + "'";
                        if (j != dt.Columns.Count - 1)
                        {
                            json += ",";
                        }
                    }
                    json += "}";
                    if (i != dt.Rows.Count - 1)
                    {
                        json += ",";
                    }
                }
                json += "]";
                json += "}";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return json;
        }

        public static DataTable JsonToDataTable(string strJson)
        {
            //转换json格式
            strJson = strJson.Replace(",\"", "*\"").Replace("\":", "\"#").ToString();
            //取出表名   
            var rg = new Regex(@"(?<={)[^:]+(?=:\[)", RegexOptions.IgnoreCase);
            string strName = rg.Match(strJson).Value;
            DataTable tb = null;
            //去除表名   
            strJson = strJson.Substring(strJson.IndexOf("[") + 1);
            strJson = strJson.Substring(0, strJson.IndexOf("]"));

            //获取数据   
            rg = new Regex(@"(?<={)[^}]+(?=})");
            MatchCollection mc = rg.Matches(strJson);
            for (int i = 0; i < mc.Count; i++)
            {
                string strRow = mc[i].Value;
                //string[] strRows = strRow.Split('*');
                string[] strRows = strRow.Split(',');

                //创建表   
                if (tb == null)
                {
                    tb = new DataTable();
                    tb.TableName = strName.Replace("'", "");
                    foreach (string str in strRows)
                    {
                        var dc = new DataColumn();
                        //string[] strCell = str.Split('#');
                        string[] strCell = str.Split(':');
                        if (strCell[0].Substring(0, 1) == "\"")
                        {
                            int a = strCell[0].Length;
                            dc.ColumnName = strCell[0].Substring(1, a - 2);
                        }
                        else
                        {
                            dc.ColumnName = strCell[0].Replace("'", ""); ;
                        }
                        tb.Columns.Add(dc);
                    }
                    tb.AcceptChanges();
                }

                //增加内容   
                DataRow dr = tb.NewRow();
                for (int r = 0; r < strRows.Length; r++)
                {
                    dr[r] = strRows[r].Split(':')[1].Trim().Replace("，", ",").Replace("：", ":").Replace("'", "");
                }
                tb.Rows.Add(dr);
                tb.AcceptChanges();
            }

            return tb;
        }

    }
}
