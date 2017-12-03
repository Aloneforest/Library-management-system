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
    public class BookAdmin//图书管理类
    {
        //public static string url = "http://119.29.250.249/";
        //public static string url = "http://localhost:54824/";
        //public static string url = "http://localhost:55555/";
        public static string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;
        private static DataTable dt = new DataTable();
        private static string json;
        private static string handlerurl;

        public static DataTable GetBook()
        {
            //return (BookDAL.GetBook());
            handlerurl =
                url + "BookHandler.ashx?falg=0";
            json = HttpHelper.Get(handlerurl);
            dt = Common.JsonHelper.JsonToDataTable(json);
            return dt;
        }

        public static Book GetBook(int ID)
        {
            //return (BookDAL.GetObjectByID(ID));
            handlerurl =
                url + "BookHandler.ashx?flag=1&ID=@ID";

            handlerurl = handlerurl.Replace("@ID", ID.ToString());

            json = HttpHelper.Get(handlerurl);
            Book book = new Book();
            if (json != "")
            {
                dt = Common.JsonHelper.JsonToDataTable(json);
                book = SqlHelper.DataRowToT<Book>(dt.Rows[0]);
            }
            return book;
        }

        public int Insert(Book book)
        {
            //return (BookDAL.Insert(book));
            ChangeString(book, 2);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int Updata(Book book)
        {
            //return (BookDAL.Update(book));
            ChangeString(book, 3);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int Delete(Book book)
        {
            //return (BookDAL.Delete(book));
            ChangeString(book, 4);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public void ChangeString(Book book, int flag)
        {
            handlerurl = url + "BookHandler.ashx?flag=@flag"
                                        +"&ID=@ID"
                                        +"&Name=@Name"
                                        +"&Type=@Type"
                                        +"&Concern=@Concern"
                                        +"&Author=@Author"
                                        +"&Price=@Price"
                                        +"&Time=@Time"
                                        +"&Condition=@Condition";

            handlerurl = handlerurl.Replace("@flag", flag.ToString());
            handlerurl = handlerurl.Replace("@ID", book.ID.ToString());
            handlerurl = handlerurl.Replace("@Name", book.Name.ToString());
            handlerurl = handlerurl.Replace("@Type", book.Type.ToString());
            handlerurl = handlerurl.Replace("@Concern", book.Concern.ToString());
            handlerurl = handlerurl.Replace("@Author", book.Author.ToString());
            handlerurl = handlerurl.Replace("@Price", book.Price.ToString());
            handlerurl = handlerurl.Replace("@Time", book.Time.ToString());
            handlerurl = handlerurl.Replace("@Condition", book.Condition.ToString());
        }
    }
}
