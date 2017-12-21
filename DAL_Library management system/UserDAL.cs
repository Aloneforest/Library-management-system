using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model_Library_management_system;


namespace DAL_Library_management_system
{
    public class UserDAL//读者数据访问类
    {
        #region 注册
        public static int Insert(User user)
        {
            int rows = 0;
            string sql = @"insert into tb_user values (@Name,@Pwd,@Sex,@CertType,@Cert,@Phone,@Type)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@Name",user.Name),
                                           new SqlParameter("@Pwd",user.Pwd),
                                           new SqlParameter("@Sex",user.Sex),
                                           new SqlParameter("@CertType",user.CertType),
                                           new SqlParameter("@Cert",user.Cert),
                                           new SqlParameter("@Phone",user.Phone),
                                           new SqlParameter("@Type",user.Type),
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        #endregion

        #region 更改
        public static int Update(User user)
        {
            int rows = 0;
            string sql = @"update tb_user set Name=@Name,Sex=@Sex,CertType=@CertType,"
                + "Cert=@Cert,Phone=@Phone,Type=@Type where ID = @ID";            
            SqlParameter[] parameters ={
                                           new SqlParameter("@ID",user.ID),
                                           new SqlParameter("@Name",user.Name),
                                           new SqlParameter("@Sex",user.Sex),
                                           new SqlParameter("@CertType",user.CertType),
                                           new SqlParameter("@Cert",user.Cert),
                                           new SqlParameter("@Phone",user.Phone),
                                           new SqlParameter("@Type",user.Type),
                                           new SqlParameter("@Photo",user.Photo),
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        #endregion

        #region 注销
        public static int Delete(User user)
        {
            int rows = 0;
            string sql = "delete from tb_user where ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", user.ID) };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        #endregion

        #region 查询
        public static DataTable GetUser()
        {
            string sql = "select * from  tb_user";
            return SqlHelper.GetDataTable(sql, null, "tb_user");
        }
        #endregion

        #region 修改密码
        public static int UpdatePwd(User userPwd)
        {
            int rows = 0;
            string sql = "update tb_user set Pwd=@Pwd where ID=@ID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@ID",userPwd.ID),
                                           new SqlParameter("@Pwd",userPwd.Pwd)
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
        #endregion

        #region 返回用户信息
        public static DataRow GetDRByID(int ID)
        {
            string sql = "select * from tb_user where ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", ID) };
            DataTable dt = null;

            dt = SqlHelper.GetDataTable(sql, parameters, "tb_user");

            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
            {
                return dr;
            }
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }

        public static User GetObjectByID(int ID)
        {
            DataRow dr = GetDRByID(ID);
            return SqlHelper.DataRowToT<User>(dr);
        }
        #endregion
    }
}
