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
                case "ID": sTitle = "图书序号"; break;
                case "Code": sTitle = "图书编号"; break;
                case "Name": sTitle = "图书名称"; break;
                case "Author": sTitle = "图书作者"; break;
                case "Press": sTitle = "出版社名"; break;
                case "datePress": sTitle = "出版日期"; break;
                case "ISBN": sTitle = "标准ISBN"; break;
                case "Catalog": sTitle = "名称分类"; break;
                case "Language": sTitle = "所属语种"; break;
                case "Pages": sTitle = "图书页数"; break;
                case "Price": sTitle = "图书价格"; break;
                case "DateIn": sTitle = "入馆日期"; break;
                case "Num": sTitle = "图书本数"; break;
                case "Brief": sTitle = "图书封面"; break;
                case "Cover": sTitle = "图书简介"; break;
                case "Status": sTitle = "图书状态"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
