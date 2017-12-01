using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model_Library_management_system;
using DAL_Library_management_system;

namespace BLL_Library_management_system
{
    public class BorrowAdmin//借阅管理类
    {
        public static DataTable GetBorrow()
        {
            return (BorrowDAL.GetBorrow());
        }

        public int Insert(Borrow borrow)
        {
            return (BorrowDAL.Insert(borrow));
        }

        public int Updata(Borrow borrow)
        {
            return (BorrowDAL.Updata(borrow));
        }

        public int Delete(Borrow borrow)
        {
            return (BorrowDAL.Delete(borrow));
        }

        public static DataTable Select(int UID)
        {
            return (BorrowDAL.Select(UID));
        }

    }
}
