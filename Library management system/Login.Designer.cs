namespace Library_management_system
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnGuanBi = new LayeredSkin.Controls.LayeredButton();
            this.btnZuiXiao = new LayeredSkin.Controls.LayeredButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.layeredPictureBox2 = new LayeredSkin.Controls.LayeredPictureBox();
            this.layeredPictureBox1 = new LayeredSkin.Controls.LayeredPictureBox();
            this.layeredLabel2 = new LayeredSkin.Controls.LayeredLabel();
            this.layeredLabel1 = new LayeredSkin.Controls.LayeredLabel();
            this.txtUserPwd = new LayeredSkin.Controls.LayeredTextBox();
            this.txtUserID = new LayeredSkin.Controls.LayeredTextBox();
            this.btnLogin = new LayeredSkin.Controls.LayeredButton();
            this.SuspendLayout();
            // 
            // btnGuanBi
            // 
            this.btnGuanBi.AdaptImage = true;
            this.btnGuanBi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuanBi.BaseColor = System.Drawing.Color.Wheat;
            this.btnGuanBi.Borders.BottomColor = System.Drawing.Color.Empty;
            this.btnGuanBi.Borders.BottomWidth = 1;
            this.btnGuanBi.Borders.LeftColor = System.Drawing.Color.Empty;
            this.btnGuanBi.Borders.LeftWidth = 1;
            this.btnGuanBi.Borders.RightColor = System.Drawing.Color.Empty;
            this.btnGuanBi.Borders.RightWidth = 1;
            this.btnGuanBi.Borders.TopColor = System.Drawing.Color.Empty;
            this.btnGuanBi.Borders.TopWidth = 1;
            this.btnGuanBi.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btnGuanBi.Canvas")));
            this.btnGuanBi.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.btnGuanBi.HaloColor = System.Drawing.Color.White;
            this.btnGuanBi.HaloSize = 5;
            this.btnGuanBi.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnGuanBi.HoverImage")));
            this.btnGuanBi.IsPureColor = false;
            this.btnGuanBi.Location = new System.Drawing.Point(335, 76);
            this.btnGuanBi.Name = "btnGuanBi";
            this.btnGuanBi.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnGuanBi.NormalImage")));
            this.btnGuanBi.PressedImage = null;
            this.btnGuanBi.Radius = 10;
            this.btnGuanBi.ShowBorder = true;
            this.btnGuanBi.Size = new System.Drawing.Size(22, 22);
            this.btnGuanBi.TabIndex = 14;
            this.btnGuanBi.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.btnGuanBi.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnGuanBi.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.btnGuanBi.Click += new System.EventHandler(this.btnGuanBi_Click);
            // 
            // btnZuiXiao
            // 
            this.btnZuiXiao.AdaptImage = true;
            this.btnZuiXiao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZuiXiao.BaseColor = System.Drawing.Color.Wheat;
            this.btnZuiXiao.Borders.BottomColor = System.Drawing.Color.Empty;
            this.btnZuiXiao.Borders.BottomWidth = 1;
            this.btnZuiXiao.Borders.LeftColor = System.Drawing.Color.Empty;
            this.btnZuiXiao.Borders.LeftWidth = 1;
            this.btnZuiXiao.Borders.RightColor = System.Drawing.Color.Empty;
            this.btnZuiXiao.Borders.RightWidth = 1;
            this.btnZuiXiao.Borders.TopColor = System.Drawing.Color.Empty;
            this.btnZuiXiao.Borders.TopWidth = 1;
            this.btnZuiXiao.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btnZuiXiao.Canvas")));
            this.btnZuiXiao.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.btnZuiXiao.HaloColor = System.Drawing.Color.White;
            this.btnZuiXiao.HaloSize = 5;
            this.btnZuiXiao.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnZuiXiao.HoverImage")));
            this.btnZuiXiao.IsPureColor = false;
            this.btnZuiXiao.Location = new System.Drawing.Point(307, 76);
            this.btnZuiXiao.Name = "btnZuiXiao";
            this.btnZuiXiao.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnZuiXiao.NormalImage")));
            this.btnZuiXiao.PressedImage = null;
            this.btnZuiXiao.Radius = 10;
            this.btnZuiXiao.ShowBorder = true;
            this.btnZuiXiao.Size = new System.Drawing.Size(22, 22);
            this.btnZuiXiao.TabIndex = 15;
            this.btnZuiXiao.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.btnZuiXiao.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnZuiXiao.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.btnZuiXiao.Click += new System.EventHandler(this.btnZuiXiao_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // layeredPictureBox2
            // 
            this.layeredPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredPictureBox2.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredPictureBox2.Borders.BottomWidth = 1;
            this.layeredPictureBox2.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredPictureBox2.Borders.LeftWidth = 1;
            this.layeredPictureBox2.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredPictureBox2.Borders.RightWidth = 1;
            this.layeredPictureBox2.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredPictureBox2.Borders.TopWidth = 1;
            this.layeredPictureBox2.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredPictureBox2.Canvas")));
            this.layeredPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("layeredPictureBox2.Image")));
            this.layeredPictureBox2.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(((System.Drawing.Image)(resources.GetObject("layeredPictureBox2.Images")))))};
            this.layeredPictureBox2.Interval = 100;
            this.layeredPictureBox2.Location = new System.Drawing.Point(12, 30);
            this.layeredPictureBox2.MultiImageAnimation = false;
            this.layeredPictureBox2.Name = "layeredPictureBox2";
            this.layeredPictureBox2.Size = new System.Drawing.Size(338, 82);
            this.layeredPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.layeredPictureBox2.TabIndex = 17;
            this.layeredPictureBox2.Text = "layeredPictureBox2";
            this.layeredPictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMoveMouseDown);
            // 
            // layeredPictureBox1
            // 
            this.layeredPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredPictureBox1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredPictureBox1.Borders.BottomWidth = 1;
            this.layeredPictureBox1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredPictureBox1.Borders.LeftWidth = 1;
            this.layeredPictureBox1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredPictureBox1.Borders.RightWidth = 1;
            this.layeredPictureBox1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredPictureBox1.Borders.TopWidth = 1;
            this.layeredPictureBox1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredPictureBox1.Canvas")));
            this.layeredPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("layeredPictureBox1.Image")));
            this.layeredPictureBox1.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(((System.Drawing.Image)(resources.GetObject("layeredPictureBox1.Images")))))};
            this.layeredPictureBox1.Interval = 100;
            this.layeredPictureBox1.Location = new System.Drawing.Point(12, 3);
            this.layeredPictureBox1.MultiImageAnimation = false;
            this.layeredPictureBox1.Name = "layeredPictureBox1";
            this.layeredPictureBox1.Size = new System.Drawing.Size(105, 53);
            this.layeredPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.layeredPictureBox1.TabIndex = 16;
            this.layeredPictureBox1.Text = "layeredPictureBox1";
            // 
            // layeredLabel2
            // 
            this.layeredLabel2.AutoSize = true;
            this.layeredLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel2.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.BottomWidth = 1;
            this.layeredLabel2.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.LeftWidth = 1;
            this.layeredLabel2.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.RightWidth = 1;
            this.layeredLabel2.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.TopWidth = 1;
            this.layeredLabel2.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel2.Canvas")));
            this.layeredLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel2.ForeColor = System.Drawing.Color.White;
            this.layeredLabel2.HaloColor = System.Drawing.Color.DimGray;
            this.layeredLabel2.HaloSize = 5;
            this.layeredLabel2.Location = new System.Drawing.Point(53, 162);
            this.layeredLabel2.Name = "layeredLabel2";
            this.layeredLabel2.Size = new System.Drawing.Size(64, 23);
            this.layeredLabel2.TabIndex = 18;
            this.layeredLabel2.Text = "密码：";
            this.layeredLabel2.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // layeredLabel1
            // 
            this.layeredLabel1.AutoSize = true;
            this.layeredLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.BottomWidth = 1;
            this.layeredLabel1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.LeftWidth = 1;
            this.layeredLabel1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.RightWidth = 1;
            this.layeredLabel1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.TopWidth = 1;
            this.layeredLabel1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel1.Canvas")));
            this.layeredLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel1.ForeColor = System.Drawing.Color.White;
            this.layeredLabel1.HaloColor = System.Drawing.Color.DimGray;
            this.layeredLabel1.HaloSize = 5;
            this.layeredLabel1.Location = new System.Drawing.Point(58, 106);
            this.layeredLabel1.Name = "layeredLabel1";
            this.layeredLabel1.Size = new System.Drawing.Size(64, 23);
            this.layeredLabel1.TabIndex = 19;
            this.layeredLabel1.Text = "账号：";
            this.layeredLabel1.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUserPwd.Borders.BottomColor = System.Drawing.Color.White;
            this.txtUserPwd.Borders.BottomWidth = 1;
            this.txtUserPwd.Borders.LeftColor = System.Drawing.Color.White;
            this.txtUserPwd.Borders.LeftWidth = 1;
            this.txtUserPwd.Borders.RightColor = System.Drawing.Color.White;
            this.txtUserPwd.Borders.RightWidth = 1;
            this.txtUserPwd.Borders.TopColor = System.Drawing.Color.White;
            this.txtUserPwd.Borders.TopWidth = 1;
            this.txtUserPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPwd.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("txtUserPwd.Canvas")));
            this.txtUserPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserPwd.ForeColor = System.Drawing.Color.White;
            this.txtUserPwd.Location = new System.Drawing.Point(57, 188);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '●';
            this.txtUserPwd.Size = new System.Drawing.Size(254, 19);
            this.txtUserPwd.TabIndex = 6;
            this.txtUserPwd.TransparencyKey = System.Drawing.Color.Empty;
            this.txtUserPwd.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserPwd.WaterText = "";
            this.txtUserPwd.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUserID.Borders.BottomColor = System.Drawing.Color.White;
            this.txtUserID.Borders.BottomWidth = 1;
            this.txtUserID.Borders.LeftColor = System.Drawing.Color.White;
            this.txtUserID.Borders.LeftWidth = 1;
            this.txtUserID.Borders.RightColor = System.Drawing.Color.White;
            this.txtUserID.Borders.RightWidth = 1;
            this.txtUserID.Borders.TopColor = System.Drawing.Color.White;
            this.txtUserID.Borders.TopWidth = 1;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("txtUserID.Canvas")));
            this.txtUserID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserID.ForeColor = System.Drawing.Color.White;
            this.txtUserID.Location = new System.Drawing.Point(57, 136);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(254, 19);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.TransparencyKey = System.Drawing.Color.Empty;
            this.txtUserID.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserID.WaterText = "";
            this.txtUserID.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.AdaptImage = true;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.BaseColor = System.Drawing.Color.White;
            this.btnLogin.Borders.BottomColor = System.Drawing.Color.Empty;
            this.btnLogin.Borders.BottomWidth = 1;
            this.btnLogin.Borders.LeftColor = System.Drawing.Color.Empty;
            this.btnLogin.Borders.LeftWidth = 1;
            this.btnLogin.Borders.RightColor = System.Drawing.Color.Empty;
            this.btnLogin.Borders.RightWidth = 1;
            this.btnLogin.Borders.TopColor = System.Drawing.Color.Empty;
            this.btnLogin.Borders.TopWidth = 1;
            this.btnLogin.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btnLogin.Canvas")));
            this.btnLogin.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.HaloColor = System.Drawing.Color.White;
            this.btnLogin.HaloSize = 5;
            this.btnLogin.HoverImage = null;
            this.btnLogin.IsPureColor = false;
            this.btnLogin.Location = new System.Drawing.Point(140, 233);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalImage = null;
            this.btnLogin.PressedImage = null;
            this.btnLogin.Radius = 10;
            this.btnLogin.ShowBorder = true;
            this.btnLogin.Size = new System.Drawing.Size(72, 27);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登录";
            this.btnLogin.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnLogin.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.GradualCurtainEffect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Library_management_system.Properties.Resources.loginbody;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(369, 343);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.layeredLabel2);
            this.Controls.Add(this.layeredLabel1);
            this.Controls.Add(this.btnGuanBi);
            this.Controls.Add(this.btnZuiXiao);
            this.Controls.Add(this.layeredPictureBox2);
            this.Controls.Add(this.layeredPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LayeredSkin.Controls.LayeredButton btnGuanBi;
        private LayeredSkin.Controls.LayeredButton btnZuiXiao;
        private System.Windows.Forms.Timer timer;
        private LayeredSkin.Controls.LayeredPictureBox layeredPictureBox2;
        private LayeredSkin.Controls.LayeredPictureBox layeredPictureBox1;
        private LayeredSkin.Controls.LayeredLabel layeredLabel2;
        private LayeredSkin.Controls.LayeredLabel layeredLabel1;
        private LayeredSkin.Controls.LayeredTextBox txtUserPwd;
        private LayeredSkin.Controls.LayeredTextBox txtUserID;
        private LayeredSkin.Controls.LayeredButton btnLogin;
    }
}