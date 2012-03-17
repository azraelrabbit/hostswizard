namespace HostsWizard
{
    partial class RibbonMain
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
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMFile,
            this.tsMEdit,
            this.tsMSolutions,
            this.tsMHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 25);
            this.menuStrip1.TabIndex = 1;
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
            this.tsMFile.Size = new System.Drawing.Size(39, 21);
            this.tsMFile.Text = "File";
            // 
            // tsMOpenHosts
            // 
            this.tsMOpenHosts.Name = "tsMOpenHosts";
            this.tsMOpenHosts.Size = new System.Drawing.Size(234, 22);
            this.tsMOpenHosts.Text = "Open System Hosts";
            // 
            // tsMNewSolution
            // 
            this.tsMNewSolution.Name = "tsMNewSolution";
            this.tsMNewSolution.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsMNewSolution.Size = new System.Drawing.Size(234, 22);
            this.tsMNewSolution.Text = "New Solution";
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.Size = new System.Drawing.Size(234, 22);
            this.tsmSaveAs.Text = "Save As";
            // 
            // tsMApply
            // 
            this.tsMApply.Name = "tsMApply";
            this.tsMApply.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsMApply.Size = new System.Drawing.Size(234, 22);
            this.tsMApply.Text = "Apply";
            // 
            // tsMRefreshDns
            // 
            this.tsMRefreshDns.Name = "tsMRefreshDns";
            this.tsMRefreshDns.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsMRefreshDns.Size = new System.Drawing.Size(234, 22);
            this.tsMRefreshDns.Text = "Refresh DNS Cache";
            // 
            // tsMSaveSolution
            // 
            this.tsMSaveSolution.Name = "tsMSaveSolution";
            this.tsMSaveSolution.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.S)));
            this.tsMSaveSolution.Size = new System.Drawing.Size(234, 22);
            this.tsMSaveSolution.Text = "Save Solution";
            // 
            // tsMExit
            // 
            this.tsMExit.Name = "tsMExit";
            this.tsMExit.Size = new System.Drawing.Size(234, 22);
            this.tsMExit.Text = "Exit";
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
            this.tsMEdit.Size = new System.Drawing.Size(42, 21);
            this.tsMEdit.Text = "Edit";
            // 
            // tsMBackupHosts
            // 
            this.tsMBackupHosts.Name = "tsMBackupHosts";
            this.tsMBackupHosts.Size = new System.Drawing.Size(207, 22);
            this.tsMBackupHosts.Text = "Backup System Hosts";
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
            // 
            // tsMExportCurrent
            // 
            this.tsMExportCurrent.Name = "tsMExportCurrent";
            this.tsMExportCurrent.Size = new System.Drawing.Size(170, 22);
            this.tsMExportCurrent.Text = "Export Current";
            // 
            // tsMExportOther
            // 
            this.tsMExportOther.Name = "tsMExportOther";
            this.tsMExportOther.Size = new System.Drawing.Size(170, 22);
            this.tsMExportOther.Text = "Export Others ...";
            // 
            // tsMImport
            // 
            this.tsMImport.Name = "tsMImport";
            this.tsMImport.Size = new System.Drawing.Size(207, 22);
            this.tsMImport.Text = "Import Solution ...";
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
            // 
            // tsMenUS
            // 
            this.tsMenUS.Name = "tsMenUS";
            this.tsMenUS.Size = new System.Drawing.Size(182, 22);
            this.tsMenUS.Text = "English";
            // 
            // tsmSolotionMgr
            // 
            this.tsmSolotionMgr.Name = "tsmSolotionMgr";
            this.tsmSolotionMgr.Size = new System.Drawing.Size(207, 22);
            this.tsmSolotionMgr.Text = "Solution Manager...";
            // 
            // tsMSolutions
            // 
            this.tsMSolutions.CheckOnClick = true;
            this.tsMSolutions.Name = "tsMSolutions";
            this.tsMSolutions.Size = new System.Drawing.Size(73, 21);
            this.tsMSolutions.Text = "Solutions";
            // 
            // tsMHelp
            // 
            this.tsMHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMAbout,
            this.tsMEnableDns,
            this.tsMDisableDns,
            this.tsmUpdateGoogle});
            this.tsMHelp.Name = "tsMHelp";
            this.tsMHelp.Size = new System.Drawing.Size(47, 21);
            this.tsMHelp.Text = "Help";
            // 
            // tsMAbout
            // 
            this.tsMAbout.Name = "tsMAbout";
            this.tsMAbout.Size = new System.Drawing.Size(203, 22);
            this.tsMAbout.Text = "About";
            // 
            // tsMEnableDns
            // 
            this.tsMEnableDns.Name = "tsMEnableDns";
            this.tsMEnableDns.Size = new System.Drawing.Size(203, 22);
            this.tsMEnableDns.Text = "Enable Dns Cache";
            // 
            // tsMDisableDns
            // 
            this.tsMDisableDns.Name = "tsMDisableDns";
            this.tsMDisableDns.Size = new System.Drawing.Size(203, 22);
            this.tsMDisableDns.Text = "Disable Dns Cache";
            // 
            // tsmUpdateGoogle
            // 
            this.tsmUpdateGoogle.Name = "tsmUpdateGoogle";
            this.tsmUpdateGoogle.Size = new System.Drawing.Size(203, 22);
            this.tsmUpdateGoogle.Text = "Update Google Hosts";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
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
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 25);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1062, 146);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 171);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1062, 613);
            this.panelControl1.TabIndex = 3;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // RibbonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 784);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RibbonMain";
            this.Text = "RibbonMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMFile;
        private System.Windows.Forms.ToolStripMenuItem tsMOpenHosts;
        private System.Windows.Forms.ToolStripMenuItem tsMNewSolution;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsMApply;
        private System.Windows.Forms.ToolStripMenuItem tsMRefreshDns;
        private System.Windows.Forms.ToolStripMenuItem tsMSaveSolution;
        private System.Windows.Forms.ToolStripMenuItem tsMExit;
        private System.Windows.Forms.ToolStripMenuItem tsMEdit;
        private System.Windows.Forms.ToolStripMenuItem tsMBackupHosts;
        private System.Windows.Forms.ToolStripMenuItem tsMRestoreHosts;
        private System.Windows.Forms.ToolStripMenuItem tsMExportMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMExportCurrent;
        private System.Windows.Forms.ToolStripMenuItem tsMExportOther;
        private System.Windows.Forms.ToolStripMenuItem tsMImport;
        private System.Windows.Forms.ToolStripMenuItem tsMLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsMzhCN;
        private System.Windows.Forms.ToolStripMenuItem tsMenUS;
        private System.Windows.Forms.ToolStripMenuItem tsmSolotionMgr;
        private System.Windows.Forms.ToolStripMenuItem tsMSolutions;
        private System.Windows.Forms.ToolStripMenuItem tsMHelp;
        private System.Windows.Forms.ToolStripMenuItem tsMAbout;
        private System.Windows.Forms.ToolStripMenuItem tsMEnableDns;
        private System.Windows.Forms.ToolStripMenuItem tsMDisableDns;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateGoogle;
        private DevExpress.XtraEditors.StyleController styleController1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}