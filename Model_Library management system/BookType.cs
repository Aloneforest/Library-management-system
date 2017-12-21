using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Library_management_system
{
    public class BookType
    {
        public BookType() { }
        #region 公有变量
        public int ID { get; set; }
        public string Name { get; set; }
        public int Day { get; set; }
        #endregion

        //添加复制函数
        public BookType(BookType bt)
        {
            this.ID = bt.ID;
            this.Name = bt.Name;
            this.Day = bt.Day;
        }

        #region 设置DataGridView 标题
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "bkID": sTitle = "图书序号"; break;
                case "bkCode": sTitle = "图书编号"; break;
                case "bkName": sTitle = "图书名称"; break;
                case "bkAuthor": sTitle = "图书作者"; break;
                case "bkPress": sTitle = "出版社名"; break;
                case "bkdatePress": sTitle = "出版日期"; break;
                case "bkISBN": sTitle = "标准ISBN"; break;
                case "bkCatalog": sTitle = "名称分类"; break;
                case "bkLanguage": sTitle = "所属语种"; break;
                case "bkPages": sTitle = "图书页数"; break;
                case "bkPrice": sTitle = "图书价格"; break;
                case "bkDateIn": sTitle = "入馆日期"; break;
                case "bkNum": sTitle = "图书本数"; break;
                case "bkBrief": sTitle = "图书封面"; break;
                case "bkCover": sTitle = "图书简介"; break;
                case "bkStatus": sTitle = "图书状态"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
