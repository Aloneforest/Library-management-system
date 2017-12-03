using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using DAL_Library_management_system;
using Model_Library_management_system;

namespace BLL_Library_management_system
{
    public class BookTypeAdmin
    {

        //public static string url = "http://119.29.250.249/";
        //public static string url = "http://localhost:54824/";
        public static string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;
        private static DataTable dt = new DataTable();
        private static string json;
        private static string handlerurl;

        public static DataTable GetBookType()
        {
            //return (BookTypeDAL.GetBookType());
            handlerurl =
                url + "BookTypeHandler.ashx?falg=0";
            json = HttpHelper.Get(handlerurl);
            dt = Common.JsonHelper.JsonToDataTable(json);
            return dt;
        }

        public int Insert(BookType booktype)
        {
            //return (BookTypeDAL.Insert(booktype));
            ChangeString(booktype, 1);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int Updata(BookType booktype)
        {
            //return (BookTypeDAL.Update(booktype));
            ChangeString(booktype, 2);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int Delete(BookType booktype)
        {
            //return (BookTypeDAL.Delete(booktype));
            ChangeString(booktype, 3);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public void ChangeString(BookType booktype, int flag)
        {
            handlerurl = url + "BookTypeHandler.ashx?flag=@flag"
                                                    +"&ID=@ID"
                                                    +"&Name=@Name"
                                                    +"&Day=@Day";
            handlerurl = handlerurl.Replace("@flag", flag.ToString());
            handlerurl = handlerurl.Replace("@ID", booktype.ID.ToString());
            handlerurl = handlerurl.Replace("@Name", booktype.Name.ToString());
            handlerurl = handlerurl.Replace("@Day", booktype.Day.ToString());
        }
    }
}
