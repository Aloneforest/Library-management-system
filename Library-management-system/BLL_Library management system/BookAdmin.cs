using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model_Library_management_system;
using DAL_Library_management_system;

namespace BLL_Library_management_system
{
    public class BookAdmin//图书管理类
    {
        public static Book GetBook(int ID)
        {
            return (BookDAL.GetObjectByID(ID));
        }

        public int Insert(Book book)
        {
            return (BookDAL.Insert(book));
        }

        public int Delete(Book book)
        {
            return (BookDAL.Delete(book));
        }

        public int Update(Book book)
        {
            return (BookDAL.Update(book));
        }

        public static DataTable GetBook()
        {
            return (BookDAL.GetBook());
        }
    }
}
