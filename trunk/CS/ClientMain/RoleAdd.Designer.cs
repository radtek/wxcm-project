namespace ClientMain
{
    partial class RoleAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleaddtoolStrip = new System.Windows.Forms.ToolStrip();
            this.roleaddtoolStripBtn1 = new System.Windows.Forms.ToolStripButton();
            this.roleaddtoolStripBtn2 = new System.Windows.Forms.ToolStripButton();
            this.roleaddtoolStripBtn3 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.roleaddtoolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.roleaddtoolStrip);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 50);
            this.panel1.TabIndex = 0;
            // 
            // roleaddtoolStrip
            // 
            this.roleaddtoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleaddtoolStripBtn1,
            this.roleaddtoolStripBtn2,
            this.roleaddtoolStripBtn3});
            this.roleaddtoolStrip.Location = new System.Drawing.Point(0, 0);
            this.roleaddtoolStrip.Name = "roleaddtoolStrip";
            this.roleaddtoolStrip.Size = new System.Drawing.Size(678, 25);
            this.roleaddtoolStrip.TabIndex = 0;
            this.roleaddtoolStrip.Text = "roleaddtoolStrip";
            // 
            // roleaddtoolStripBtn1
            // 
            this.roleaddtoolStripBtn1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roleaddtoolStripBtn1.Image = ((System.Drawing.Image)(resources.GetObject("roleaddtoolStripBtn1.Image")));
            this.roleaddtoolStripBtn1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roleaddtoolStripBtn1.Name = "roleaddtoolStripBtn1";
            this.roleaddtoolStripBtn1.Size = new System.Drawing.Size(23, 22);
            this.roleaddtoolStripBtn1.Text = "保存";
            this.roleaddtoolStripBtn1.Click += new System.EventHandler(this.roleaddtoolStripBtn1_Click);
            // 
            // roleaddtoolStripBtn2
            // 
            this.roleaddtoolStripBtn2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roleaddtoolStripBtn2.Image = ((System.Drawing.Image)(resources.GetObject("roleaddtoolStripBtn2.Image")));
            this.roleaddtoolStripBtn2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roleaddtoolStripBtn2.Name = "roleaddtoolStripBtn2";
            this.roleaddtoolStripBtn2.Size = new System.Drawing.Size(23, 22);
            this.roleaddtoolStripBtn2.Text = "取消";
            // 
            // roleaddtoolStripBtn3
            // 
            this.roleaddtoolStripBtn3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roleaddtoolStripBtn3.Image = ((System.Drawing.Image)(resources.GetObject("roleaddtoolStripBtn3.Image")));
            this.roleaddtoolStripBtn3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roleaddtoolStripBtn3.Name = "roleaddtoolStripBtn3";
            this.roleaddtoolStripBtn3.Size = new System.Drawing.Size(23, 22);
            this.roleaddtoolStripBtn3.Text = "退出";
            this.roleaddtoolStripBtn3.Click += new System.EventHandler(this.roleaddtoolStripBtn3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 449);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "角色添加";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(33, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 333);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "权限选择";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(319, 7);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(266, 295);
            this.treeView2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(7, 7);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(274, 295);
            this.treeView1.TabIndex = 0;
          //  this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "角色描述";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RoleAdd";
            this.Text = "添加角色";
            this.Load += new System.EventHandler(this.RoleAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roleaddtoolStrip.ResumeLayout(false);
            this.roleaddtoolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip roleaddtoolStrip;
        private System.Windows.Forms.ToolStripButton roleaddtoolStripBtn1;
        private System.Windows.Forms.ToolStripButton roleaddtoolStripBtn2;
        private System.Windows.Forms.ToolStripButton roleaddtoolStripBtn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
    }
}