namespace HostsWizard
{
    partial class HostWizardsMain
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
            this.tlHostlist = new DevExpress.XtraTreeList.TreeList();
            this.clEnable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.clIP = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clDomain = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clGroup = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFlushDns = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveApply = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tlHostlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlHostlist
            // 
            this.tlHostlist.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.clEnable,
            this.clIP,
            this.clDomain,
            this.clGroup,
            this.clType});
            this.tlHostlist.CustomizationFormBounds = new System.Drawing.Rectangle(742, 532, 216, 187);
            this.tlHostlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlHostlist.Location = new System.Drawing.Point(0, 0);
            this.tlHostlist.Name = "tlHostlist";
            this.tlHostlist.OptionsBehavior.PopulateServiceColumns = true;
            this.tlHostlist.OptionsView.ShowCheckBoxes = true;
            this.tlHostlist.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.tlHostlist.Size = new System.Drawing.Size(907, 485);
            this.tlHostlist.TabIndex = 0;
            this.tlHostlist.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlHostlist_AfterCheckNode);
            this.tlHostlist.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.tlHostlist_CellValueChanged);
            // 
            // clEnable
            // 
            this.clEnable.AllowIncrementalSearch = false;
            this.clEnable.Caption = "Enable";
            this.clEnable.ColumnEdit = this.repositoryItemTextEdit1;
            this.clEnable.FieldName = "Enable";
            this.clEnable.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.clEnable.Format.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clEnable.MinWidth = 32;
            this.clEnable.Name = "clEnable";
            this.clEnable.OptionsColumn.AllowSort = false;
            this.clEnable.OptionsColumn.FixedWidth = true;
            this.clEnable.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.clEnable.Visible = true;
            this.clEnable.VisibleIndex = 0;
            this.clEnable.Width = 153;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // clIP
            // 
            this.clIP.Caption = "IP";
            this.clIP.FieldName = "IP";
            this.clIP.Name = "clIP";
            this.clIP.Visible = true;
            this.clIP.VisibleIndex = 1;
            this.clIP.Width = 301;
            // 
            // clDomain
            // 
            this.clDomain.Caption = "Domain";
            this.clDomain.FieldName = "Domain";
            this.clDomain.Name = "clDomain";
            this.clDomain.Visible = true;
            this.clDomain.VisibleIndex = 2;
            this.clDomain.Width = 189;
            // 
            // clGroup
            // 
            this.clGroup.Caption = "Group";
            this.clGroup.FieldName = "Group";
            this.clGroup.Name = "clGroup";
            this.clGroup.Visible = true;
            this.clGroup.VisibleIndex = 3;
            this.clGroup.Width = 164;
            // 
            // clType
            // 
            this.clType.Caption = "Type";
            this.clType.FieldName = "Type";
            this.clType.Name = "clType";
            this.clType.Visible = true;
            this.clType.VisibleIndex = 4;
            this.clType.Width = 82;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFlushDns);
            this.panel1.Controls.Add(this.btnSaveApply);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnFlushDns
            // 
            this.btnFlushDns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlushDns.Location = new System.Drawing.Point(631, 25);
            this.btnFlushDns.Name = "btnFlushDns";
            this.btnFlushDns.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnFlushDns.Size = new System.Drawing.Size(113, 32);
            this.btnFlushDns.TabIndex = 2;
            this.btnFlushDns.Text = "手动刷新DNS缓存";
            this.btnFlushDns.Click += new System.EventHandler(this.btnFlushDns_Click);
            // 
            // btnSaveApply
            // 
            this.btnSaveApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveApply.Location = new System.Drawing.Point(779, 25);
            this.btnSaveApply.Name = "btnSaveApply";
            this.btnSaveApply.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnSaveApply.Size = new System.Drawing.Size(113, 32);
            this.btnSaveApply.TabIndex = 1;
            this.btnSaveApply.Text = "保存并应用";
            this.btnSaveApply.Click += new System.EventHandler(this.btnSaveApply_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripMenuItem2});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addToolStripMenuItem.Text = "Add New Hosts Item";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem2.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.tlHostlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 485);
            this.panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblstatus,
            this.tslbl2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 463);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblstatus
            // 
            this.tslblstatus.Name = "tslblstatus";
            this.tslblstatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tslbl2
            // 
            this.tslbl2.Name = "tslbl2";
            this.tslbl2.Size = new System.Drawing.Size(0, 17);
            // 
            // HostWizardsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HostWizardsMain";
            this.Text = "HostWizardsMain";
            this.Load += new System.EventHandler(this.HostWizardsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlHostlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlHostlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clIP;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clEnable;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clDomain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clGroup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSaveApply;
        private DevExpress.XtraEditors.SimpleButton btnFlushDns;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clType;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblstatus;
        private System.Windows.Forms.ToolStripStatusLabel tslbl2;
    }
}