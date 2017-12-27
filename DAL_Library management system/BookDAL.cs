using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Model_Library_management_system;

namespace DAL_Library_management_system
{
    public class BookDAL//图书数据访问类
    {
        #region 添加
        public static int Insert(Book book)
        {
            int rows = 0;
            string sql = "insert into tb_book(Name,Type,Concern,Author,Price,Condition) "+
                "values (@Name,@Type,@Concern,@Author,@Price,@Condition)";
            SqlParameter[] parameters ={
                                           new SqlParameter("@Name",book.Name),
                                           new SqlParameter("@Type",book.Type),
                                           new SqlParameter("@Concern",book.Concern),
                                           new SqlParameter("@Author",book.Author),
                                           new SqlParameter("@Price",book.Price),
                                           new SqlParameter("@Condition",book.Condition),
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
        public static int Update(Book book)
        {
            int rows = 0;
            string sql = "update tb_book set Name=@Name,Type=@Type,Concern=@Concern,Author=@Author,"+
                "Price=@Price,Condition=@Condition where ID=@ID";
            SqlParameter[] parameters ={
                                           new SqlParameter("@ID",book.ID),
                                           new SqlParameter("@Name",book.Name),
                                           new SqlParameter("@Type",book.Type),
                                           new SqlParameter("@Concern",book.Concern),
                                           new SqlParameter("@Author",book.Author),
                                           new SqlParameter("@Price",book.Price),
                                           new SqlParameter("@Condition",book.Condition),
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
        public static int Delete(Book book)
        {
            int rows = 0;
            string sql = "delete from tb_book where ID=@ID and Condition='在馆'";
            SqlParameter[] parameters = { new SqlParameter("@ID", book.ID) };
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
        public static DataTable GetBook()
        {
            string sql = "select * from  tb_book";
            return SqlHelper.GetDataTable(sql, null, "tb_book");
        }
        #endregion

        #region 返回图书信息
        public static DataRow GetDRByID(int ID)
        {
            string sql = "select * from tb_book where ID=@ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", ID) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "tb_book");
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

        public static Book GetObjectByID(int ID)
        {
            DataRow dr = GetDRByID(ID);
            return SqlHelper.DataRowToT<Book>(dr);
        }
        #endregion
    }
}
