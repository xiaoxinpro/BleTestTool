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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBleNameReplace = new System.Windows.Forms.TabPage();
            this.tabBleBlackList = new System.Windows.Forms.TabPage();
            this.btnBleNameReplace = new System.Windows.Forms.Button();
            this.txtBleReplace = new System.Windows.Forms.TextBox();
            this.txtBleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewBleNameReplace = new System.Windows.Forms.ListView();
            this.btnBleBlackList = new System.Windows.Forms.Button();
            this.txtBleBlackList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewBleBlackList = new System.Windows.Forms.ListView();
            this.comboBleBlackList = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabBleNameReplace.SuspendLayout();
            this.tabBleBlackList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBleNameReplace);
            this.tabControl1.Controls.Add(this.tabBleBlackList);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 385);
            this.tabControl1.TabIndex = 2;
            // 
            // tabBleNameReplace
            // 
            this.tabBleNameReplace.Controls.Add(this.btnBleNameReplace);
            this.tabBleNameReplace.Controls.Add(this.txtBleReplace);
            this.tabBleNameReplace.Controls.Add(this.txtBleName);
            this.tabBleNameReplace.Controls.Add(this.label2);
            this.tabBleNameReplace.Controls.Add(this.label1);
            this.tabBleNameReplace.Controls.Add(this.listViewBleNameReplace);
            this.tabBleNameReplace.Location = new System.Drawing.Point(4, 30);
            this.tabBleNameReplace.Name = "tabBleNameReplace";
            this.tabBleNameReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabBleNameReplace.Size = new System.Drawing.Size(365, 351);
            this.tabBleNameReplace.TabIndex = 0;
            this.tabBleNameReplace.Text = "蓝牙名称替换";
            this.tabBleNameReplace.UseVisualStyleBackColor = true;
            // 
            // tabBleBlackList
            // 
            this.tabBleBlackList.Controls.Add(this.comboBleBlackList);
            this.tabBleBlackList.Controls.Add(this.btnBleBlackList);
            this.tabBleBlackList.Controls.Add(this.txtBleBlackList);
            this.tabBleBlackList.Controls.Add(this.label3);
            this.tabBleBlackList.Controls.Add(this.label4);
            this.tabBleBlackList.Controls.Add(this.listViewBleBlackList);
            this.tabBleBlackList.Location = new System.Drawing.Point(4, 30);
            this.tabBleBlackList.Name = "tabBleBlackList";
            this.tabBleBlackList.Padding = new System.Windows.Forms.Padding(3);
            this.tabBleBlackList.Size = new System.Drawing.Size(365, 351);
            this.tabBleBlackList.TabIndex = 1;
            this.tabBleBlackList.Text = "蓝牙黑名单";
            this.tabBleBlackList.UseVisualStyleBackColor = true;
            // 
            // btnBleNameReplace
            // 
            this.btnBleNameReplace.Location = new System.Drawing.Point(277, 13);
            this.btnBleNameReplace.Name = "btnBleNameReplace";
            this.btnBleNameReplace.Size = new System.Drawing.Size(84, 56);
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
            this.txtBleReplace.Size = new System.Drawing.Size(182, 25);
            this.txtBleReplace.TabIndex = 10;
            // 
            // txtBleName
            // 
            this.txtBleName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtBleName.Location = new System.Drawing.Point(89, 13);
            this.txtBleName.Name = "txtBleName";
            this.txtBleName.Size = new System.Drawing.Size(182, 25);
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
            this.listViewBleNameReplace.Size = new System.Drawing.Size(356, 270);
            this.listViewBleNameReplace.TabIndex = 6;
            this.listViewBleNameReplace.UseCompatibleStateImageBehavior = false;
            this.listViewBleNameReplace.View = System.Windows.Forms.View.Details;
            this.listViewBleNameReplace.SelectedIndexChanged += new System.EventHandler(this.listViewBleNameReplace_SelectedIndexChanged);
            this.listViewBleNameReplace.DoubleClick += new System.EventHandler(this.listViewBleNameReplace_DoubleClick);
            // 
            // btnBleBlackList
            // 
            this.btnBleBlackList.Location = new System.Drawing.Point(277, 13);
            this.btnBleBlackList.Name = "btnBleBlackList";
            this.btnBleBlackList.Size = new System.Drawing.Size(84, 56);
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
            this.txtBleBlackList.Size = new System.Drawing.Size(182, 25);
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
            this.listViewBleBlackList.Location = new System.Drawing.Point(5, 75);
            this.listViewBleBlackList.Name = "listViewBleBlackList";
            this.listViewBleBlackList.Size = new System.Drawing.Size(356, 270);
            this.listViewBleBlackList.TabIndex = 12;
            this.listViewBleBlackList.UseCompatibleStateImageBehavior = false;
            this.listViewBleBlackList.View = System.Windows.Forms.View.Details;
            this.listViewBleBlackList.SelectedIndexChanged += new System.EventHandler(this.listViewBleBlackList_SelectedIndexChanged);
            this.listViewBleBlackList.DoubleClick += new System.EventHandler(this.listViewBleBlackList_DoubleClick);
            // 
            // comboBleBlackList
            // 
            this.comboBleBlackList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboBleBlackList.FormattingEnabled = true;
            this.comboBleBlackList.Location = new System.Drawing.Point(89, 13);
            this.comboBleBlackList.Name = "comboBleBlackList";
            this.comboBleBlackList.Size = new System.Drawing.Size(182, 25);
            this.comboBleBlackList.TabIndex = 18;
            this.comboBleBlackList.SelectedIndexChanged += new System.EventHandler(this.comboBleBlackList_SelectedIndexChanged);
            // 
            // frmBleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 405);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBleConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蓝牙高级配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBleConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmBleConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBleNameReplace.ResumeLayout(false);
            this.tabBleNameReplace.PerformLayout();
            this.tabBleBlackList.ResumeLayout(false);
            this.tabBleBlackList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}