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
    public partial class Main : Form
    {
        private DataTable dt = null;
        public User user = Login.user;//存放读者信息，与读者信息控件组内的各控件进行数据交换，并与BLL、Model层进行数据交换
        private User new_user = new User();
        private UserAdmin userBLL = new UserAdmin();
        private BookType new_booktype = new BookType();
        private BookTypeAdmin booktypeBLL = new BookTypeAdmin();
        private Book new_book = new Book();
        private BookAdmin bookBLL = new BookAdmin();
        private Borrow new_borrow = new Borrow();
        private BorrowAdmin borrowBLL = new BorrowAdmin();

        public Main()
        {
            InitializeComponent();
            InitMenu();
        }

        /// <summary>
        /// 根据用户权限，在frmMain类中初始化菜单。添加InitMenu()方法
        /// </summary>
        public void InitMenu()
        {
            #region 分配权限
            if(!user.IsAdmin())
            {
                tabPage3.Parent = null;
                tabPage4.Parent = null;
            }
            else
            {
                tabPage3.Parent = this.tabControl1;
                tabPage4.Parent = this.tabControl1;
            }
            #endregion

            #region 获取读者信息
            lab1_1.Text = user.ID.ToString();
            lab1_2.Text = user.Name;
            lab1_3.Text = user.Sex;
            lab1_4.Text = user.CertType;
            lab1_5.Text = user.Cert;
            lab1_6.Text = user.Phone;
            #endregion

            tabControl1.SelectedIndex = 0;
            dt = BorrowAdmin.Select(user.ID);
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// 窗口初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
        }

        /// <summary>
        /// tabControl变形
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("微软雅黑",10.0f);
            SolidBrush brush = new SolidBrush(Color.Black);
            RectangleF tabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);
            g.DrawString(tabControl1.Controls[e.Index].Text,font,brush,tabTextArea);
        }

        /// <summary>
        /// 换页刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                dt = BorrowAdmin.Select(user.ID);
                dataGridView1.DataSource = dt;
            }
            else if(this.tabControl1.SelectedIndex == 1)
            {
                BookCatalogUpdate(treeView1);
            }
            else if (this.tabControl1.SelectedIndex == 3)
            {
                BookTypeUpdate();
                BookCatalogUpdate(treeView2);
            }
        }

        private void BookTypeUpdate()
        {
            listBox2.Items.Clear();
            cb4_1.Items.Clear();
            dt = BookTypeAdmin.GetBookType();
            TreeNode[] tn = new TreeNode[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox2.Items.Add(dt.Rows[i][1]);
                cb4_1.Items.Add(dt.Rows[i][1]);
                tn[i] = new TreeNode();
                tn[i].Text = dt.Rows[i][1].ToString();
            }
        }

        private void BookCatalogUpdate(TreeView treeView)
        {
            treeView.Nodes.Clear();

            dt = BookTypeAdmin.GetBookType();
            TreeNode[] tn = new TreeNode[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tn[i] = new TreeNode();
                tn[i].Text = dt.Rows[i][1].ToString();
                treeView.Nodes.Add(tn[i]);
            }

            DataTable dt2 = BookAdmin.GetBook();
            TreeNode[] tn_book = new TreeNode[dt2.Rows.Count];

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dt.Rows[j][0]) == Convert.ToInt32(dt2.Rows[i][2]))
                    {
                        tn_book[i] = new TreeNode();
                        tn_book[i].Text = dt2.Rows[i][1].ToString();
                        tn[j].Nodes.Add(tn_book[i]);
                        break;
                    }
                }
            }
        }

        #region 用户
        private void 修改密码_1_Click(object sender, EventArgs e)
        {
            Pwd form = new Pwd();
            form.main = this;
            form.Show();
            this.Hide();
        }

        private void 注册_5_Click(object sender, EventArgs e)
        {
            if (SetTextToUser())
            {
                userBLL.Insert(new_user);
                dt = UserAdmin.GetUser();
                for (int i = 0; i < dt.Rows.Count; i++ )
                {
                    if(dt.Rows[i][1].ToString() == new_user.Name)
                    MessageBox.Show("状态：注册成功！\n新用户编号为："+dt.Rows[i][0].ToString());
                }
            }
            Clear_5();
        }

        private void 清除_5_Click(object sender, EventArgs e)
        {
            Clear_5();
        }

        private void 注销_5_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(tb5_6.Text.Trim());
            new_user = UserAdmin.GetUser(ID);

            if(new_user == null)
            {
                MessageBox.Show("无此用户！");
                return;
            }

            if (tb5_7.Text != new_user.Pwd)
            {
                MessageBox.Show("密码不正确！");
                return ;
            }

            dt = BorrowAdmin.Select(ID);
            int num = 0;
            for (int i = 0; i < dt.Rows.Count; i++ )
                if (Convert.ToInt32(dt.Rows[i][7]) == 0)
                    num++;
            if (num != 0)
            {
                MessageBox.Show("该用户有未归还的书！");
                return;
            }

            new_borrow.UID = new_user.ID;
            borrowBLL.Delete(new_borrow);
            userBLL.Delete(new_user);
            MessageBox.Show("状态：注销成功！");
            if (ID == user.ID)
            {
                Login form = new Login();
                form.main = this;
                form.Show();
                this.Hide();
                user = null;
            }
        }

        private void Clear_5()
        {
            foreach (Control ctrl in groupBox13.Controls)//清除所有textbox的内容
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }
            cb5_1.SelectedIndex = -1;
            cb5_2.SelectedIndex = -1;
            cb5_3.SelectedIndex = -1;
        }

        private bool SetTextToUser()
        {
            if (tb5_4.Text != tb5_5.Text)
            {
                MessageBox.Show("两次输入密码不一致，请重新输入！");
                return false;
            }
            if (tb5_4.Text == "" || tb5_1.Text == "" || cb5_1.Text == "" || cb5_2.Text == "" ||
                tb5_2.Text == "" || tb5_3.Text == "" || cb5_3.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return false;
            }
            new_user.Pwd = tb5_4.Text;
            new_user.Name = tb5_1.Text;
            new_user.Sex = cb5_1.Text;
            new_user.CertType = cb5_2.Text;
            new_user.Cert = tb5_2.Text;
            new_user.Phone = tb5_3.Text;
            if (cb5_3.Text == "管理员")
                new_user.Type = 0;
            else
                new_user.Type = 1;
            return true;
        }
        #endregion

        #region 图书类型
        private void 添加图书类型_4_Click(object sender, EventArgs e)
        {
            if (tb4_1.Text == "" || tb4_2.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return;
            }
            if (SetTextToBookType())
            {
                dt = BookTypeAdmin.GetBookType();
                for (int i = 0; i < dt.Rows.Count; i++ )
                {
                    if(dt.Rows[i][1].ToString() == new_booktype.Name)
                    {
                        MessageBox.Show("该类型已有");
                        return ;
                    }
                }
                booktypeBLL.Insert(new_booktype);
                MessageBox.Show("状态：添加成功！");
                Clear_44();
            }
            BookTypeUpdate();
            BookCatalogUpdate(treeView2);
        }
        
        private void 更改图书类型_4_Click(object sender, EventArgs e)
        {
            if (tb4_1.Text == "" || tb4_2.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return;
            }
            if (SetTextToBookType())
            {
                booktypeBLL.Update(new_booktype);
                MessageBox.Show("状态：更新成功！");
                Clear_44();
            }
            BookTypeUpdate();
            BookCatalogUpdate(treeView2);
        }

        private void 删除图书类型_4_Click(object sender, EventArgs e)
        {
            if (SetTextToBookType())
            {
                booktypeBLL.Delete(new_booktype);
                MessageBox.Show("状态：删除成功！");
                Clear_44();
            }
            BookTypeUpdate();
            BookCatalogUpdate(treeView2);
        }

        private void Clear_44()
        {
            foreach (Control ctrl in groupBox10.Controls)//清除所有textbox的内容
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }
        }

        private bool SetTextToBookType()
        {
            new_booktype.Name = tb4_1.Text;
            new_booktype.Day = Convert.ToInt32(tb4_2.Text.Trim());

            if (listBox2.SelectedIndex < 0)
                return true;

            string name = listBox2.Items[listBox2.SelectedIndex].ToString();
            name = name.Trim();

            dt = BookTypeAdmin.GetBookType();

            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i][1].ToString() == name)
                    new_booktype.ID = Convert.ToInt32(dt.Rows[i][0].ToString());

            return true;
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < 0)
                return;

            string name = listBox2.Items[listBox2.SelectedIndex].ToString();
            name = name.Trim();

            dt = BookTypeAdmin.GetBookType();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i][1].ToString() == name)
                {
                    tb4_1.Text = dt.Rows[i][1].ToString();
                    tb4_2.Text = dt.Rows[i][2].ToString();
                }
            }
        }
        #endregion

        #region 图书
        private void 添加图书_4_Click(object sender, EventArgs e)
        {
            if (SetTextToBook())
            {
                bookBLL.Insert(new_book);
                MessageBox.Show("状态：添加成功！");
            }
            BookCatalogUpdate(treeView2);
            Clear_4();
        }

        private void 更改图书_4_Click(object sender, EventArgs e)
        {
            if (SetTextToBook())
            {
                bookBLL.Update(new_book);
                MessageBox.Show("状态：更改成功！");
            }
            BookCatalogUpdate(treeView2);
            Clear_4();
        }

        private void 删除图书_4_Click(object sender, EventArgs e)
        {
            if (SetTextToBook())
            {
                bookBLL.Delete(new_book);
                MessageBox.Show("状态：删除成功！");
            }
            BookCatalogUpdate(treeView2);
            Clear_4();
        }

        private void 清除_4_Click(object sender, EventArgs e)
        {
            Clear_4();
        }

        private void Clear_4()
        {
            foreach (Control ctrl in groupBox7.Controls)//清除所有textbox的内容
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }
            cb4_1.SelectedIndex = -1;
            cb4_2.SelectedIndex = -1;
        }

        private bool SetTextToBook()
        {
            if (tb4_3.Text == "" || tb4_4.Text == "" || tb4_5.Text == "" || tb4_6.Text == "" || cb4_1.Text == "" || cb4_2.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return false;
            }
            new_book.Name = tb4_3.Text;
            new_book.Concern = tb4_4.Text;
            new_book.Author = tb4_5.Text;
            new_book.Price = float.Parse(tb4_6.Text);
            new_book.Condition = cb4_2.Text;

            dt = BookTypeAdmin.GetBookType();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cb4_1.Text == dt.Rows[i][1].ToString())
                    new_book.Type = Convert.ToInt32(dt.Rows[i][0]);
            }

            if (treeView2.SelectedNode != null)
            {
                string name = treeView2.SelectedNode.Text.Trim();

                dt = BookAdmin.GetBook();

                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i][1].ToString() == name)
                        new_book.ID = Convert.ToInt32(dt.Rows[i][0].ToString());
            }
            return true;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
                return;

            string name = e.Node.Text.Trim();
            string ID = null;

            dt = BookAdmin.GetBook();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == name)
                {
                    lab2_1.Text = dt.Rows[i][0].ToString();
                    lab2_2.Text = dt.Rows[i][1].ToString();
                    lab2_4.Text = dt.Rows[i][3].ToString();
                    lab2_5.Text = dt.Rows[i][4].ToString();
                    lab2_6.Text = dt.Rows[i][5].ToString();
                    lab2_7.Text = dt.Rows[i][6].ToString();
                    ID = dt.Rows[i][2].ToString();
                }
            }

            dt = BookTypeAdmin.GetBookType();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == ID)
                {
                    lab2_3.Text = dt.Rows[i][1].ToString();
                }
            }
        }

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
                return;

            string name = e.Node.Text.Trim();
            string ID = null;

            dt = BookAdmin.GetBook();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == name)
                {
                    tb4_3.Text = dt.Rows[i][1].ToString();
                    tb4_4.Text = dt.Rows[i][3].ToString();
                    tb4_5.Text = dt.Rows[i][4].ToString();
                    tb4_6.Text = dt.Rows[i][5].ToString();
                    cb4_2.Text = dt.Rows[i][7].ToString();
                    ID = dt.Rows[i][2].ToString();
                }
            }

            dt = BookTypeAdmin.GetBookType();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == ID)
                {
                    cb4_1.Text = dt.Rows[i][1].ToString();
                }
            }
        }
        #endregion

        #region 借阅
        private void 借阅情况_3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            new_user = UserAdmin.GetUser(Convert.ToInt32(tb3_2.Text));
            if(new_user == null)
            {
                MessageBox.Show("该用户不存在");
                return;
            }
            dt = BorrowAdmin.Select(Convert.ToInt32(tb3_2.Text));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i][7]) == 0)
                    listBox1.Items.Add(dt.Rows[i][4]);
            }
        }

        private void 续借_3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请续借注销项");
                return;
            }
            if (SetTextToBorrow())
            {
                borrowBLL.Updata(new_borrow);
                borrowBLL.Insert(new_borrow);
                MessageBox.Show("状态：续借成功！");
            }
        }

        private void 登记_3_Click(object sender, EventArgs e)
        {
            if (tb3_3.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return;
            }

            new_book = BookAdmin.GetBook(Convert.ToInt32(tb3_2.Text));
            if(new_book == null)
            {
                MessageBox.Show("该图书不存在");
                return;
            }

            if (SetTextToBorrow())
            {
                borrowBLL.Insert(new_borrow);
                MessageBox.Show("状态：登记成功！");
            }
            tb3_3.Text = "";
        }

        private void 注销_3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择注销项");
                return;
            }
            if (SetTextToBorrow())
            {
                borrowBLL.Updata(new_borrow);
                MessageBox.Show("状态：注销成功！");
            }
        }

        private bool SetTextToBorrow()
        {
            if (tb3_2.Text == "")
            {
                MessageBox.Show("请输入完整信息");
                return false;
            }
            new_borrow.UID = Convert.ToInt32(tb3_2.Text);
            new_user = UserAdmin.GetUser(new_borrow.UID);
            new_borrow.UName = new_user.Name;

            if (tb3_3.Text != "")
            {
                new_borrow.BID = Convert.ToInt32(tb3_3.Text);
                new_book = BookAdmin.GetBook(new_borrow.BID);
                new_borrow.BName = new_book.Name;
            }

            new_borrow.Borrow_time = DateTime.Now;
            new_borrow.Return_time = DateTime.Now;
            if (listBox1.SelectedItems.Count != 0)
            {
                dt = BorrowAdmin.Select(new_borrow.UID);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][4].ToString() == listBox1.SelectedItems[0].ToString() && Convert.ToInt32(dt.Rows[i][7]) == 0)
                    {
                        if (tb3_3.Text == "")
                        {
                            new_borrow.BID = Convert.ToInt32(dt.Rows[i][3].ToString());
                            new_borrow.BName = listBox1.SelectedItems[0].ToString();
                        }
                        new_borrow.ID = Convert.ToInt32(dt.Rows[i][0].ToString());
                        new_borrow.Is_return = 1;
                        break;
                    }
                }
            }
            return true;
        }
        #endregion

    }
}