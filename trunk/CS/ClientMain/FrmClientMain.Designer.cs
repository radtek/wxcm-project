namespace ClientMain
{
    partial class FrmClientMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientMain));
            this.timeStatus = new System.Windows.Forms.Timer(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.timeQueue = new System.Windows.Forms.Timer(this.components);
            this.lb_zt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.panelTop = new System.Windows.Forms.Panel();
            this.picToolBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pswIsOverDate = new System.Windows.Forms.Label();
            this.lb_dept = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.frmStatus = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.picToolBar.SuspendLayout();
            this.frmStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeStatus
            // 
            this.timeStatus.Interval = 2000;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 261);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(0, 0);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(748, 48);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 20;
            this.picTitle.TabStop = false;
            // 
            // timeQueue
            // 
            this.timeQueue.Interval = 2000;
            // 
            // lb_zt
            // 
            this.lb_zt.AutoSize = true;
            this.lb_zt.BackColor = System.Drawing.Color.Transparent;
            this.lb_zt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_zt.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_zt.Image = ((System.Drawing.Image)(resources.GetObject("lb_zt.Image")));
            this.lb_zt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lb_zt.Location = new System.Drawing.Point(588, 8);
            this.lb_zt.Name = "lb_zt";
            this.lb_zt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_zt.Size = new System.Drawing.Size(17, 12);
            this.lb_zt.TabIndex = 2;
            this.lb_zt.Text = "zt";
            this.lb_zt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 356);
            this.panel1.TabIndex = 31;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.Controls.Add(this.panelRight);
            this.panelControl.Controls.Add(this.splitter1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 95);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(748, 261);
            this.panelControl.TabIndex = 24;
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(3, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(745, 261);
            this.panelRight.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.navBarControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 259);
            this.panel2.TabIndex = 1;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = null;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(146, 259);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.picToolBar);
            this.panelTop.Controls.Add(this.picTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(748, 95);
            this.panelTop.TabIndex = 23;
            // 
            // picToolBar
            // 
            this.picToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(251)))));
            this.picToolBar.Controls.Add(this.button2);
            this.picToolBar.Controls.Add(this.button1);
            this.picToolBar.Controls.Add(this.pswIsOverDate);
            this.picToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.picToolBar.Location = new System.Drawing.Point(0, 48);
            this.picToolBar.Name = "picToolBar";
            this.picToolBar.Size = new System.Drawing.Size(748, 44);
            this.picToolBar.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Image = global::ClientMain.Properties.Resources.shutdown;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "关闭";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ClientMain.Properties.Resources.userchange;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(59, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "切换";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pswIsOverDate
            // 
            this.pswIsOverDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pswIsOverDate.AutoSize = true;
            this.pswIsOverDate.ForeColor = System.Drawing.Color.Red;
            this.pswIsOverDate.Location = new System.Drawing.Point(150, 16);
            this.pswIsOverDate.Name = "pswIsOverDate";
            this.pswIsOverDate.Size = new System.Drawing.Size(0, 12);
            this.pswIsOverDate.TabIndex = 4;
            // 
            // lb_dept
            // 
            this.lb_dept.AutoSize = true;
            this.lb_dept.BackColor = System.Drawing.Color.Transparent;
            this.lb_dept.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_dept.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_dept.Image = ((System.Drawing.Image)(resources.GetObject("lb_dept.Image")));
            this.lb_dept.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lb_dept.Location = new System.Drawing.Point(364, 8);
            this.lb_dept.Name = "lb_dept";
            this.lb_dept.Size = new System.Drawing.Size(29, 12);
            this.lb_dept.TabIndex = 1;
            this.lb_dept.Text = "dept";
            this.lb_dept.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.BackColor = System.Drawing.Color.Transparent;
            this.lb_user.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_user.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_user.Image = ((System.Drawing.Image)(resources.GetObject("lb_user.Image")));
            this.lb_user.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lb_user.Location = new System.Drawing.Point(204, 8);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(29, 12);
            this.lb_user.TabIndex = 0;
            this.lb_user.Text = "user";
            this.lb_user.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // frmStatus
            // 
            this.frmStatus.BackColor = System.Drawing.SystemColors.Control;
            this.frmStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmStatus.BackgroundImage")));
            this.frmStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmStatus.Controls.Add(this.lb_zt);
            this.frmStatus.Controls.Add(this.lb_dept);
            this.frmStatus.Controls.Add(this.lb_user);
            this.frmStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.frmStatus.Location = new System.Drawing.Point(0, 356);
            this.frmStatus.Name = "frmStatus";
            this.frmStatus.Size = new System.Drawing.Size(748, 33);
            this.frmStatus.TabIndex = 32;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(30, 30);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.frmStatus);
            this.Menu = this.mainMenu1;
            this.Name = "FrmClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "皖新传媒综合信息平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.picToolBar.ResumeLayout(false);
            this.picToolBar.PerformLayout();
            this.frmStatus.ResumeLayout(false);
            this.frmStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timeStatus;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Timer timeQueue;
        private System.Windows.Forms.Label lb_zt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel picToolBar;
        private System.Windows.Forms.Label pswIsOverDate;
        private System.Windows.Forms.Label lb_dept;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Panel frmStatus;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;



    }
}

