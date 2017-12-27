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
using LayeredSkin.Forms;

namespace Library_management_system
{
    public partial class Login : LayeredForm
    {
        public Main main = null;
        public bool blCanLogin = false;

        private UserAdmin userBLL = new UserAdmin();
        public static User user = null;

        Image Cloud = Image.FromFile("Images\\cloud.png");
        float cloudX = 0;
        Image yezi;
        float angle = 10;
        bool RotationDirection = true;//是否为顺时针

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ID;
            if (txtUserID.Text == "")
            {
                MessageBox.Show("请输入账号");
                return;
            }
            if (txtUserPwd.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
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
                    blCanLogin = true;
                    //this.DialogResult = DialogResult.OK;
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
        }

        private void btnGuanBi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZuiXiao_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMoveMouseDown(object sender, MouseEventArgs e)
        {
            LayeredSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Animation.Effect = new LayeredSkin.Animations.GradualCurtainEffect() { ChangeHeight = 25 };

            yezi = new Bitmap(90, 80);//先把叶子画在稍微大一点txtUserPwd画布上，这样叶子旋转txtUserPwd时候才不会被裁掉一部分
            using (Graphics g = Graphics.FromImage(yezi))
            {
                g.DrawImage(Image.FromFile("Images\\yezi3.png"), 10, 0);
            }
            timer.Start();
        }

        protected override void OnLayeredPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (cloudX > this.Width - Cloud.Width)
            {//云的飘动
                cloudX = 0;
            }
            else
            {
                cloudX += 0.5f;
            }
            g.DrawImage(Cloud, cloudX, 0);//把云绘制上去

            if (angle > 10)
            {//控制旋转方向
                RotationDirection = false;
            }
            if (angle < -10)
            {
                RotationDirection = true;
            }
            if (RotationDirection)
            {
                angle += 1;
            }
            else
            {
                angle -= 1;
            }
            using (Image temp = LayeredSkin.ImageEffects.RotateImage(yezi, angle, new Point(25, 3)))
            {
                g.DrawImage(temp, 140, 70);//绘制叶子
            }
            base.OnLayeredPaint(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LayeredPaint();
            GC.Collect();
        }
    }
}
