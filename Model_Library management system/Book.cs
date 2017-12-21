using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model_Library_management_system
{
    [Serializable]
    public class Book
    {
        public Book() { }
        #region 公有变量
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Concern { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public int Time { get; set; }
        public string Condition { get; set; }

        #endregion

        //添加复制函数
        public Book(Book rt)
        {
            this.ID = rt.ID;
            this.Name = rt.Name;
            this.Type = rt.Type;
            this.Concern = rt.Concern;
            this.Author = rt.Author;
            this.Price = rt.Price;
            this.Time = rt.Time;
            this.Condition = rt.Condition;
        }

        #region 设置DataGridView 标题
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "ID":          sTitle = "图书序号"; break;
                case "Name":        sTitle = "图 书 名"; break;
                case "Type":        sTitle = "图书类型"; break;
                case "Concern":     sTitle = "出 版 社"; break;
                case "Author":      sTitle = "作    者"; break;
                case "Price":       sTitle = "价    格"; break;
                case "Time":        sTitle = "借阅次数"; break;
                case "Condition":   sTitle = "状    态"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
