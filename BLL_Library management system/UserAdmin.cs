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
    public class UserAdmin//读者管理类
    {
        //public static string url = "http://119.29.250.249/";
        //public static string url = "http://localhost:54824/";
        public static string url = ConfigurationManager.ConnectionStrings["url"].ConnectionString;
        private static DataTable dt = new DataTable();
        private static string json;
        private static string handlerurl;

        public static DataTable GetUser()
        {
            //return (UserDAL.GetUser());
            handlerurl =
                url + "UserHandler.ashx?falg=0";
            json = HttpHelper.Get(handlerurl);
            dt = Common.JsonHelper.JsonToDataTable(json);
            return dt;
        }

        public static User GetUser(int ID)
        {
            //return (UserDAL.GetObjectByID(ID));
            handlerurl =
                url + "UserHandler.ashx?flag=1&ID=@ID";
                
            handlerurl = handlerurl.Replace("@ID", ID.ToString());

            json = HttpHelper.Get(handlerurl);
            if (json != "")
            {
                dt = Common.JsonHelper.JsonToDataTable(json);
                return SqlHelper.DataRowToT<User>(dt.Rows[0]); 
            }
            return null;
        }

        public int Insert(User user)
        {
            //return (UserDAL.Insert(user));
            ChangeString(user, 2);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int Updata(User user)
        {
            //return (UserDAL.Update(user));
            ChangeString(user, 3);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }
        
        public int Delete(User user)
        {
            //return (UserDAL.Delete(user));
            ChangeString(user, 4);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public int UpdatePwd(User userPwd)
        {
            //return (UserDAL.UpdatePwd(userPwd));
            ChangeString(userPwd, 5);
            json = HttpHelper.Get(handlerurl);
            return Convert.ToInt32(json);
        }

        public void ChangeString(User user, int flag)
        {
            handlerurl = url + "UserHandler.ashx?flag=@flag"
                                                +"&ID=@ID"
                                                +"&Name=@Name"
                                                +"&Pwd=@Pwd"
                                                +"&Sex=@Sex"
                                                +"&CertType=@CertType"
                                                +"&Cert=@Cert"
                                                +"&Phone=@Phone"
                                                +"&Type=@Type";
            
            handlerurl = handlerurl.Replace("@flag", flag.ToString());
            handlerurl = handlerurl.Replace("@ID", user.ID.ToString());
            handlerurl = handlerurl.Replace("@Name", user.Name.ToString());
            handlerurl = handlerurl.Replace("@Pwd", user.Pwd.ToString());
            handlerurl = handlerurl.Replace("@Sex", user.Sex.ToString());
            handlerurl = handlerurl.Replace("@CertType", user.CertType.ToString());
            handlerurl = handlerurl.Replace("@Cert", user.Cert.ToString());
            handlerurl = handlerurl.Replace("@Phone", user.Phone.ToString());
            handlerurl = handlerurl.Replace("@Type", user.Type.ToString());
        }
    }
}
