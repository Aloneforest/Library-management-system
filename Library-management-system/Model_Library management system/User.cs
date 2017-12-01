using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model_Library_management_system
{
    [Serializable]
    public class User
    {
        public User() { }
        #region 公有属性
        public int ID { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public string Sex { get; set; }
        public string CertType { get; set; }
        public string Cert { get; set; }
        public string Phone { get; set; }
        public byte Type { get; set; }
        public Byte[ ] Photo { get; set; }
        #endregion

        public User(User rt)
        {
            this.ID = rt.ID;
            this.Name = rt.Name;
            this.Pwd = rt.Pwd;
            this.Sex = rt.Sex;
            this.CertType = rt.CertType;
            this.Cert = rt.Cert;
            this.Phone = rt.Phone;
            this.Type = rt.Type;
            this.Photo = rt.Photo;
        }

        #region 权限设置
        public bool IsAdmin()
        {
            return (Type == 0);
        }
        public bool IsReader()
        {
            return (Type != 0);
        }
        #endregion

        #region 设置DataGridView 标题
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "ID": sTitle = "借书证号"; break;
                case "Name": sTitle = "姓    名"; break;
                case "Sex": sTitle = "性    别"; break;
                case "Type": sTitle = "读者类别"; break;
                case "Dept": sTitle = "单    位"; break;
                case "Phone": sTitle = "电    话"; break;
                case "Email": sTitle = "邮    箱"; break;
                case "DateReg": sTitle = "办证日期"; break;
                case "Photo":sTitle="照    片";break;
                case "Status":sTitle="证件状态";break;
                case  "BorrowQty":sTitle="已 借 书";break;
                case "Pwd":sTitle="密    码";break;
                case "AdminRoles":sTitle="管理员角色";break;
            }
            return sTitle;
        }
        #endregion
    }
}
