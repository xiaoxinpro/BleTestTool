namespace BleTestTool
{
    partial class frmBleConfig
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
            this.tabControlBleConfig = new System.Windows.Forms.TabControl();
            this.tabBleNameReplace = new System.Windows.Forms.TabPage();
            this.checkBleNameFilter = new System.Windows.Forms.CheckBox();
            this.btnBleNameReplace = new System.Windows.Forms.Button();
            this.txtBleReplace = new System.Windows.Forms.TextBox();
            this.txtBleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewBleNameReplace = new System.Windows.Forms.ListView();
            this.tabBleBlackList = new System.Windows.Forms.TabPage();
            this.btnBleBlackListAll = new System.Windows.Forms.Button();
            this.comboBleBlackList = new System.Windows.Forms.ComboBox();
            this.btnBleBlackList = new System.Windows.Forms.Button();
            this.txtBleBlackList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewBleBlackList = new System.Windows.Forms.ListView();
            this.contextMenuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuDeleteUpAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDeleteDownAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlBleConfig.SuspendLayout();
            this.tabBleNameReplace.SuspendLayout();
            this.tabBleBlackList.SuspendLayout();
            this.contextMenuListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBleConfig
            // 
            this.tabControlBleConfig.Controls.Add(this.tabBleNameReplace);
            this.tabControlBleConfig.Controls.Add(this.tabBleBlackList);
            this.tabControlBleConfig.Location = new System.Drawing.Point(12, 12);
            this.tabControlBleConfig.Name = "tabControlBleConfig";
            this.tabControlBleConfig.SelectedIndex = 0;
            this.tabControlBleConfig.Size = new System.Drawing.Size(440, 458);
            this.tabControlBleConfig.TabIndex = 2;
            this.tabControlBleConfig.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlBleConfig_Selected);
            // 
            // tabBleNameReplace
            // 
            this.tabBleNameReplace.Controls.Add(this.checkBleNameFilter);
            this.tabBleNameReplace.Controls.Add(this.btnBleNameReplace);
            this.tabBleNameReplace.Controls.Add(this.txtBleReplace);
            this.tabBleNameReplace.Controls.Add(this.txtBleName);
            this.tabBleNameReplace.Controls.Add(this.label2);
            this.tabBleNameReplace.Controls.Add(this.label1);
            this.tabBleNameReplace.Controls.Add(this.listViewBleNameReplace);
            this.tabBleNameReplace.Location = new System.Drawing.Point(4, 30);
            this.tabBleNameReplace.Name = "tabBleNameReplace";
            this.tabBleNameReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabBleNameReplace.Size = new System.Drawing.Size(432, 424);
            this.tabBleNameReplace.TabIndex = 0;
            this.tabBleNameReplace.Text = "蓝牙名称";
            this.tabBleNameReplace.UseVisualStyleBackColor = true;
            // 
            // checkBleNameFilter
            // 
            this.checkBleNameFilter.AutoSize = true;
            this.checkBleNameFilter.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.checkBleNameFilter.Location = new System.Drawing.Point(342, 14);
            this.checkBleNameFilter.Name = "checkBleNameFilter";
            this.checkBleNameFilter.Size = new System.Drawing.Size(84, 24);
            this.checkBleNameFilter.TabIndex = 12;
            this.checkBleNameFilter.Text = "开启过滤";
            this.checkBleNameFilter.UseVisualStyleBackColor = true;
            this.checkBleNameFilter.CheckedChanged += new System.EventHandler(this.checkBleNameFilter_CheckedChanged);
            // 
            // btnBleNameReplace
            // 
            this.btnBleNameReplace.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnBleNameReplace.Location = new System.Drawing.Point(342, 45);
            this.btnBleNameReplace.Name = "btnBleNameReplace";
            this.btnBleNameReplace.Size = new System.Drawing.Size(84, 25);
            this.btnBleNameReplace.TabIndex = 11;
            this.btnBleNameReplace.Text = "添加";
            this.btnBleNameReplace.UseVisualStyleBackColor = true;
            this.btnBleNameReplace.Click += new System.EventHandler(this.btnBleNameReplace_Click);
            // 
            // txtBleReplace
            // 
            this.txtBleReplace.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtBleReplace.Location = new System.Drawing.Point(89, 44);
            this.txtBleReplace.Name = "txtBleReplace";
            this.txtBleReplace.Size = new System.Drawing.Size(247, 25);
            this.txtBleReplace.TabIndex = 10;
            // 
            // txtBleName
            // 
            this.txtBleName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtBleName.Location = new System.Drawing.Point(89, 13);
            this.txtBleName.Name = "txtBleName";
            this.txtBleName.Size = new System.Drawing.Size(247, 25);
            this.txtBleName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "替换内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "蓝牙名称：";
            // 
            // listViewBleNameReplace
            // 
            this.listViewBleNameReplace.Location = new System.Drawing.Point(5, 75);
            this.listViewBleNameReplace.Name = "listViewBleNameReplace";
            this.listViewBleNameReplace.Size = new System.Drawing.Size(421, 343);
            this.listViewBleNameReplace.TabIndex = 6;
            this.listViewBleNameReplace.UseCompatibleStateImageBehavior = false;
            this.listViewBleNameReplace.View = System.Windows.Forms.View.Details;
            this.listViewBleNameReplace.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewBleNameReplace_ItemChecked);
            this.listViewBleNameReplace.SelectedIndexChanged += new System.EventHandler(this.listViewBleNameReplace_SelectedIndexChanged);
            this.listViewBleNameReplace.DoubleClick += new System.EventHandler(this.listViewBleNameReplace_DoubleClick);
            // 
            // tabBleBlackList
            // 
            this.tabBleBlackList.Controls.Add(this.btnBleBlackListAll);
            this.tabBleBlackList.Controls.Add(this.comboBleBlackList);
            this.tabBleBlackList.Controls.Add(this.btnBleBlackList);
            this.tabBleBlackList.Controls.Add(this.txtBleBlackList);
            this.tabBleBlackList.Controls.Add(this.label3);
            this.tabBleBlackList.Controls.Add(this.label4);
            this.tabBleBlackList.Controls.Add(this.listViewBleBlackList);
            this.tabBleBlackList.Location = new System.Drawing.Point(4, 30);
            this.tabBleBlackList.Name = "tabBleBlackList";
            this.tabBleBlackList.Padding = new System.Windows.Forms.Padding(3);
            this.tabBleBlackList.Size = new System.Drawing.Size(432, 424);
            this.tabBleBlackList.TabIndex = 1;
            this.tabBleBlackList.Text = "蓝牙黑名单";
            this.tabBleBlackList.UseVisualStyleBackColor = true;
            // 
            // btnBleBlackListAll
            // 
            this.btnBleBlackListAll.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnBleBlackListAll.Location = new System.Drawing.Point(342, 13);
            this.btnBleBlackListAll.Name = "btnBleBlackListAll";
            this.btnBleBlackListAll.Size = new System.Drawing.Size(84, 25);
            this.btnBleBlackListAll.TabIndex = 19;
            this.btnBleBlackListAll.Text = "全部添加";
            this.btnBleBlackListAll.UseVisualStyleBackColor = true;
            this.btnBleBlackListAll.Click += new System.EventHandler(this.btnBleBlackListAll_Click);
            // 
            // comboBleBlackList
            // 
            this.comboBleBlackList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBleBlackList.FormattingEnabled = true;
            this.comboBleBlackList.Location = new System.Drawing.Point(89, 13);
            this.comboBleBlackList.Name = "comboBleBlackList";
            this.comboBleBlackList.Size = new System.Drawing.Size(247, 25);
            this.comboBleBlackList.TabIndex = 18;
            this.comboBleBlackList.SelectedIndexChanged += new System.EventHandler(this.comboBleBlackList_SelectedIndexChanged);
            // 
            // btnBleBlackList
            // 
            this.btnBleBlackList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnBleBlackList.Location = new System.Drawing.Point(342, 44);
            this.btnBleBlackList.Name = "btnBleBlackList";
            this.btnBleBlackList.Size = new System.Drawing.Size(84, 25);
            this.btnBleBlackList.TabIndex = 17;
            this.btnBleBlackList.Text = "添加";
            this.btnBleBlackList.UseVisualStyleBackColor = true;
            this.btnBleBlackList.Click += new System.EventHandler(this.btnBleBlackList_Click);
            // 
            // txtBleBlackList
            // 
            this.txtBleBlackList.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtBleBlackList.Location = new System.Drawing.Point(89, 44);
            this.txtBleBlackList.Name = "txtBleBlackList";
            this.txtBleBlackList.Size = new System.Drawing.Size(247, 25);
            this.txtBleBlackList.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "蓝牙地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "蓝牙备注：";
            // 
            // listViewBleBlackList
            // 
            this.listViewBleBlackList.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.listViewBleBlackList.Location = new System.Drawing.Point(5, 75);
            this.listViewBleBlackList.Name = "listViewBleBlackList";
            this.listViewBleBlackList.Size = new System.Drawing.Size(421, 343);
            this.listViewBleBlackList.TabIndex = 12;
            this.listViewBleBlackList.UseCompatibleStateImageBehavior = false;
            this.listViewBleBlackList.View = System.Windows.Forms.View.Details;
            this.listViewBleBlackList.SelectedIndexChanged += new System.EventHandler(this.listViewBleBlackList_SelectedIndexChanged);
            this.listViewBleBlackList.DoubleClick += new System.EventHandler(this.listViewBleBlackList_DoubleClick);
            // 
            // contextMenuListView
            // 
            this.contextMenuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDelete,
            this.toolStripSeparator1,
            this.toolStripMenuDeleteUpAll,
            this.toolStripMenuDeleteAll,
            this.toolStripMenuDeleteDownAll});
            this.contextMenuListView.Name = "contextMenuListView";
            this.contextMenuListView.Size = new System.Drawing.Size(149, 98);
            this.contextMenuListView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuListView_Opening);
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuDelete.Text = "删除选择";
            this.toolStripMenuDelete.Click += new System.EventHandler(this.toolStripMenuDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuDeleteUpAll
            // 
            this.toolStripMenuDeleteUpAll.Name = "toolStripMenuDeleteUpAll";
            this.toolStripMenuDeleteUpAll.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuDeleteUpAll.Text = "删除以上所有";
            this.toolStripMenuDeleteUpAll.Click += new System.EventHandler(this.toolStripMenuDeleteUpAll_Click);
            // 
            // toolStripMenuDeleteAll
            // 
            this.toolStripMenuDeleteAll.Name = "toolStripMenuDeleteAll";
            this.toolStripMenuDeleteAll.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuDeleteAll.Text = "删除所有";
            this.toolStripMenuDeleteAll.Click += new System.EventHandler(this.toolStripMenuDeleteAll_Click);
            // 
            // toolStripMenuDeleteDownAll
            // 
            this.toolStripMenuDeleteDownAll.Name = "toolStripMenuDeleteDownAll";
            this.toolStripMenuDeleteDownAll.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuDeleteDownAll.Text = "删除以下所有";
            this.toolStripMenuDeleteDownAll.Click += new System.EventHandler(this.toolStripMenuDeleteDownAll_Click);
            // 
            // frmBleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 482);
            this.Controls.Add(this.tabControlBleConfig);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBleConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蓝牙高级配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBleConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmBleConfig_Load);
            this.tabControlBleConfig.ResumeLayout(false);
            this.tabBleNameReplace.ResumeLayout(false);
            this.tabBleNameReplace.PerformLayout();
            this.tabBleBlackList.ResumeLayout(false);
            this.tabBleBlackList.PerformLayout();
            this.contextMenuListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBleConfig;
        private System.Windows.Forms.TabPage tabBleNameReplace;
        private System.Windows.Forms.Button btnBleNameReplace;
        private System.Windows.Forms.TextBox txtBleReplace;
        private System.Windows.Forms.TextBox txtBleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewBleNameReplace;
        private System.Windows.Forms.TabPage tabBleBlackList;
        private System.Windows.Forms.ComboBox comboBleBlackList;
        private System.Windows.Forms.Button btnBleBlackList;
        private System.Windows.Forms.TextBox txtBleBlackList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewBleBlackList;
        private System.Windows.Forms.Button btnBleBlackListAll;
        private System.Windows.Forms.CheckBox checkBleNameFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuListView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteUpAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteDownAll;
    }
}