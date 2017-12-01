using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Model_Library_management_system;

namespace DAL_Library_management_system
{
    public class BorrowDAL//借阅数据表访问类
    {
        #region 登记
        public static int Insert(Borrow borrow)
        {
            int rows = 0;
            string sql = "insert into tb_bookBorrow(UID,UName,BID,BName,Borrow_time) values(@UID,@UName,@BID,@BName,@Borrow_time)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@ID",borrow.ID),
                                           new SqlParameter("@UID",borrow.UID),
                                           new SqlParameter("@UName",borrow.UName),
                                           new SqlParameter("@BID",borrow.BID),
                                           new SqlParameter("@BName",borrow.BName),
                                           new SqlParameter("@Borrow_time",borrow.Borrow_time),
                                           new SqlParameter("@Return_time",borrow.Return_time),
                                           new SqlParameter("@Is_return",borrow.Is_return),
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
        public static int Updata(Borrow borrow)
        {
            int rows = 0;
            string sql = "update tb_bookBorrow set Return_time=@Return_time,Is_return=@Is_return where ID=@ID;";
            SqlParameter[] parameters ={
                                           new SqlParameter("@ID",borrow.ID),
                                           new SqlParameter("@Return_time",borrow.Return_time),
                                           new SqlParameter("@Is_return",borrow.Is_return),
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
        public static int Delete(Borrow borrow)
        {
            int rows = 0;
            string sql = "delete from tb_bookBorrow where UID = @UID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@UID",borrow.UID),
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

        #region 查询个人借阅情况
        public static DataTable Select(int UID)
        {
            string sql = "select * from tb_bookBorrow where UID = @UID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@UID",UID),
                                      };
            return SqlHelper.GetDataTable(sql, parameters, "tb_bookBorrow");
        }
        #endregion

        #region 查询
        public static DataTable GetBorrow()
        {
            string sql = "select * from  tb_bookBorrow";
            return SqlHelper.GetDataTable(sql, null, "tb_bookBorrow");
        }
        #endregion
    }
}