using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model_Library_management_system
{
    [Serializable]
    public class Borrow
    {
        public Borrow() { }
        #region 公有变量
        public int ID { get; set; }
        public int UID { get; set; }
        public string UName { get; set; }
        public int BID { get; set; }
        public string BName { get; set; }
        public DateTime Borrow_time { get; set; }
        public DateTime Return_time { get; set; }
        public byte Is_return { get; set; }
        #endregion

        //添加复制函数
        public Borrow(Borrow rt)
        {
            this.ID = rt.ID;
            this.UID = rt.UID;
            this.UName = rt.UName;
            this.BID = rt.BID;
            this.BName = rt.BName;
            this.Borrow_time = rt.Borrow_time;
            this.Return_time = rt.Return_time;
            this.Is_return = rt.Is_return;
        }

        #region 设置DataGridView 标题
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "ID":          sTitle = "借阅编号"; break;
                case "UID":         sTitle = "用户编号"; break;
                case "UName":       sTitle = "用 户 名"; break;
                case "BID":         sTitle = "图书编号"; break;
                case "BName":       sTitle = "图 书 名"; break;
                case "Borrow_time": sTitle = "开始时间"; break;
                case "Return_time": sTitle = "归还时间"; break;
                case "Is_return":   sTitle = "是否归还"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
