using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
//using DevExpress.Utils;
//using DevExpress.Utils.Serializers;
using System.Security.Cryptography;
using System.Data.OracleClient;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.InteropServices;

//using ZQSoft;

namespace ClientMain
{
    public partial class FrmClientMain : DevExpress.XtraEditors.XtraForm
    {
        //private DevExpress.XtraNavBar.NavBarControl outlookBar1;
        //private int unit = 36;

        //private IUpdateServer updateServer;
        //private TcpClientChannel tcpChanner = null;

        //private DataSet ds = null;

        OracleConnection Con;
        OracleDataAdapter Adapter;
        OracleDataAdapter adaRight;
        DataSet ds;
        DataSet dsRight;
        //OracleCommandBuilder cb;
        DataTable dt;
        //OracleCommand cmd;
        string m_strName;
        string m_strDeptID;
        string m_strDeptName;
        string m_strZTID; 
        
        public FrmClientMain()
        {
            InitializeComponent();
        }

        public FrmClientMain(string strAccount, string strUser, string strDeptName, string strDeptID, string strZTID)
        {
            InitializeComponent();
            lb_zt.Text = "   帐套：" + strAccount;
            lb_user.Text = "   用户：" + strUser;
            lb_dept.Text = "   部门：" + strDeptName;

            m_strDeptID = strDeptID;
            m_strDeptName = strDeptName;
            m_strName = strUser;
            m_strZTID = strZTID;

        }
        private void FrmClientMain_Load(object sender, EventArgs e)
        {
            //            CreateToolBar();//创建outlookbar

            Con = new OracleConnection(FrmLogin.strCon);

            string strSQL = "select a.id, a.modelname, a.PARENTMODEL from sys_model a where a.id in (select b.module_id from sys_role_module b where b.role_id in (select c.roleid from sys_user_role c  where c.username = '" + m_strName + "' and c.deptid = '"+ m_strDeptID + "')) order by a.model_sortno";
            Adapter = new OracleDataAdapter(strSQL, Con);
            //cb = new OracleCommandBuilder(Adapter);

            
            ds = new DataSet();
            Adapter.Fill(ds, "SYS_MODEL");

            dt = ds.Tables["SYS_MODEL"];

            CreateOutlookBar();
        }

        private void DBSelect(string ModelID, out string strDBType, out string strServer, out string strDbName, out string strUser, out string strPass)
        {
            strDBType = null;
            strServer = null;
            strDbName = null;
            strUser = null;
            strPass = null;

            string strSqlDbSelect = "select b.dbtype, b.server, b.dbname, b.username, b.password from base_zt_db b "
                                  + "where b.systype in (select a.systype from sys_model a where a.id = '" + ModelID + "') "
                                  + "and b.ztid = '" + m_strZTID + "'";
            OracleDataAdapter adaDB = new OracleDataAdapter(strSqlDbSelect, Con);
            DataSet dsDb = new DataSet();
            adaDB.Fill(dsDb, "DBSelect");
            foreach (DataRowView theRow in dsDb.Tables["DBSelect"].DefaultView)
            {
                strDBType = theRow.Row["DBTYPE"].ToString().Trim();
                strDbName = theRow.Row["DBNAME"].ToString().Trim();
                strPass = theRow.Row["PASSWORD"].ToString().Trim();
                strUser = theRow.Row["USERNAME"].ToString().Trim();
                strServer = theRow.Row["SERVER"].ToString().Trim(); 
            }

        }

        private void hasRight(string ModelID, out bool fgAdd, out bool fgDel, out bool fgUpdate, out bool fgQuery)
        {
            fgAdd = false;
            fgDel = false;
            fgUpdate = false;
            fgQuery = false;

            //if (m_strName == "admin")
            //{
            //    fgAdd = true;
            //    fgDel = true;
            //    fgUpdate = true;
            //    fgQuery = true;
            //}
            //else
            //{
                string sqlRight = "select ACTIONCODE from sys_role_module_action c where c.roleid || c.modeleid in "
                                + "(select b.role_id || b.module_id from sys_role_module b where b.role_id in "
                                + "(select a.roleid from sys_user_role a where a.username = '"
                                + m_strName + "' and a.deptid = '" + m_strDeptID + "')) and c.modeleid = '" + ModelID + "'";
                adaRight = new OracleDataAdapter(sqlRight, Con);
                dsRight = new DataSet();
                adaRight.Fill(dsRight, "ACT_RIGHT");
                foreach (DataRowView theRow in dsRight.Tables["ACT_RIGHT"].DefaultView)
                {
                    switch (theRow.Row["ACTIONCODE"].ToString().ToLower())
                    {
                        case "add":
                            fgAdd = true;
                            break;
                        case "delete":
                            fgDel = true;
                            break;
                        case "update":
                            fgUpdate = true;
                            break;
                        case "query":
                            fgQuery = true;
                            break;
                        default:
                            break;
                    }
                }
            //}
        }

        private void CreateNavGroup(DataView dvRoot)
        {

            foreach (DataRowView theRow in dvRoot)
            {
                //TreeList tlDept = new TreeList();
                //tlDept.Dock = System.Windows.Forms.DockStyle.Fill;
                NavBarGroup group = new NavBarGroup(theRow.Row["MODELNAME"].ToString());
                //group.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
                //NavBarGroupControlContainer taskContainer = new NavBarGroupControlContainer();
                //taskContainer.Controls.Add(tlDept);
                //group.ControlContainer = taskContainer;
                group.GroupStyle = NavBarGroupStyle.SmallIconsText;
                group.Name = theRow.Row["ID"].ToString();
                //this.outlookBar1.Groups.Add(group);  
               
                navBarControl1.Groups.Add(group);     
            }

            
        }

        private void CreateRightArea(DataView dvChild, NavBarItem Item)
        {
            dvChild.RowFilter = "PARENTMODEL = '" + Item.Tag.ToString() + "'";
            listView1.Items.Clear();
            //if (listView1 == null ||!panelRight.Controls.Contains(listView1))
            //{
                InitImageList();
                listView1.DoubleClick += new EventHandler(listView1_DoubleClick);
                listView1.KeyDown += new KeyEventHandler(listView1_KeyDown);
                listView1.View = View.LargeIcon;
                listView1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                listView1.BorderStyle = BorderStyle.None;
                listView1.LargeImageList = imageList1;
                listView1.SmallImageList = imageList2;
                listView1.HeaderStyle = ColumnHeaderStyle.Clickable;
                listView1.Scrollable = true;

                listView1.Columns.Add("名称", 300, HorizontalAlignment.Left);
                listView1.Columns.Add("说明", 500, HorizontalAlignment.Left);
                listView1.Dock = System.Windows.Forms.DockStyle.Top;
                //listView1.Left = 10;
                //listView1.Top = this.unit;
                //listView1.Height = this.panelRight.Height;
                //listView1.Width = this.panelRight.Width;
                this.panelRight.Controls.Add(listView1);
                listView1.BringToFront();

                foreach (DataRowView theRow in dvChild)
                {
                    ListViewItem listitem = new ListViewItem(theRow.Row["MODELNAME"].ToString());
                    listitem.ImageIndex = 1;
                    listitem.Name = theRow.Row["MODELNAME"].ToString();
                    listitem.Tag = theRow.Row["ID"].ToString();
                    listView1.Items.Add(listitem);
                }

                listView1.BringToFront();
                listView1.Show();
            //}
            //else
            //{
                
            //    listView1.BringToFront();
            //    listView1.Show();
               
            //}

            
        }

        private void CreateNavChild(DataView dvChild, NavBarGroup group)
        {
            dvChild.RowFilter = "PARENTMODEL = '" + group.Name.Trim() + "'";
            foreach (DataRowView theRow in dvChild)
            {
                NavBarItem item = new NavBarItem(theRow.Row["MODELNAME"].ToString());
                item.Tag = theRow.Row["ID"].ToString();
                item.Name = theRow.Row["MODELNAME"].ToString();
                group.ItemLinks.Add(item);
                //this.outlookBar1.Items.Add(item);
                navBarControl1.Items.Add(item);
                
            }
        }


        /// <summary>
        /// 生成outlookBar
        /// </summary>
        private void CreateOutlookBar()
        {
            //panelLeft.Controls.Clear();
            //this.outlookBar1 = new NavBarControl();
            //this.outlookBar1.LinkClicked += new NavBarLinkEventHandler(outlookBar1_LinkClicked);
            //this.outlookBar1.Dock = DockStyle.Fill;
            //this.outlookBar1.Location = new System.Drawing.Point(10, 0);
            //this.outlookBar1.Name = "outlookBar1";
            //this.outlookBar1.Size = new System.Drawing.Size(200, 350);
            //this.outlookBar1.TabIndex = 10;
            //this.outlookBar1.Text = "outlookBar1";
            //this.panelLeft.Controls.Add(outlookBar1);

            //this.outlookBar1.SuspendLayout();
           // this.outlookBar1.AllowSelectedLink = true;

            //this.outlookBar1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Blue");
            //this.outlookBar1.Appearance.GroupHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //this.outlookBar1.NavigationPaneGroupClientHeight = 200;
            //this.outlookBar1.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            //System.Drawing.Image image = null;
            navBarControl1.SuspendLayout();
            navBarControl1.AllowSelectedLink = true;
            navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Blue");
            navBarControl1.Appearance.GroupHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            navBarControl1.NavigationPaneGroupClientHeight = 200;
            navBarControl1.Appearance.NavigationPaneHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


            dt.DefaultView.RowFilter = "PARENTMODEL = '0'";
            DataView dvRoot = dt.DefaultView;
            CreateNavGroup(dvRoot);

            dt.DefaultView.RowFilter = null;
            dt.DefaultView.RowFilter = "PARENTMODEL <> '0' ";
            DataView dvChild = dt.DefaultView;



            for (int i = 0; i < navBarControl1.Groups.Count; i++)
            {
                CreateNavChild(dvChild, navBarControl1.Groups[i]);
            }

            if(navBarControl1.Groups.Count == 0)
            {
                const string message = "该用户没有管理权限，请联系管理员";
                const string caption = "警告！";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    Application.ExitThread();
                    System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }
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
            //this.outlookBar1.ResumeLayout(false);

        }

        void outlookBar1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           
            //            MessageBox.Show(string.Format("The {0} link has been clicked", e.Link.Caption));

            
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
            imageList1.Images.Clear();
            imageList2.Images.Clear();

            int fsCount = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + @"/Resources/icon/ListViewIcon", "*.ico").Length;

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
            bool fgAdd;
            bool fgDel;
            bool fgUpdate;
            bool fgQuery;

            
            switch (listView1.FocusedItem.Tag.ToString().Trim())
            { 
                case "101":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmDepartmentManagement DeptMt = new FrmDepartmentManagement(fgAdd, fgDel, fgUpdate, fgQuery);
                    DeptMt.ShowDialog();
                    break;
                case "122":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmDeptTypeMt DeptType = new FrmDeptTypeMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    DeptType.ShowDialog();
                    break;
                case "123":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmClientTypeMt ClientType = new FrmClientTypeMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    ClientType.ShowDialog();
                    break;
                case "283":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmPressTypeMt PressType = new FrmPressTypeMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    PressType.ShowDialog();
                    break;
                case "142":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmSupplierTypeMt SupplierType = new FrmSupplierTypeMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    SupplierType.ShowDialog();
                    break;
                case "143":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmWareTypeMt WareType = new FrmWareTypeMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    WareType.ShowDialog();
                    break;
                case "144":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmPrintTypeMt PrintingType = new FrmPrintTypeMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    PrintingType.ShowDialog();
                    break;
                case "145":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmTransTypeMt TransType = new FrmTransTypeMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    TransType.ShowDialog();
                    break;
                case "121":
                    hasRight(listView1.FocusedItem.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmUnitPropMt UnitProp = new FrmUnitPropMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    UnitProp.ShowDialog();
                    break;
                case"305":                    
                    FrmPurchaseReceiveNote PurchaseReceiveNote = new FrmPurchaseReceiveNote(false);
                    PurchaseReceiveNote.ShowDialog();
                    break;
                case "403":
                    FrmPurchaseReceiveTotal PurchaseReceiveTotal = new FrmPurchaseReceiveTotal(false);
                    PurchaseReceiveTotal.ShowDialog();
                    break;
                case"404":
                    FrmPurchaseReturnNote PurchaseReturnNote = new FrmPurchaseReturnNote(false);
                    PurchaseReturnNote.ShowDialog();
                    break;
                case"492":
                    FrmSaleReturnNote SaleReturnNote = new FrmSaleReturnNote(false);
                    SaleReturnNote.ShowDialog();
                    break;
                case"490":
                    FrmSaleTotal SaleTotal = new FrmSaleTotal(false);
                    SaleTotal.ShowDialog();
                    break;
                case"491":
                    FrmSaleNote SaleNote = new FrmSaleNote(false);
                    SaleNote.ShowDialog();
                    break;
                case "307":
                    FrmPurchaseReceiveNote PurchaseReceiveNoteBranch = new FrmPurchaseReceiveNote(true);
                    PurchaseReceiveNoteBranch.ShowDialog();
                    break;
                case "463":
                    FrmPurchaseReceiveTotalBranch PurchaseReceiveTotalBranch = new FrmPurchaseReceiveTotalBranch(true);
                    PurchaseReceiveTotalBranch.ShowDialog();
                    break;
                case "464":
                    FrmPurchaseReturnNoteBranch PurchaseReturnNoteBranch = new FrmPurchaseReturnNoteBranch(true);
                    PurchaseReturnNoteBranch.ShowDialog();
                    break;
                case "503":
                    FrmSaleReturnNote SaleReturnNoteBranch = new FrmSaleReturnNote(true);
                    SaleReturnNoteBranch.ShowDialog();
                    break;
                case "526":
                    FrmSaleTotalBranch SaleTotalBranch = new FrmSaleTotalBranch(true);
                    SaleTotalBranch.ShowDialog();
                    break;
                case "527":
                    FrmSaleNote SaleNoteBranch = new FrmSaleNote(true);
                    SaleNoteBranch.ShowDialog();
                    break;
                case "529":
                    FrmPurchaseCollectionNote PurchaseCollectionNoteBranch = new FrmPurchaseCollectionNote();
                    PurchaseCollectionNoteBranch.ShowDialog();
                    break;
                case "786":
                    FrmClientAccount ClientAccount = new FrmClientAccount();
                    ClientAccount.ShowDialog();
                    break;
                case "787":
                    FrmSupplierAccount SupplierAccount = new FrmSupplierAccount();
                    SupplierAccount.ShowDialog();
                    break;
                case "790":
                    FrmClientAccountBranch ClientAccountBranch = new FrmClientAccountBranch();
                    ClientAccountBranch.ShowDialog();
                    break;
                case "791":
                    FrmSupplierAccountBranch SupplierAccountBranch = new FrmSupplierAccountBranch();
                    SupplierAccountBranch.ShowDialog();
                    break;
                case "788"://集团帐套台账查询
                    FrmZTTZinquire FrmZTTZinquirejt = new FrmZTTZinquire();
                    FrmZTTZinquirejt.Tag = "1";
                    FrmZTTZinquirejt.ShowDialog();
                    break;
                case "789"://县市帐套台账查询
                    FrmZTTZinquire FrmZTTZinquirejc = new FrmZTTZinquire();
                    FrmZTTZinquirejc.Tag = "1";
                    FrmZTTZinquirejc.ShowDialog();
                    break;

                 case "443"://集团采购结算单实销实结
                    FrmPurchaseStageJT FrmCGJSDSXSJ = new FrmPurchaseStageJT();
                    FrmCGJSDSXSJ.Text = "集团——采购结算单——实销实结";
                    FrmCGJSDSXSJ.Tag = "JT_C_CGJSD_SXSJ";
                    FrmCGJSDSXSJ.ShowDialog();//FrmCGJSDSXSJ
                    break;
                case "423"://集团采购结算单整单结算
                    FrmPurchaseStageJT FrmCGJSDZDJS=new FrmPurchaseStageJT();
                    FrmCGJSDZDJS.Text = "集团——采购结算单——整单结算";
                    FrmCGJSDZDJS.Tag = "JT_C_CGJSD_ZDJS";
                    FrmCGJSDZDJS.ShowDialog();//FrmCGJSDSXSJ
                    break;
                case "604"://县市采购结算单整单结算
                    FrmPurchaseStageJC FrmPurchaseStageJC = new FrmPurchaseStageJC();
                    FrmPurchaseStageJC.Text = "县市——采购结算单——整单结算";
                    FrmPurchaseStageJC.Tag = "JC_C_CGJSD_ZDJS";
                    FrmPurchaseStageJC.ShowDialog();//FrmCGJSDSXSJ
                    break;
                case "528"://县市采购结算单实销实结
                    FrmPurchaseStageJC FrmCGJSDXSXJJC = new FrmPurchaseStageJC();
                    FrmCGJSDXSXJJC.Text = "县市——采购结算单——实销实结";
                    FrmCGJSDXSXJJC.Tag = "JC_C_CGJSD_SXSJ";
                    FrmCGJSDXSXJJC.ShowDialog();//FrmCGJSDSXSJ
                    break;
                case "363"://集团采购发票列表
                    FrmPurchaseInvoiceJT FrmPurchaseInvoiceJT = new FrmPurchaseInvoiceJT();
                    FrmPurchaseInvoiceJT.Tag = "JT_C_CGFP";
                    FrmPurchaseInvoiceJT.Text="集团——采购发票";
                    FrmPurchaseInvoiceJT.ShowDialog();
                    break;
                case "605"://县市采购发票列表
                    FrmPurchaseInvoiceJC FrmPurchaseInvoiceJC = new FrmPurchaseInvoiceJC();
                    FrmPurchaseInvoiceJC.Tag = "JC_C_CGFP";
                    FrmPurchaseInvoiceJC.Text = "县市——采购发票";
                    FrmPurchaseInvoiceJC.ShowDialog();
                    break;
                case "489"://集团销售发票管理
                    FrmSaleInvoiceJT FrmPurSalesInvoice = new FrmSaleInvoiceJT();
                    FrmPurSalesInvoice.Tag = "JT_C_XSFP";
                    FrmPurSalesInvoice.Text = "集团——销售发票——列表";
                    FrmPurSalesInvoice.ShowDialog();//FrmCGJSDSXSJ
                    break;
                case "603"://县市销售发票管理
                    FrmSaleInvoiceJC FrmPurSalesInvoiceJC = new FrmSaleInvoiceJC();
                    FrmPurSalesInvoiceJC.Tag = "JC_C_XSFP";
                    FrmPurSalesInvoiceJC.Text = "县市——销售发票——列表";
                    FrmPurSalesInvoiceJC.ShowDialog();//FrmCGJSDSXSJ
                    break;
					case "486"://集团销售结算单整单结算
                    FrmSaleStageJT FrmXSJSDZDJS = new FrmSaleStageJT();
                    FrmXSJSDZDJS.Text = "集团——销售结算单——整单结算";
                    FrmXSJSDZDJS.Tag = "JT_C_XSJSD_ZDJS";
                    FrmXSJSDZDJS.ShowDialog();
                    break;
                case "487"://集团销售结算单实销实结
                    FrmSaleStageJT FrmXSJSDSXSJ = new FrmSaleStageJT();
                    FrmXSJSDSXSJ.Text = "集团——销售结算单——实销实结";
                    FrmXSJSDSXSJ.Tag = "JT_C_XSJSD_SXSJ";
                    FrmXSJSDSXSJ.ShowDialog();
                    break;
                case "523"://县市销售结算单整单结算
                    FrmSaleStageJC FrmXSJSDZDJSJC = new FrmSaleStageJC();
                    FrmXSJSDZDJSJC.Text = "市县——销售结算单——整单结算";
                    FrmXSJSDZDJSJC.Tag = "JC_C_XSJSD_ZDJS";
                    FrmXSJSDZDJSJC.ShowDialog();
                    break;
                case "524"://县市销售结算单实销实结
                    FrmSaleStageJC FrmXSJSDSXSJJC = new FrmSaleStageJC();
                    FrmXSJSDSXSJJC.Text = "市县——销售结算单——实销实结";
                    FrmXSJSDSXSJJC.Tag = "JC_C_XSJSD_SXSJ";
                    FrmXSJSDSXSJJC.ShowDialog();
                    break;
                case "488"://集团销售客户托收单
                    FrmClientTuoShouJT FrmClientTuoShou = new FrmClientTuoShouJT();
                    FrmClientTuoShou.Tag = "JT_C_KHTSD";
                    FrmClientTuoShou.Text = "集团客户托收单管理";
                    FrmClientTuoShou.ShowDialog();
                    break;
                case "525"://县市销售客户托收单
                    FrmClientTuoShouJC FrmClientTuoShouC = new FrmClientTuoShouJC();
                    FrmClientTuoShouC.Tag = "JC_C_KHTSD";
                    FrmClientTuoShouC.Text = "县市客户托收单管理";
                    FrmClientTuoShouC.ShowDialog();
                    break;


                default:
                    break;

            }
//            MessageBox.Show(string.Format("The {0} link has been clicked", listView1.FocusedItem.Tag));

//            MessageBox.Show(string.Format("The {0} link has been clicked", GetMd5Str("hcz2322679")));

            //string url = @"tcp://192.168.8.158:8086/UpdateServer";
 
            //this.tcpChanner = new TcpClientChannel();
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
                string fs = Application.StartupPath + @"/Resources/icon/ListViewIcon/" + ImgName + ".ico";
                if (System.IO.File.Exists(fs))
                    ic = new Icon(fs);
                else
                    ic = new Icon(Application.StartupPath + @"/Resources/icon/ListViewIcon/1.ico");
                return ic;
            }
            catch { }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message = "确定关闭吗?";
            const string caption = "关闭?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "确定切换吗?";
            const string caption = "切换?";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
                System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            NavBarItem item = e.Link.Item;

            bool fgAdd;
            bool fgDel;
            bool fgUpdate;
            bool fgQuery;

            string strDBType;
            string strServer;
            string strDbName;
            string strUser;
            string strPass; 

            listView1.Hide();
            switch (item.Tag.ToString().Trim())
            {
                case "22":
                case "304":
                case "306":
                case "484":
                case "485":
                case "783":
                case "784":
                    CreateRightArea(dt.DefaultView, item);
                    break;
                case "24":
                    hasRight(item.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmStaffManageMent StaffMt = new FrmStaffManageMent(fgAdd, fgDel, fgUpdate, fgQuery);
                    StaffMt.ShowDialog();
                    break;
                case "161":
                    hasRight(item.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    FrmDBMt DBMt = new FrmDBMt(fgAdd, fgDel, fgUpdate, fgQuery);
                    DBMt.ShowDialog();
                    break;
                case "223":
                    DBSelect(item.Tag.ToString(), out strDBType, out strServer, out strDbName, out strUser, out strPass);
                    FrmChainDeptInfo FrmCDI = new FrmChainDeptInfo(strDBType, strServer, strDbName, strUser, strPass);
                    FrmCDI.ShowDialog();
                    break;
                case "236":
                    FrmBranchAdjust frmBraAdj = new FrmBranchAdjust(m_strName, m_strZTID, m_strDeptID);
                    frmBraAdj.ShowDialog();
                    break;
                case "235":
                    FrmSupplierAdjust frmSupAdj = new FrmSupplierAdjust(m_strName, m_strZTID, m_strDeptID);
                    frmSupAdj.ShowDialog();
                    break;
                case "544":
                    FrmAllocateNote frmAN = new FrmAllocateNote();
                    frmAN.ShowDialog();
                    break;
                case "545":
                    FrmProfitLossNote frmPLN = new FrmProfitLossNote();
                    frmPLN.ShowDialog();
                    break;
                case "584":
                    FrmAllocateErrorNote frmAEN = new FrmAllocateErrorNote();
                    frmAEN.ShowDialog();
                    break;
                case "585":
                    FrmProfitLossErrorNote frmPLEN = new FrmProfitLossErrorNote();
                    frmPLEN.ShowDialog();
                    break;
                case "586":
                    FrmPurchaseReceiveErrNote frmPREN = new FrmPurchaseReceiveErrNote();
                    frmPREN.ShowDialog();
                    break;
                case "587":
                    FrmPurchaseReturnErr frmPRE = new FrmPurchaseReturnErr();
                    frmPRE.ShowDialog();
                    break;
                case "588":
                    FrmSaleErrorNote frmSEN = new FrmSaleErrorNote();
                    frmSEN.ShowDialog();
                    break;
                case "589":
                    FrmSaleReturnErrNote frmSREN = new FrmSaleReturnErrNote();
                    frmSREN.ShowDialog();
                    break;
                case "644":
                    FrmPurchaseReveiveVoucherNote PurchaseReveiveVoucherNote = new FrmPurchaseReveiveVoucherNote();
                    PurchaseReveiveVoucherNote.ShowDialog();
                    break;                
                case "683":
                    FrmPaymentVoucherNote PaymentVoucher = new FrmPaymentVoucherNote();
                    PaymentVoucher.ShowDialog();
                    break;
                case "703":
                    FrmDeliveryVoucherNote DeliveryVoucher = new FrmDeliveryVoucherNote();
                    DeliveryVoucher.ShowDialog();
                    break;
                case "723":
                    FrmReceivableVoucherNote ReceivableVoucher = new FrmReceivableVoucherNote();
                    ReceivableVoucher.ShowDialog();
                    break;
                case "743":
                    FrmCollectionVoucherNote CollectionVoucher = new FrmCollectionVoucherNote();
                    CollectionVoucher.ShowDialog();
                    break;
                case "744":
                    FrmCarryoverCostVoucherNote CarryOverVoucher = new FrmCarryoverCostVoucherNote();
                    CarryOverVoucher.ShowDialog();
                    break;
                case "745":
                    FrmAllocateVoucherNote AllocateVoucher = new FrmAllocateVoucherNote();
                    AllocateVoucher.ShowDialog();
                    break;
                case "763":
                    FrmLossVoucherNote LossVoucher = new FrmLossVoucherNote();
                    LossVoucher.ShowDialog();
                    break;
                case "764":
                    FrmInventoryProfitLossVoucherNote ProfitLossVoucher = new FrmInventoryProfitLossVoucherNote();
                    ProfitLossVoucher.ShowDialog();
                    break;
                case "3"://角色管理
                    hasRight(item.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    RoleMain RoleMain = new RoleMain(fgAdd, fgDel, fgUpdate, fgQuery);
                    RoleMain.ShowDialog();
                    break;
                case "81"://用户管理
                    hasRight(item.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    UserMain UserMt = new UserMain(fgAdd, fgDel, fgUpdate, fgQuery);
                    UserMt.ShowDialog();
                    break;
                case "2"://菜单管理
                    hasRight(item.Tag.ToString(), out fgAdd, out fgDel, out fgUpdate, out fgQuery);
                    MeunMain MenuMt = new MeunMain(fgAdd, fgDel, fgUpdate, fgQuery);
                    MenuMt.ShowDialog();
                    break;
                case "624"://录入功能
                    FrmUnusualStockInput FrmUnusualStockInput = new FrmUnusualStockInput();
                    FrmUnusualStockInput.ShowDialog();
                    break;
                case "625"://退货功能
                    FrmUnusualStockReturns FrmReturnPurchase = new FrmUnusualStockReturns();
                    FrmReturnPurchase.Tag = "JC_G_JTD";
                    FrmReturnPurchase.Text = "非正常库存退货";
                    FrmReturnPurchase.ShowDialog();
                    break;
                default:
                    break;

            }
           
        }

        private void navBarControl1_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
        {
            listView1.Hide();
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
