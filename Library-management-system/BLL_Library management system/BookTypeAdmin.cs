using DAL_Library_management_system;
using Model_Library_management_system;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Library_management_system
{
    public class BookTypeAdmin
    {
        public static DataTable GetBookType()
        {
            return (BookTypeDAL.GetBookType());
        }

        public int Insert(BookType booktype)
        {
            return (BookTypeDAL.Insert(booktype));
        }

        public int Update(BookType booktype)
        {
            return (BookTypeDAL.Update(booktype));
        }

        public int Delete(BookType booktype)
        {
            return (BookTypeDAL.Delete(booktype));
        }
    }
}
