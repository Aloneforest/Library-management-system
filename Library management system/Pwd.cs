using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_Library_management_system;
using BLL_Library_management_system;
using LayeredSkin.Forms;

namespace Library_management_system
{
    public partial class Pwd : LayeredForm
    {
        public Main main = null;

        private User user = Login.user;
        private UserAdmin userBLL = new UserAdmin();

        public Pwd()
        {
            InitializeComponent();
        }

        private void btnGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZuiXiao_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim() == "")
            {
                MessageBox.Show("旧密码不能为空");
                return;
            }
            else if (txtOldPwd.Text.Trim() != user.Pwd)
            {
                MessageBox.Show("密码不正确");
                return;
            }
            else
            {
                if (txtNewPwd.Text.Trim() == "")
                {
                    MessageBox.Show("请输入新密码！");
                    return;
                }
                else
                {
                    if (txtNewPwd.Text.Trim() != txtConfirmPwd.Text.Trim())
                    {
                        MessageBox.Show("两次输入密码不一致，请重新输入！");
                        return;
                    }
                    else
                    {
                        user.Pwd = txtConfirmPwd.Text.Trim();
                        userBLL.UpdatePwd(user);
                        MessageBox.Show("密码修改成功！");
                    }
                }
            }
            Login form = new Login();
            form.main = main;
            form.Show();
            this.Close();
            form.main.user = null;
        }
    }
}
