using DAL_Library_management_system;
using Model_Library_management_system;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Web_Library_management_system
{
    /// <summary>
    /// BookTypeHandler 的摘要说明
    /// </summary>
    public class BookTypeHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            BookType BookType = new BookType();

            int flag = Convert.ToInt32(context.Request["flag"]);
            BookType.ID = Convert.ToInt32(context.Request["ID"]);
            BookType.Name = context.Request["Name"];
            BookType.Day = Convert.ToInt32(context.Request["Day"]);

            if (flag == 0)
            {
                DataTable GetBookType = BookTypeDAL.GetBookType();
                string json = Common.JsonHelper.DataSetToJson(GetBookType);
                context.Response.Write(json);
            }
            else if (flag == 1)
            {
                int Insert = BookTypeDAL.Insert(BookType);
                context.Response.Write(Insert);
            }
            else if (flag == 2)
            {
                int Update = BookTypeDAL.Update(BookType);
                context.Response.Write(Update);
            }
            else if (flag == 3)
            {
                int Delete = BookTypeDAL.Delete(BookType);
                context.Response.Write(Delete);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}