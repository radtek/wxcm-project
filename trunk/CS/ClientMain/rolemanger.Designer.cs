namespace ClientMain
{
    partial class rolemanger
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
            this.roletoppanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.roleexitbtn = new System.Windows.Forms.Button();
            this.rolecreatebtn = new System.Windows.Forms.Button();
            this.roledelebtn = new System.Windows.Forms.Button();
            this.roleeditbrn = new System.Windows.Forms.Button();
            this.roleadbtn = new System.Windows.Forms.Button();
            this.rolemainpanel = new System.Windows.Forms.Panel();
            this.roledataGridView1 = new System.Windows.Forms.DataGridView();
            this.roledblabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roletoppanel.SuspendLayout();
            this.rolemainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roledataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // roletoppanel
            // 
            this.roletoppanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.roletoppanel.Controls.Add(this.button1);
            this.roletoppanel.Controls.Add(this.roleexitbtn);
            this.roletoppanel.Controls.Add(this.rolecreatebtn);
            this.roletoppanel.Controls.Add(this.roledelebtn);
            this.roletoppanel.Controls.Add(this.roleeditbrn);
            this.roletoppanel.Controls.Add(this.roleadbtn);
            this.roletoppanel.Location = new System.Drawing.Point(0, 0);
            this.roletoppanel.Name = "roletoppanel";
            this.roletoppanel.Size = new System.Drawing.Size(1017, 69);
            this.roletoppanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roleexitbtn
            // 
            this.roleexitbtn.Location = new System.Drawing.Point(331, 3);
            this.roleexitbtn.Name = "roleexitbtn";
            this.roleexitbtn.Size = new System.Drawing.Size(76, 63);
            this.roleexitbtn.TabIndex = 4;
            this.roleexitbtn.Text = "退出";
            this.roleexitbtn.UseVisualStyleBackColor = true;
            this.roleexitbtn.Click += new System.EventHandler(this.roleexitbtn_Click);
            // 
            // rolecreatebtn
            // 
            this.rolecreatebtn.Location = new System.Drawing.Point(249, 3);
            this.rolecreatebtn.Name = "rolecreatebtn";
            this.rolecreatebtn.Size = new System.Drawing.Size(76, 63);
            this.rolecreatebtn.TabIndex = 3;
            this.rolecreatebtn.Text = "类似创建";
            this.rolecreatebtn.UseVisualStyleBackColor = true;
            this.rolecreatebtn.Click += new System.EventHandler(this.rolecreatebtn_Click);
            // 
            // roledelebtn
            // 
            this.roledelebtn.Location = new System.Drawing.Point(167, 3);
            this.roledelebtn.Name = "roledelebtn";
            this.roledelebtn.Size = new System.Drawing.Size(76, 63);
            this.roledelebtn.TabIndex = 2;
            this.roledelebtn.Text = "删除";
            this.roledelebtn.UseVisualStyleBackColor = true;
            this.roledelebtn.Click += new System.EventHandler(this.roledelebtn_Click);
            // 
            // roleeditbrn
            // 
            this.roleeditbrn.Location = new System.Drawing.Point(85, 3);
            this.roleeditbrn.Name = "roleeditbrn";
            this.roleeditbrn.Size = new System.Drawing.Size(76, 63);
            this.roleeditbrn.TabIndex = 1;
            this.roleeditbrn.Text = "编辑";
            this.roleeditbrn.UseVisualStyleBackColor = true;
            this.roleeditbrn.Click += new System.EventHandler(this.roleeditbrn_Click);
            // 
            // roleadbtn
            // 
            this.roleadbtn.Location = new System.Drawing.Point(3, 3);
            this.roleadbtn.Name = "roleadbtn";
            this.roleadbtn.Size = new System.Drawing.Size(76, 63);
            this.roleadbtn.TabIndex = 0;
            this.roleadbtn.Text = "添加";
            this.roleadbtn.UseVisualStyleBackColor = true;
            this.roleadbtn.Click += new System.EventHandler(this.roleadbtn_Click);
            // 
            // rolemainpanel
            // 
            this.rolemainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rolemainpanel.AutoScroll = true;
            this.rolemainpanel.Controls.Add(this.roledataGridView1);
            this.rolemainpanel.Controls.Add(this.roledblabel);
            this.rolemainpanel.Location = new System.Drawing.Point(3, 72);
            this.rolemainpanel.Name = "rolemainpanel";
            this.rolemainpanel.Size = new System.Drawing.Size(1004, 450);
            this.rolemainpanel.TabIndex = 1;
            // 
            // roledataGridView1
            // 
            this.roledataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roledataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.roledataGridView1.Location = new System.Drawing.Point(0, 0);
            this.roledataGridView1.MultiSelect = false;
            this.roledataGridView1.Name = "roledataGridView1";
            this.roledataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.roledataGridView1.RowTemplate.Height = 23;
            this.roledataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roledataGridView1.Size = new System.Drawing.Size(1004, 416);
            this.roledataGridView1.TabIndex = 1;
            this.roledataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roledblabel
            // 
            this.roledblabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roledblabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.roledblabel.Location = new System.Drawing.Point(4, 4);
            this.roledblabel.Name = "roledblabel";
            this.roledblabel.Size = new System.Drawing.Size(997, 23);
            this.roledblabel.TabIndex = 0;
            this.roledblabel.Text = "角色管理";
            this.roledblabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(458, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(610, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(860, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 4;
            // 
            // rolemanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolemainpanel);
            this.Controls.Add(this.roletoppanel);
            this.Name = "rolemanger";
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.rolemanger_Load);
            this.roletoppanel.ResumeLayout(false);
            this.rolemainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roledataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roletoppanel;
        private System.Windows.Forms.Button roleexitbtn;
        private System.Windows.Forms.Button rolecreatebtn;
        private System.Windows.Forms.Button roledelebtn;
        private System.Windows.Forms.Button roleeditbrn;
        private System.Windows.Forms.Button roleadbtn;
        private System.Windows.Forms.Panel rolemainpanel;
        private System.Windows.Forms.Label roledblabel;
        private System.Windows.Forms.DataGridView roledataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}