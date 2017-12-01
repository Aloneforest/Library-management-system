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
                case "bkID": sTitle = "图书序号"; break;
                case "bkName": sTitle = "图书名称"; break;
                case "bkAuthor": sTitle = "图书作者"; break;
                case "IdContinueTimes": sTitle = "续借次数"; break;
                case "IdDateOut": sTitle = "借书日期"; break;
                case "IdDateRetPlan": sTitle = "应还日期"; break;
                case "IdOverDay": sTitle = "超期天数"; break;
                case "IdOverMoney": sTitle = "超期金额"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
