namespace HostsWizard
{
    partial class frmMainR
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
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainR));
            this.clType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clGroup = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlHostlist = new DevExpress.XtraTreeList.TreeList();
            this.clEnable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.clIP = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clDomain = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCDel = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnsAddItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnsAddItems = new DevExpress.XtraBars.BarButtonItem();
            this.btnsAddGroup = new DevExpress.XtraBars.BarButtonItem();
            this.btnsFlushDns = new DevExpress.XtraBars.BarButtonItem();
            this.btnsSaveApply = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.btnsUpdateGoogle = new DevExpress.XtraBars.BarButtonItem();
            this.brsSystemHostsbyTxt = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAddItems = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddGroup = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnFlushDns = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveApply = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMOpenHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNewSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMApply = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMRefreshDns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMSaveSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMBackupHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMRestoreHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMExportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMExportCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMExportOther = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMzhCN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenUS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSolotionMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMSolutions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMEnableDns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMDisableDns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOldUI = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barMenuDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barMuDeleteGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barMuAddItems = new DevExpress.XtraBars.BarButtonItem();
            this.barMuAdditem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.popUpMuChild = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMuGroup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tlHostlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpMuChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMuGroup)).BeginInit();
            this.SuspendLayout();
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
            // clGroup
            // 
            this.clGroup.Caption = "Group";
            this.clGroup.FieldName = "Group";
            this.clGroup.Name = "clGroup";
            this.clGroup.Visible = true;
            this.clGroup.VisibleIndex = 3;
            this.clGroup.Width = 164;
            // 
            // tlHostlist
            // 
            this.tlHostlist.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.tlHostlist.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.tlHostlist.Appearance.Empty.Options.UseBackColor = true;
            this.tlHostlist.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.tlHostlist.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.tlHostlist.Appearance.EvenRow.Options.UseBackColor = true;
            this.tlHostlist.Appearance.EvenRow.Options.UseForeColor = true;
            this.tlHostlist.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.tlHostlist.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.tlHostlist.Appearance.FocusedCell.Options.UseBackColor = true;
            this.tlHostlist.Appearance.FocusedCell.Options.UseForeColor = true;
            this.tlHostlist.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.tlHostlist.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.tlHostlist.Appearance.FocusedRow.Options.UseBackColor = true;
            this.tlHostlist.Appearance.FocusedRow.Options.UseForeColor = true;
            this.tlHostlist.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.tlHostlist.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.tlHostlist.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.tlHostlist.Appearance.FooterPanel.Options.UseBackColor = true;
            this.tlHostlist.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.tlHostlist.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tlHostlist.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.tlHostlist.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.tlHostlist.Appearance.GroupButton.Options.UseBackColor = true;
            this.tlHostlist.Appearance.GroupButton.Options.UseBorderColor = true;
            this.tlHostlist.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlHostlist.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.tlHostlist.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.tlHostlist.Appearance.GroupFooter.Options.UseBackColor = true;
            this.tlHostlist.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.tlHostlist.Appearance.GroupFooter.Options.UseForeColor = true;
            this.tlHostlist.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.tlHostlist.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(124)))));
            this.tlHostlist.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.tlHostlist.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.tlHostlist.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.tlHostlist.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tlHostlist.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.tlHostlist.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(232)))));
            this.tlHostlist.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.tlHostlist.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.tlHostlist.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.tlHostlist.Appearance.HorzLine.Options.UseBackColor = true;
            this.tlHostlist.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(208)))));
            this.tlHostlist.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.tlHostlist.Appearance.OddRow.Options.UseBackColor = true;
            this.tlHostlist.Appearance.OddRow.Options.UseForeColor = true;
            this.tlHostlist.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.tlHostlist.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.tlHostlist.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(146)))), ((int)(((byte)(78)))));
            this.tlHostlist.Appearance.Preview.Options.UseBackColor = true;
            this.tlHostlist.Appearance.Preview.Options.UseFont = true;
            this.tlHostlist.Appearance.Preview.Options.UseForeColor = true;
            this.tlHostlist.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.tlHostlist.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.tlHostlist.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.tlHostlist.Appearance.Row.Options.UseBackColor = true;
            this.tlHostlist.Appearance.Row.Options.UseBorderColor = true;
            this.tlHostlist.Appearance.Row.Options.UseForeColor = true;
            this.tlHostlist.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(167)))), ((int)(((byte)(103)))));
            this.tlHostlist.Appearance.SelectedRow.Options.UseBackColor = true;
            this.tlHostlist.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(153)))), ((int)(((byte)(73)))));
            this.tlHostlist.Appearance.TreeLine.Options.UseBackColor = true;
            this.tlHostlist.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(177)))), ((int)(((byte)(94)))));
            this.tlHostlist.Appearance.VertLine.Options.UseBackColor = true;
            this.tlHostlist.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.clEnable,
            this.clIP,
            this.clDomain,
            this.clGroup,
            this.clType});
            this.tlHostlist.CustomizationFormBounds = new System.Drawing.Rectangle(742, 532, 216, 187);
            this.tlHostlist.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            styleFormatCondition1.Appearance.BorderColor = System.Drawing.Color.Navy;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseBorderColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "IsNullOrEmpty([Group])";
            this.tlHostlist.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1});
            this.tlHostlist.Location = new System.Drawing.Point(0, 0);
            this.tlHostlist.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.tlHostlist.Margin = new System.Windows.Forms.Padding(3, 3, 21, 3);
            this.tlHostlist.Name = "tlHostlist";
            this.tlHostlist.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.tlHostlist.OptionsView.EnableAppearanceEvenRow = true;
            this.tlHostlist.OptionsView.EnableAppearanceOddRow = true;
            this.tlHostlist.OptionsView.ShowCheckBoxes = true;
            this.tlHostlist.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.tlHostlist.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.tlHostlist.Size = new System.Drawing.Size(907, 400);
            this.tlHostlist.TabIndex = 0;
            this.tlHostlist.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always;
            this.tlHostlist.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.tlHostlist_AfterExpand);
            this.tlHostlist.AfterCollapse += new DevExpress.XtraTreeList.NodeEventHandler(this.tlHostlist_AfterCollapse);
            this.tlHostlist.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlHostlist_AfterCheckNode);
            this.tlHostlist.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.tlHostlist_CellValueChanged);
            this.tlHostlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlHostlist_MouseDown);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // tsCDel
            // 
            this.tsCDel.Name = "tsCDel";
            this.tsCDel.Size = new System.Drawing.Size(113, 22);
            this.tsCDel.Text = "Delete";
            this.tsCDel.Click += new System.EventHandler(this.tsCDel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnAddGroup);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.btnFlushDns);
            this.panel1.Controls.Add(this.btnSaveApply);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 121);
            this.panel1.TabIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = global::HostsWizard.Resources.Global_en_US.aboutMsg;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnsAddItem,
            this.btnsAddItems,
            this.btnsAddGroup,
            this.btnsFlushDns,
            this.btnsSaveApply,
            this.barButtonGroup1,
            this.btnsUpdateGoogle,
            this.brsSystemHostsbyTxt});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 27);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(907, 97);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnsAddItem
            // 
            this.btnsAddItem.Caption = "添加项";
            this.btnsAddItem.Glyph = global::HostsWizard.Properties.Resources.bonus48x48_18;
            this.btnsAddItem.Id = 1;
            this.btnsAddItem.Name = "btnsAddItem";
            this.btnsAddItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnsAddItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsAddItem_ItemClick);
            // 
            // btnsAddItems
            // 
            this.btnsAddItems.Caption = "批量添加项";
            this.btnsAddItems.Glyph = global::HostsWizard.Properties.Resources.bonus48x48_21;
            this.btnsAddItems.Id = 2;
            this.btnsAddItems.Name = "btnsAddItems";
            this.btnsAddItems.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnsAddItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsAddItems_ItemClick);
            // 
            // btnsAddGroup
            // 
            this.btnsAddGroup.Caption = "添加组";
            this.btnsAddGroup.Glyph = global::HostsWizard.Properties.Resources.onebit_13;
            this.btnsAddGroup.Id = 3;
            this.btnsAddGroup.Name = "btnsAddGroup";
            this.btnsAddGroup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnsAddGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsAddGroup_ItemClick);
            // 
            // btnsFlushDns
            // 
            this.btnsFlushDns.Caption = "刷新DNS缓存";
            this.btnsFlushDns.Glyph = global::HostsWizard.Properties.Resources.bonus48x48_04;
            this.btnsFlushDns.Id = 4;
            this.btnsFlushDns.Name = "btnsFlushDns";
            this.btnsFlushDns.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnsFlushDns.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsFlushDns_ItemClick);
            // 
            // btnsSaveApply
            // 
            this.btnsSaveApply.Caption = "应用";
            this.btnsSaveApply.Glyph = global::HostsWizard.Properties.Resources.onebit_25;
            this.btnsSaveApply.Id = 5;
            this.btnsSaveApply.Name = "btnsSaveApply";
            this.btnsSaveApply.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnsSaveApply.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsSaveApply_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 6;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnsUpdateGoogle
            // 
            this.btnsUpdateGoogle.Caption = "更新GoogleHosts项";
            this.btnsUpdateGoogle.Glyph = global::HostsWizard.Properties.Resources.bonus48x48_22;
            this.btnsUpdateGoogle.Id = 7;
            this.btnsUpdateGoogle.Name = "btnsUpdateGoogle";
            this.btnsUpdateGoogle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnsUpdateGoogle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsUpdateGoogle_ItemClick);
            // 
            // brsSystemHostsbyTxt
            // 
            this.brsSystemHostsbyTxt.Caption = "用记事本打开Hosts";
            this.brsSystemHostsbyTxt.Glyph = global::HostsWizard.Properties.Resources.onebit_39;
            this.brsSystemHostsbyTxt.Id = 8;
            this.brsSystemHostsbyTxt.Name = "brsSystemHostsbyTxt";
            this.brsSystemHostsbyTxt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.brsSystemHostsbyTxt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brsSystemHostsbyTxt_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tools";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnsAddItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnsAddItems);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnsAddGroup);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnsFlushDns);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnsSaveApply);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tool Bar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "    ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "    ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnsUpdateGoogle);
            this.ribbonPageGroup4.ItemLinks.Add(this.brsSystemHostsbyTxt);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Other Commands";
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(124, 33);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnAddItems.Size = new System.Drawing.Size(102, 32);
            this.btnAddItems.TabIndex = 5;
            this.btnAddItems.Text = "Add Hosts Items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(236, 36);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnAddGroup.Size = new System.Drawing.Size(102, 32);
            this.btnAddGroup.TabIndex = 4;
            this.btnAddGroup.Text = "Add Group Item";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 34);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnAddItem.Size = new System.Drawing.Size(102, 32);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Hosts Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnFlushDns
            // 
            this.btnFlushDns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlushDns.Location = new System.Drawing.Point(631, 35);
            this.btnFlushDns.Name = "btnFlushDns";
            this.btnFlushDns.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnFlushDns.Size = new System.Drawing.Size(119, 32);
            this.btnFlushDns.TabIndex = 2;
            this.btnFlushDns.Text = "Refresh DNS Cache";
            this.btnFlushDns.Click += new System.EventHandler(this.btnFlushDns_Click);
            // 
            // btnSaveApply
            // 
            this.btnSaveApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveApply.Location = new System.Drawing.Point(779, 34);
            this.btnSaveApply.Name = "btnSaveApply";
            this.btnSaveApply.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnSaveApply.Size = new System.Drawing.Size(113, 32);
            this.btnSaveApply.TabIndex = 1;
            this.btnSaveApply.Text = "Save And Apply";
            this.btnSaveApply.Click += new System.EventHandler(this.btnSaveApply_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMFile,
            this.tsMEdit,
            this.tsMSolutions,
            this.tsMHelp,
            this.tlsSearch,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMFile
            // 
            this.tsMFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMOpenHosts,
            this.tsMNewSolution,
            this.tsmSaveAs,
            this.tsMApply,
            this.tsMRefreshDns,
            this.tsMSaveSolution,
            this.tsMExit});
            this.tsMFile.Name = "tsMFile";
            this.tsMFile.Size = new System.Drawing.Size(39, 23);
            this.tsMFile.Text = "File";
            // 
            // tsMOpenHosts
            // 
            this.tsMOpenHosts.Name = "tsMOpenHosts";
            this.tsMOpenHosts.Size = new System.Drawing.Size(234, 22);
            this.tsMOpenHosts.Text = "Open System Hosts";
            this.tsMOpenHosts.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tsMNewSolution
            // 
            this.tsMNewSolution.Name = "tsMNewSolution";
            this.tsMNewSolution.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsMNewSolution.Size = new System.Drawing.Size(234, 22);
            this.tsMNewSolution.Text = "New Solution";
            this.tsMNewSolution.Click += new System.EventHandler(this.createNewSolutionToolStripMenuItem_Click);
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.Size = new System.Drawing.Size(234, 22);
            this.tsmSaveAs.Text = "Save As";
            this.tsmSaveAs.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tsMApply
            // 
            this.tsMApply.Name = "tsMApply";
            this.tsMApply.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsMApply.Size = new System.Drawing.Size(234, 22);
            this.tsMApply.Text = "Apply";
            this.tsMApply.Click += new System.EventHandler(this.saveAndApplyToolStripMenuItem_Click);
            // 
            // tsMRefreshDns
            // 
            this.tsMRefreshDns.Name = "tsMRefreshDns";
            this.tsMRefreshDns.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsMRefreshDns.Size = new System.Drawing.Size(234, 22);
            this.tsMRefreshDns.Text = "Refresh DNS Cache";
            this.tsMRefreshDns.Click += new System.EventHandler(this.refreshDNSCacheToolStripMenuItem_Click);
            // 
            // tsMSaveSolution
            // 
            this.tsMSaveSolution.Name = "tsMSaveSolution";
            this.tsMSaveSolution.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsMSaveSolution.Size = new System.Drawing.Size(234, 22);
            this.tsMSaveSolution.Text = "Save Solution";
            this.tsMSaveSolution.Click += new System.EventHandler(this.tsMenuUpdateSolution_Click);
            // 
            // tsMExit
            // 
            this.tsMExit.Name = "tsMExit";
            this.tsMExit.Size = new System.Drawing.Size(234, 22);
            this.tsMExit.Text = "Exit";
            this.tsMExit.Click += new System.EventHandler(this.tsMExit_Click);
            // 
            // tsMEdit
            // 
            this.tsMEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMBackupHosts,
            this.tsMRestoreHosts,
            this.tsMExportMenu,
            this.tsMImport,
            this.tsMLanguage,
            this.tsmSolotionMgr});
            this.tsMEdit.Name = "tsMEdit";
            this.tsMEdit.Size = new System.Drawing.Size(42, 23);
            this.tsMEdit.Text = "Edit";
            // 
            // tsMBackupHosts
            // 
            this.tsMBackupHosts.Name = "tsMBackupHosts";
            this.tsMBackupHosts.Size = new System.Drawing.Size(207, 22);
            this.tsMBackupHosts.Text = "Backup System Hosts";
            this.tsMBackupHosts.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // tsMRestoreHosts
            // 
            this.tsMRestoreHosts.Enabled = false;
            this.tsMRestoreHosts.Name = "tsMRestoreHosts";
            this.tsMRestoreHosts.Size = new System.Drawing.Size(207, 22);
            this.tsMRestoreHosts.Text = "Restore System Hosts ";
            // 
            // tsMExportMenu
            // 
            this.tsMExportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMExportCurrent,
            this.tsMExportOther});
            this.tsMExportMenu.Name = "tsMExportMenu";
            this.tsMExportMenu.Size = new System.Drawing.Size(207, 22);
            this.tsMExportMenu.Text = "Export Solution ...";
            this.tsMExportMenu.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // tsMExportCurrent
            // 
            this.tsMExportCurrent.Name = "tsMExportCurrent";
            this.tsMExportCurrent.Size = new System.Drawing.Size(170, 22);
            this.tsMExportCurrent.Text = "Export Current";
            this.tsMExportCurrent.Click += new System.EventHandler(this.exportCurrentToolStripMenuItem_Click);
            // 
            // tsMExportOther
            // 
            this.tsMExportOther.Name = "tsMExportOther";
            this.tsMExportOther.Size = new System.Drawing.Size(170, 22);
            this.tsMExportOther.Text = "Export Others ...";
            this.tsMExportOther.Click += new System.EventHandler(this.exportOthersToolStripMenuItem_Click);
            // 
            // tsMImport
            // 
            this.tsMImport.Name = "tsMImport";
            this.tsMImport.Size = new System.Drawing.Size(207, 22);
            this.tsMImport.Text = "Import Solution ...";
            this.tsMImport.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // tsMLanguage
            // 
            this.tsMLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMzhCN,
            this.tsMenUS});
            this.tsMLanguage.Name = "tsMLanguage";
            this.tsMLanguage.Size = new System.Drawing.Size(207, 22);
            this.tsMLanguage.Text = "Languages";
            // 
            // tsMzhCN
            // 
            this.tsMzhCN.Name = "tsMzhCN";
            this.tsMzhCN.Size = new System.Drawing.Size(182, 22);
            this.tsMzhCN.Text = "Chinese Simplified";
            this.tsMzhCN.Click += new System.EventHandler(this.tsMzhCN_Click);
            // 
            // tsMenUS
            // 
            this.tsMenUS.Name = "tsMenUS";
            this.tsMenUS.Size = new System.Drawing.Size(182, 22);
            this.tsMenUS.Text = "English";
            this.tsMenUS.Click += new System.EventHandler(this.tsMenUS_Click);
            // 
            // tsmSolotionMgr
            // 
            this.tsmSolotionMgr.Name = "tsmSolotionMgr";
            this.tsmSolotionMgr.Size = new System.Drawing.Size(207, 22);
            this.tsmSolotionMgr.Text = "Solution Manager...";
            this.tsmSolotionMgr.Click += new System.EventHandler(this.tsmSolotionMgr_Click);
            // 
            // tsMSolutions
            // 
            this.tsMSolutions.CheckOnClick = true;
            this.tsMSolutions.Name = "tsMSolutions";
            this.tsMSolutions.Size = new System.Drawing.Size(73, 23);
            this.tsMSolutions.Text = "Solutions";
            // 
            // tsMHelp
            // 
            this.tsMHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMAbout,
            this.tsMEnableDns,
            this.tsMDisableDns,
            this.tsmUpdateGoogle,
            this.tsmOldUI});
            this.tsMHelp.Name = "tsMHelp";
            this.tsMHelp.Size = new System.Drawing.Size(47, 23);
            this.tsMHelp.Text = "Help";
            // 
            // tsMAbout
            // 
            this.tsMAbout.Name = "tsMAbout";
            this.tsMAbout.Size = new System.Drawing.Size(203, 22);
            this.tsMAbout.Text = "About";
            this.tsMAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // tsMEnableDns
            // 
            this.tsMEnableDns.Name = "tsMEnableDns";
            this.tsMEnableDns.Size = new System.Drawing.Size(203, 22);
            this.tsMEnableDns.Text = "Enable Dns Cache";
            this.tsMEnableDns.Click += new System.EventHandler(this.tsMEnableDns_Click);
            // 
            // tsMDisableDns
            // 
            this.tsMDisableDns.Name = "tsMDisableDns";
            this.tsMDisableDns.Size = new System.Drawing.Size(203, 22);
            this.tsMDisableDns.Text = "Disable Dns Cache";
            this.tsMDisableDns.Click += new System.EventHandler(this.tsMDisableDns_Click);
            // 
            // tsmUpdateGoogle
            // 
            this.tsmUpdateGoogle.Name = "tsmUpdateGoogle";
            this.tsmUpdateGoogle.Size = new System.Drawing.Size(203, 22);
            this.tsmUpdateGoogle.Text = "Update Google Hosts";
            this.tsmUpdateGoogle.Click += new System.EventHandler(this.tsmUpdateGoogle_Click_1);
            // 
            // tsmOldUI
            // 
            this.tsmOldUI.Name = "tsmOldUI";
            this.tsmOldUI.Size = new System.Drawing.Size(203, 22);
            this.tsmOldUI.Text = "Old UI";
            this.tsmOldUI.Click += new System.EventHandler(this.oldUIToolStripMenuItem_Click);
            // 
            // tlsSearch
            // 
            this.tlsSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsSearch.Name = "tlsSearch";
            this.tlsSearch.Size = new System.Drawing.Size(100, 23);
            this.tlsSearch.TextChanged += new System.EventHandler(this.tlsSearch_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 23);
            this.toolStripMenuItem1.Text = "X";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tlHostlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.panel2.Size = new System.Drawing.Size(907, 424);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 522);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 23);
            this.panel3.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblstatus,
            this.tslbl2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 4;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barMenuDelete,
            this.barMuDeleteGroup,
            this.barMuAddItems,
            this.barMuAdditem,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(907, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 545);
            this.barDockControlBottom.Size = new System.Drawing.Size(907, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 545);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(907, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 545);
            // 
            // barMenuDelete
            // 
            this.barMenuDelete.Caption = "Delete";
            this.barMenuDelete.Id = 0;
            this.barMenuDelete.Name = "barMenuDelete";
            this.barMenuDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMenuDelete_ItemClick);
            // 
            // barMuDeleteGroup
            // 
            this.barMuDeleteGroup.Caption = "Delete";
            this.barMuDeleteGroup.Id = 1;
            this.barMuDeleteGroup.Name = "barMuDeleteGroup";
            this.barMuDeleteGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMuDeleteGroup_ItemClick);
            // 
            // barMuAddItems
            // 
            this.barMuAddItems.Caption = "Add Items";
            this.barMuAddItems.Id = 2;
            this.barMuAddItems.Name = "barMuAddItems";
            this.barMuAddItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMuAddItems_ItemClick);
            // 
            // barMuAdditem
            // 
            this.barMuAdditem.Caption = "Add Item";
            this.barMuAdditem.Id = 3;
            this.barMuAdditem.Name = "barMuAdditem";
            this.barMuAdditem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // popUpMuChild
            // 
            this.popUpMuChild.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barMenuDelete)});
            this.popUpMuChild.Manager = this.barManager1;
            this.popUpMuChild.Name = "popUpMuChild";
            // 
            // popupMuGroup
            // 
            this.popupMuGroup.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barMuDeleteGroup),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMuAddItems),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, this.barMuAdditem, "Add Item")});
            this.popupMuGroup.Manager = this.barManager1;
            this.popupMuGroup.Name = "popupMuGroup";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // frmMainR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainR";
            this.Text = "HostWizardsMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.HostWizardsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlHostlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpMuChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMuGroup)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem tsMFile;
        private System.Windows.Forms.ToolStripMenuItem tsMOpenHosts;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsMEdit;
        private System.Windows.Forms.ToolStripMenuItem tsMBackupHosts;
        private System.Windows.Forms.ToolStripMenuItem tsMRestoreHosts;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSaveApply;
        private DevExpress.XtraEditors.SimpleButton btnFlushDns;
        private DevExpress.XtraTreeList.Columns.TreeListColumn clType;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraEditors.SimpleButton btnAddGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblstatus;
        private System.Windows.Forms.ToolStripStatusLabel tslbl2;
        private System.Windows.Forms.ToolStripMenuItem tsMHelp;
        private System.Windows.Forms.ToolStripMenuItem tsMAbout;
        private System.Windows.Forms.ToolStripMenuItem tsMApply;
        private System.Windows.Forms.ToolStripMenuItem tsMRefreshDns;
        private System.Windows.Forms.ToolStripMenuItem tsMSolutions;
        private System.Windows.Forms.ToolStripMenuItem tsMSaveSolution;
        private System.Windows.Forms.ToolStripMenuItem tsMNewSolution;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsCDel;
        private System.Windows.Forms.ToolStripMenuItem tsMExportMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMImport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsMExportCurrent;
        private System.Windows.Forms.ToolStripMenuItem tsMExportOther;
        private System.Windows.Forms.ToolStripMenuItem tsMExit;
        private System.Windows.Forms.ToolStripMenuItem tsMLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsMzhCN;
        private System.Windows.Forms.ToolStripMenuItem tsMenUS;
        private DevExpress.XtraEditors.SimpleButton btnAddItems;
        private System.Windows.Forms.ToolStripMenuItem tsmSolotionMgr;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popUpMuChild;
        private DevExpress.XtraBars.BarButtonItem barMenuDelete;
        private DevExpress.XtraBars.BarButtonItem barMuDeleteGroup;
        private DevExpress.XtraBars.BarButtonItem barMuAddItems;
        private DevExpress.XtraBars.BarButtonItem barMuAdditem;
        private DevExpress.XtraBars.PopupMenu popupMuGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.ToolStripMenuItem tsMEnableDns;
        private System.Windows.Forms.ToolStripMenuItem tsMDisableDns;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateGoogle;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnsAddItem;
        private DevExpress.XtraBars.BarButtonItem btnsAddItems;
        private DevExpress.XtraBars.BarButtonItem btnsAddGroup;
        private DevExpress.XtraBars.BarButtonItem btnsFlushDns;
        private DevExpress.XtraBars.BarButtonItem btnsSaveApply;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnsUpdateGoogle;
        private System.Windows.Forms.ToolStripMenuItem tsmOldUI;
        private DevExpress.XtraBars.BarButtonItem brsSystemHostsbyTxt;
        private System.Windows.Forms.ToolStripTextBox tlsSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}