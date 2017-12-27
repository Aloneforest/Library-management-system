using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using Model_Library_management_system;
using DAL_Library_management_system;

namespace BLL_Library_management_system
{
    public class BorrowAdmin//借阅管理类
    {
        //public static string url = "http://119.29.250.249/";
        //public static string url = "http://localhost:54824/";
        public static string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;
        private static DataTable dt = new DataTable();
        private static string json;
        private static string handlerurl;

        public static DataTable GetBorrow()
        {
            //return (BorrowDAL.GetBorrow());
            handlerurl =
                url + "BorrowHandler.ashx?falg=0";

            json = HttpHelper.Get(handlerurl);
            if (json != null)
            {
                json = HttpHelper.Get(handlerurl);
                dt = Common.JsonHelper.JsonToDataTable(json);
            }
            return dt;
        }

        public static DataTable GetBorrow(int UID)
        {
            //return (BorrowDAL.Select(UID));
            handlerurl =
                url + "BorrowHandler.ashx?flag=1&UID=@UID";

            handlerurl = handlerurl.Replace("@UID", UID.ToString());

            json = HttpHelper.Get(handlerurl);
            if (json != "")
            {
                json = HttpHelper.Get(handlerurl);
                dt = Common.JsonHelper.JsonToDataTable(json);
            }
            else
                dt = new DataTable();
            return dt;
        }

        public int Insert(Borrow borrow)
        {
            //return (BorrowDAL.Insert(borrow));
            ChangeString(borrow, 2);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int Updata(Borrow borrow)
        {
            //return (BorrowDAL.Update(borrow));
            ChangeString(borrow, 3);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int Delete(Borrow borrow)
        {
            //return (BorrowDAL.Delete(borrow));
            ChangeString(borrow, 4);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public void ChangeString(Borrow borrow, int flag)
        {
            handlerurl = url + @"BorrowHandler.ashx?flag=@flag"
                                                +"&ID=@ID"
                                                +"&UID=@UID"
                                                +"&UName=@UName"
                                                +"&BID=@BID"
                                                +"&BName=@BName"
                                                +"&Borrow_time=@Borrow_time"
                                                +"&Return_time=@Return_time"
                                                +"&Is_return=@Is_return";
            
            handlerurl = handlerurl.Replace("@flag", flag.ToString());
            handlerurl = handlerurl.Replace("@ID", borrow.ID.ToString());
            handlerurl = handlerurl.Replace("@UID", borrow.UID.ToString());
            handlerurl = handlerurl.Replace("@BID", borrow.BID.ToString());
            handlerurl = handlerurl.Replace("@Borrow_time", borrow.Borrow_time.ToString());
            handlerurl = handlerurl.Replace("@Return_time", borrow.Return_time.ToString());
            handlerurl = handlerurl.Replace("@Is_return", borrow.Is_return.ToString());
        }
    }
}
