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
    /// BorrowHandler 的摘要说明
    /// </summary>
    public class BorrowHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            Borrow borrow = new Borrow();

            int flag = Convert.ToInt32(context.Request["flag"]);
            borrow.ID = Convert.ToInt32(context.Request["ID"]);
            borrow.UID = Convert.ToInt32(context.Request["UID"]);
            borrow.BID = Convert.ToInt32(context.Request["BID"]);
            borrow.Borrow_time = Convert.ToDateTime(context.Request["Borrow_time"]);
            borrow.Return_time = Convert.ToDateTime(context.Request["Return_time"]);
            borrow.Is_return = context.Request["Is_return"];

            if (flag == 0)
            {
                DataTable GetBorrow = BorrowDAL.GetBorrow();
                string json = null;
                if (GetBorrow != null)
                    json = Common.JsonHelper.DataSetToJson(GetBorrow);
                context.Response.Write(json);
            }
            else if (flag == 1)
            {
                DataTable GetBorrow = BorrowDAL.Select(borrow.UID);
                string json = null;
                if (GetBorrow != null)
                    json = Common.JsonHelper.DataSetToJson(GetBorrow);
                context.Response.Write(json);
            }
            else if (flag == 2)
            {
                int Insert = BorrowDAL.Insert(borrow);
                context.Response.Write(Insert);
            }
            else if (flag == 3)
            {
                int Update = BorrowDAL.Update(borrow);
                context.Response.Write(Update);
            }
            else if (flag == 4)
            {
                int Delete = BorrowDAL.Delete(borrow);
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