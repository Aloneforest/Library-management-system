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
    /// UserHandler 的摘要说明
    /// </summary>
    public class UserHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            User user = new User();

            int flag = Convert.ToInt32(context.Request["flag"]);
            user.ID = Convert.ToInt32(context.Request["ID"]);
            user.Name = context.Request["Name"];
            user.Pwd = context.Request["Pwd"];
            user.Sex = context.Request["Sex"];
            user.CertType = context.Request["CertType"];
            user.Cert = context.Request["Cert"];
            user.Phone = context.Request["Phone"];
            user.Type = context.Request["Type"];

            if(flag == 0)
            {
                DataTable GetUser = UserDAL.GetUser();
                string json = Common.JsonHelper.DataSetToJson(GetUser);
                context.Response.Write(json);
            }
            else if(flag == 1)
            {
                DataRow GetUser = UserDAL.GetDRByID(user.ID);
                string json = null;
                if(GetUser != null)
                    json = Common.JsonHelper.DataSetToJson(GetUser.Table);
                context.Response.Write(json);
            }
            else if (flag == 2)
            {
                int Insert = UserDAL.Insert(user);
                context.Response.Write(Insert);
            }
            else if (flag == 3)
            {
                int Update = UserDAL.Update(user);
                context.Response.Write(Update);
            }
            else if (flag == 4)
            {
                int Delete = UserDAL.Delete(user);
                context.Response.Write(Delete);
            }
            else if (flag == 5)
            {
                int UpdatePwd = UserDAL.UpdatePwd(user);
                context.Response.Write(UpdatePwd);
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