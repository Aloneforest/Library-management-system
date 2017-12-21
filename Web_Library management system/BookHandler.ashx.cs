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
    /// BookHandler 的摘要说明
    /// </summary>
    public class BookHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            Book book = new Book();

            int flag = Convert.ToInt32(context.Request["flag"]);
            book.ID = Convert.ToInt32(context.Request["ID"]);
            book.Name = context.Request["Name"];
            book.Type = Convert.ToInt32(context.Request["Type"]);
            book.Concern = context.Request["Concern"];
            book.Author = context.Request["Author"];
            book.Price = Convert.ToSingle(context.Request["Price"]);
            book.Time = Convert.ToInt32(context.Request["Time"]);
            book.Condition = context.Request["Condition"];

            if (flag == 0)
            {
                DataTable GetBook = BookDAL.GetBook();
                string json = Common.JsonHelper.DataSetToJson(GetBook);
                context.Response.Write(json);
            }
            else if (flag == 1)
            {
                DataRow GetBook = BookDAL.GetDRByID(book.ID);
                string json = null;
                if (GetBook != null)
                    json = Common.JsonHelper.DataSetToJson(GetBook.Table);
                context.Response.Write(json);
            }
            else if (flag == 2)
            {
                int Insert = BookDAL.Insert(book);
                context.Response.Write(Insert);
            }
            else if (flag == 3)
            {
                int Update = BookDAL.Update(book);
                context.Response.Write(Update);
            }
            else if (flag == 4)
            {
                int Delete = BookDAL.Delete(book);
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