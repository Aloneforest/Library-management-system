using Model_Library_management_system;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library_management_system
{
    public class BookTypeDAL
    {
        #region 添加
        public static int Insert(BookType booktype)
        {
            int rows = 0;
            string sql = "insert into tb_bookType values (@Name, @Day)";
            
            SqlParameter[] parameters ={
                                           new SqlParameter("@Name",booktype.Name),
                                           new SqlParameter("@Day",booktype.Day),
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

        #region 修改
        public static int Update(BookType booktype)
        {
            int rows = 0;
            string sql = "update tb_bookType set Name=@Name,Day=@Day where ID=@ID";

            SqlParameter[] parameters ={
                                           new SqlParameter("@ID",booktype.ID),
                                           new SqlParameter("@Name",booktype.Name),
                                           new SqlParameter("@Day",booktype.Day),
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

        #region 删除
        public static int Delete(BookType booktype)
        {
            int rows = 0;
            string sql = "exec P_删除图书类型 @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", booktype.ID) };
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
        public static DataTable GetBookType()
        {
            string sql = "select * from  tb_bookType";
            return SqlHelper.GetDataTable(sql, null, "tb_bookType");
        }
        #endregion
    }
}
