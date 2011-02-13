using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.Utils;
using DevExpress.Utils.Serializers;
using System.Security.Cryptography;
using System.Data.OracleClient;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.InteropServices;

//using ZQSoft;

namespace ClientMain
{
    public partial class FrmClientMain : Form 
    {
        private DevExpress.XtraNavBar.NavBarControl outlookBar1;
        private ListView listView1 = null;
        //private int unit = 36;

        //private IUpdateServer updateServer;
        private TcpClientChannel tcpChanner = null;

        //private DataSet ds = null;

        OracleConnection Con;
        OracleDataAdapter Adapter;
        DataSet ds;
        //OracleCommandBuilder cb;
        DataTable dt;
        //OracleCommand cmd;

        public FrmClientMain()
        {
            InitializeComponent();
        }

        public FrmClientMain(string strAccount, string strUser, string strDepart)
        {
            InitializeComponent();
            lb_zt.Text = "   帐套：" + strAccount;
            lb_user.Text = "   用户：" + strUser;
            lb_dept.Text = "   部门：" + strDepart;

        }
        private void FrmClientMain_Load(object sender, EventArgs e)
        {
            //            CreateToolBar();//创建outlookbar
            string strCon = "Data Source=XINHUA;User Id=xxb;Password=pass;Integrated Security=no;";
            Con = new OracleConnection(strCon);

            string strSQL = "select * from SYS_MODEL";
            Adapter = new OracleDataAdapter(strSQL, Con);
            //cb = new OracleCommandBuilder(Adapter);

            ds = new DataSet();
            Adapter.Fill(ds, "SYS_MODEL");

            dt = ds.Tables["SYS_MODEL"];

            CreateOutlookBar();
        }

        private void CreateNavGroup(DataView dvRoot)
        {

            foreach (DataRowView theRow in dvRoot)
            {
                NavBarGroup group = new NavBarGroup(theRow.Row["MODELNAME"].ToString());
                group.GroupStyle = NavBarGroupStyle.SmallIconsList;
                group.Name = theRow.Row["ID"].ToString();
                this.outlookBar1.Groups.Add(group);                       
            }

            
        }

        private void CreateNavChild(DataView dvChild, NavBarGroup group)
        {
            dvChild.RowFilter = "PARENTMODEL = '" + group.Name.Trim() + "'";
            foreach (DataRowView theRow in dvChild)
            {
                NavBarItem item = new NavBarItem(theRow.Row["MODELNAME"].ToString());
                item.Name = theRow.Row["MODELNAME"].ToString();
                group.ItemLinks.Add(item);
                this.outlookBar1.Items.Add(item);
            }
        }


        /// <summary>
        /// 生成outlookBar
        /// </summary>
        private void CreateOutlookBar()
        {
            panelLeft.Controls.Clear();
            this.outlookBar1 = new NavBarControl();
            this.outlookBar1.LinkClicked += new NavBarLinkEventHandler(outlookBar1_LinkClicked);
            this.outlookBar1.Dock = DockStyle.Fill;
            this.outlookBar1.Location = new System.Drawing.Point(10, 0);
            this.outlookBar1.Name = "outlookBar1";
            this.outlookBar1.Size = new System.Drawing.Size(200, 350);
            this.outlookBar1.TabIndex = 10;
            this.outlookBar1.Text = "outlookBar1";
            this.panelLeft.Controls.Add(outlookBar1);

            this.outlookBar1.SuspendLayout();
            this.outlookBar1.AllowSelectedLink = true;

            this.outlookBar1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Blue");
            this.outlookBar1.Appearance.GroupHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.outlookBar1.NavigationPaneGroupClientHeight = 200;
            this.outlookBar1.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            //System.Drawing.Image image = null;

            dt.DefaultView.RowFilter = "PARENTMODEL = '0'";
            DataView dvRoot = dt.DefaultView;
            CreateNavGroup(dvRoot);

            dt.DefaultView.RowFilter = null;
            dt.DefaultView.RowFilter = "PARENTMODEL <> '0' ";
            DataView dvChild = dt.DefaultView;

            

            for (int i = 0; i < this.outlookBar1.Groups.Count; i++)
            {                
                CreateNavChild(dvChild, this.outlookBar1.Groups[i]);
            }
            //for (int j = 1; j < 10; j++)
            //{

            //    string text = "功能组"+j.ToString();
                
            //    NavBarGroup group = new NavBarGroup(text);

            //    group.GroupStyle = NavBarGroupStyle.SmallIconsList;

            //    /*构造outlookbar左边工具栏列表*/

            //    for (int jj = 1; jj < 8; jj++)
            //    {

            //        string detailID = "aa" + jj.ToString();


            //        string childText = "功能" + jj.ToString();

            //        NavBarItem item = new NavBarItem(childText);

            //        string img = "config";
            //        //if (img == "" || img == null)
            //        //    img = "1";
            //        image = GetOutLookImage(img);

            //        //NavBarItem item = new NavBarItem(childText);
            //        item.SmallImage = image.GetThumbnailImage(20, 20, null, IntPtr.Zero);

            //        item.Tag = detailID;


            //        group.ItemLinks.Add(item);
            //        this.outlookBar1.Items.Add(item);
            //    }

            //    this.outlookBar1.Groups.Add(group);


            //}
            this.outlookBar1.ResumeLayout(false);

        }

        void outlookBar1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           
            //            MessageBox.Show(string.Format("The {0} link has been clicked", e.Link.Caption));

            NavBarItem item = e.Link.Item;
            if (item.Name == "部门管理")
            {
                FrmDeptMt DeptMt = new FrmDeptMt();
                DeptMt.ShowDialog();
            }

            if (item.Name == "员工管理")
            {
                FrmStaffMt StaffMt = new FrmStaffMt();
                StaffMt.ShowDialog();
            }

            if (item.Name == "角色管理")
            {
                rolemanger RoleMt = new rolemanger();
                RoleMt.ShowDialog();
            }

            if (item.Name == "用户管理")
            {
                UserManger UserMt = new UserManger();
                UserMt.ShowDialog();
            }
            //if (item.Name == "主界面")
            //{
            //    listView1.Hide();
            //}
            //else
            //{
            //    if (listView1 == null || !panelRight.Controls.Contains(listView1))
            //    {
            //                           InitImageList();

            //        listView1 = new ListView();
            //        listView1.DoubleClick += new EventHandler(listView1_DoubleClick);
            //        listView1.KeyDown += new KeyEventHandler(listView1_KeyDown);
            //        listView1.View = View.LargeIcon;
            //        listView1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            //        listView1.BorderStyle = BorderStyle.None;
            //        listView1.LargeImageList = imageList1;
            //        listView1.SmallImageList = imageList2;
            //        listView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            //        listView1.Scrollable = true;

            //        listView1.Columns.Add("名称", 300, HorizontalAlignment.Left);
            //        listView1.Columns.Add("说明", 500, HorizontalAlignment.Left);

            //        listView1.Left = 10;
            //        listView1.Top = this.unit;
            //        listView1.Height = this.panelRight.Height;
            //        listView1.Width = this.panelRight.Width;
            //        this.panelRight.Controls.Add(listView1);
            //        listView1.BringToFront();
            //        string itemtext = "功能1";
            //        ListViewItem item1 = new ListViewItem("功能1");
            //        item1.ImageIndex = 1;
            //        item1.Tag = "1";
            //        listView1.Items.Add(item1);

            //        itemtext = "功能2";
            //        ListViewItem item2 = new ListViewItem("功能2");
            //        item2.ImageIndex = 2;
            //        item2.Tag = "2";
            //        listView1.Items.Add(item2);

            //        //                    BuildListView(item.Tag.ToString());
            //        //                    this.listView1.ContextMenu = null;
            //    }
            //    else
            //    {
            //        //                    listView1.Items.Clear();
            //        listView1.BringToFront();
            //        listView1.Show();
            //        //                    BuildListView(item.Tag.ToString());
            //    }
            //}

        }

        private void InitImageList()
        {
            int fsCount = System.IO.Directory.GetFiles(@"icon/ListViewIcon", "*.ico").Length;

            Icon img = null;
            imageList1.ImageSize = new Size(32, 32);
            imageList2.ImageSize = new Size(16, 16);
            for (int i = 0; i < fsCount; i++)
            {
                img = GetlistViewImage(i.ToString());
                imageList1.Images.Add(img);
                imageList2.Images.Add(img);
            }
        }


        private void frmStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string GetMd5Str(string ConvertString)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)));
            t2 = t2.Replace("-", "");
            return t2;
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
//            MessageBox.Show(string.Format("The {0} link has been clicked", listView1.FocusedItem.Tag));

//            MessageBox.Show(string.Format("The {0} link has been clicked", GetMd5Str("hcz2322679")));

            //string url = @"tcp://192.168.8.158:8086/UpdateServer";
 
            this.tcpChanner = new TcpClientChannel();
            //ChannelServices.RegisterChannel(this.tcpChanner, false);
            //this.updateServer = (IUpdateServer)Activator.GetObject(typeof(IUpdateServer), url);

            //string commandText = "select * from jt_j_fxfl";
            //this.ds = this.updateServer.ExecuteDataset(commandText);

            //string bb = updateServer.ExecuteDataset1(commandText);


            //MessageBox.Show(string.Format("The {0} link has been clicked", bb));

            //essageBox.Show(string.Format("The {0} link has been clicked", this.ds.DataSetName));
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(string.Format("The {0} link has been KeyDown", listView1.FocusedItem.Tag));
            }
        }

        public static System.Drawing.Image GetOutLookImage(string ImgName)
        {
            try
            {
                Icon ic;
                string fs = Application.StartupPath + @"/icon/OutLookBarIcon/" + ImgName + ".ico";
                if (System.IO.File.Exists(fs))
                    ic = new Icon(fs);
                else
                    ic = new Icon(Application.StartupPath + @"/icon/OutLookBarIcon/default.ico");
                return ic.ToBitmap();
            }
            catch { }
            return null;
        }

        public static System.Drawing.Icon GetlistViewImage(string ImgName)
        {
            try
            {
                Icon ic;
                string fs = Application.StartupPath + @"/icon/ListViewIcon/" + ImgName + ".ico";
                if (System.IO.File.Exists(fs))
                    ic = new Icon(fs);
                else
                    ic = new Icon(Application.StartupPath + @"/icon/ListViewIcon/1.ico");
                return ic;
            }
            catch { }
            return null;
        }


        /// <summary>
        /// 生成主界面的工具栏
        /// </summary>
//        private void CreateToolBar()
//        {
//            /*添加outlookbar*/
//            panelLeft.Controls.Clear();
//            this.outlookBar1 = new NavBarControl();
////            this.outlookBar1.LinkClicked += new NavBarLinkEventHandler(outlookBar1_LinkClicked);
//            this.outlookBar1.Dock = DockStyle.Fill;
//            this.outlookBar1.Location = new System.Drawing.Point(10, 0);
//            this.outlookBar1.Name = "outlookBar1";
//            this.outlookBar1.Size = new System.Drawing.Size(200, 350);
//            this.outlookBar1.TabIndex = 10;
//            this.outlookBar1.Text = "outlookBar1";
//            this.panelLeft.Controls.Add(outlookBar1);

//            /*添加工具栏*/
//            //picToolBar.SuspendLayout();          
//            picToolBar.Controls.Clear();
//            this.picToolBar.Controls.Add(this.pswIsOverDate);
//            this.picToolBar.Controls.Add(this.label1);
//            this.picToolBar.Controls.Add(this.btnRefresh);
//            this.picToolBar.Controls.Add(this.cboTime);
//            ZQFrmToolbar toolBar = new ZQFrmToolbar();
//            picToolBar.Controls.Add(toolBar);
//            //	toolBar.Visible = false; 
//            //toolBar.ButtonClick +=new ToolBarButtonClickEventHandler(ToolBarEventHandler);
//            toolBar.BackColor = this.picToolBar.BackColor;
//            toolBar.RenderMode = ToolStripRenderMode.Professional;
//            ZQToolBarButton button_Exit = new ZQToolBarButton();
//            button_Exit.Name = "Exit";
//            button_Exit.Text = "退出";
//            button_Exit.ShortKey = Keys.Q;
//            button_Exit.Image = CommonClass.GetToolBarImage("exit");
//            button_Exit.TextImageRelation = TextImageRelation.ImageAboveText;
//            button_Exit.Click += new EventHandler(button_Exit_Click);
//            button_Exit.ImageScaling = ToolStripItemImageScaling.None;
//            toolBar.Items.Add(button_Exit);

//            ZQToolBarButton button_ReLogin = new ZQToolBarButton();
//            button_ReLogin.Name = "reLogin";
//            button_ReLogin.Text = "重新登录";
//            button_ReLogin.Image = CommonClass.GetToolBarImage("LogOff");
//            button_ReLogin.TextImageRelation = TextImageRelation.ImageAboveText;
//            button_ReLogin.Click += new EventHandler(button_ReLogin_Click);
//            button_ReLogin.ImageScaling = ToolStripItemImageScaling.None;
//            toolBar.Items.Add(button_ReLogin);

//            ZQToolBarButton button_Main = new ZQToolBarButton();
//            button_Main.Text = "主界面";
//            button_Main.Name = "Main";
//            button_Main.Image = CommonClass.GetToolBarImage("firstPage");
//            button_Main.TextImageRelation = TextImageRelation.ImageAboveText;
//            button_Main.ImageScaling = ToolStripItemImageScaling.None;
//            button_Main.Click += new EventHandler(button_Main_Click);
//            toolBar.Items.Add(button_Main);

//            ToolStripDropDownButton button_List = new ToolStripDropDownButton();
//            button_List.Text = "列表";
//            button_List.Name = "list";
//            button_List.Image = CommonClass.GetToolBarImage("listview");
//            button_List.ImageScaling = ToolStripItemImageScaling.None;
//            button_List.TextImageRelation = TextImageRelation.ImageAboveText;


//            //ContextMenu listMenu = new ContextMenu();
//            //barItem.Style = ToolBarButtonStyle.DropDownButton;
//            ToolStripMenuItem menuItem_Big = new ToolStripMenuItem("大图标", null, new EventHandler(this.WindowBarMenuEventHandler));
//            menuItem_Big.Name = "large";
//            menuItem_Big.Checked = true;
//            //menuItem_Big.Text = "大图标";            
//            //listMenu.MenuItems.Add(menuItem);
//            button_List.DropDownItems.Add(menuItem_Big);
//            menuItem_Big.CheckOnClick = true;

//            ToolStripMenuItem menuItem_Tail = new ToolStripMenuItem("详细资料", null, new EventHandler(this.WindowBarMenuEventHandler));
//            //menuItem_Tail.Text = "详细资料";
//            menuItem_Tail.Name = "detail";
//            button_ReLogin.TextImageRelation = TextImageRelation.ImageAboveText;
//            button_List.DropDownItems.Add(menuItem_Tail);
//            menuItem_Tail.CheckOnClick = true;

//            ToolStripMenuItem menuItem_List = new ToolStripMenuItem("列表", null, new EventHandler(this.WindowBarMenuEventHandler));
//            // menuItem_List.Text = "列表";
//            menuItem_List.Name = "list";
//            button_ReLogin.TextImageRelation = TextImageRelation.ImageAboveText;
//            //listMenu.MenuItems.Add(menuItem);
//            //barItem.DropDownMenu = listMenu;
//            button_List.DropDownItems.Add(menuItem_List);
//            toolBar.Items.Add(button_List);


//            #region 短信功能
//            //added by wy 091225
//            ToolStripDropDownButton button_List1 = new ToolStripDropDownButton();
//            button_List1.Text = "短信服务";
//            button_List1.Name = "SMlist";
//            button_List1.Image = CommonClass.GetToolBarImage("shortmsg");
//            button_List1.ImageScaling = ToolStripItemImageScaling.None;
//            button_List1.TextImageRelation = TextImageRelation.ImageAboveText;
//            button_List1.Visible = false;

//            ToolStripMenuItem menuItem_EditMsg = new ToolStripMenuItem("编辑短信", null, new EventHandler(this.WindowBarMenuEventHandler));
//            menuItem_EditMsg.Name = "editmsg";
//            button_List1.DropDownItems.Add(menuItem_EditMsg);
//            ToolStripMenuItem menuItem_PhoneBook = new ToolStripMenuItem("通讯录", null, new EventHandler(this.WindowBarMenuEventHandler));
//            menuItem_PhoneBook.Name = "phoneNoBook";
//            button_List1.DropDownItems.Add(menuItem_PhoneBook);
//            ToolStripMenuItem menuItem_manageMsg = new ToolStripMenuItem("短信管理", null, new EventHandler(this.WindowBarMenuEventHandler));
//            menuItem_manageMsg.Name = "manageMsg";
//            button_List1.DropDownItems.Add(menuItem_manageMsg);
//            ToolStripMenuItem menuItem_option = new ToolStripMenuItem("选项", null, new EventHandler(this.WindowBarMenuEventHandler));
//            menuItem_option.Name = "msgoption";
//            button_List1.DropDownItems.Add(menuItem_option);
//            toolBar.Items.Add(button_List1);
//            #endregion

//            menuItem_List.CheckOnClick = true;
//            windowBar = new ZQToolBarButton();
//            windowBar.Text = "窗体";
//            windowBar.ShortKey = Keys.W;
//            windowBar.Name = "Windows";
//            //windowBar.Style = ToolBarButtonStyle.DropDownButton;
//            windowBar.Image = CommonClass.GetToolBarImage("windows");
//            ContextMenu windowMenu = new ContextMenu();
//            //windowBar.DropDownMenu = windowMenu;
//            //toolBar.Buttons.Add(windowBar);

//            ZQToolBarButton button_Help = new ZQToolBarButton();
//            button_Help.Name = "Help";
//            button_Help.Text = "联机帮助";
//            button_Help.ShortKey = Keys.Q;
//            button_Help.Image = CommonClass.GetToolBarImage("Help");
//            button_Help.TextImageRelation = TextImageRelation.ImageAboveText;
//            button_Help.Click += new EventHandler(button_Help_Click);
//            button_Help.ImageScaling = ToolStripItemImageScaling.None;
//            toolBar.Items.Add(button_Help);

//            ZQToolBarButton barItem_Help = new ZQToolBarButton();
//            barItem_Help.Name = "About";
//            barItem_Help.Text = "关于";
//            barItem_Help.ShortKey = Keys.A;
//            barItem_Help.TextImageRelation = TextImageRelation.ImageAboveText;
//            barItem_Help.Image = CommonClass.GetToolBarImage("help");
//            barItem_Help.ImageScaling = ToolStripItemImageScaling.None;
//            barItem_Help.Click += new EventHandler(barItem_Help_Click);
//            toolBar.Items.Add(barItem_Help);
//            //toolBar.Buttons.Add(barItem);


//            //			toolBar.Visible = true;
//            //			picToolBar.ResumeLayout(false);
//            //			outlookBar1.Visible = true;
//        }

    }
}
