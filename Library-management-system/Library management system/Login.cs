using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_Library_management_system;
using BLL_Library_management_system;

namespace Library_management_system
{
    public partial class Login : Form
    {
        public Main main = null;

        private UserAdmin userBLL = new UserAdmin();
        public static User user = null;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(txtUserID.Text.Trim());
            user = UserAdmin.GetUser(ID);

            if (user == null)
            {
                txtUserID.Focus();
                MessageBox.Show("信息：无此用户");
            }
            else
            {
                if (user.Pwd == txtUserPwd.Text)
                {
                    this.DialogResult = DialogResult.OK;//登录成功
                    if (main != null)
                    {
                        main.user = user;
                        main.InitMenu();
                        main.Show();
                    }
                    this.Close();
                }
                else
                {
                    txtUserPwd.Text = "";
                    txtUserPwd.Focus();
                    MessageBox.Show("信息：密码错误！");
                }
            }

            //使用下面方法会导致数据库注入登录，不安全
            //SqlConnection conn = new SqlConnection("server=.; database=bookLibrary; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = string.Format("select count(*) from user where rdid={0} and rdPwd='{1}'", txtUserID.Text, txtUserPwd.Text);
            //int count = Convert.ToInt32(cmd.ExecuteScalar());
            //if (count == 0)
            //{
            //    MessageBox.Show("用户登录失败！");
            //}
            //else
            //{
            //    MessageBox.Show("嘿嘿，登录成功！");
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
