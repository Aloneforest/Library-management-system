using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model_Library_management_system;
using DAL_Library_management_system;

namespace BLL_Library_management_system
{
    public class UserAdmin//读者管理类
    {
        public static User GetUser(int ID)
        {
            return (UserDAL.GetObjectByID(ID));
        }

        public static DataTable GetUser()
        {
            return (UserDAL.GetUser());
        }

        public int Insert(User user)
        {
            return (UserDAL.Insert(user));
        }

        public int Update(User user)
        {
            return (UserDAL.Update(user));
        }
        
        public int Delete(User user)
        {
            return (UserDAL.Delete(user));
        }

        public int UpdatePwd(User userPwd)
        {
            return (UserDAL.UpdatePwd(userPwd));
        }
    }
}
