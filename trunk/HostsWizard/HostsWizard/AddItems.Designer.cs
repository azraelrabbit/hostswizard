namespace HostsWizard
{
    partial class AddItems
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ddlGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveBack = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtcAddItems = new DevExpress.XtraTab.XtraTabControl();
            this.xtpAddbyText = new DevExpress.XtraTab.XtraTabPage();
            this.xtpAddbyLists = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcAddItems)).BeginInit();
            this.xtcAddItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ddlGroup);
            this.panelControl1.Controls.Add(this.lblGroup);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSaveBack);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 465);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(626, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // ddlGroup
            // 
            this.ddlGroup.FormattingEnabled = true;
            this.ddlGroup.Location = new System.Drawing.Point(74, 8);
            this.ddlGroup.Name = "ddlGroup";
            this.ddlGroup.Size = new System.Drawing.Size(295, 20);
            this.ddlGroup.TabIndex = 12;
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(3, 8);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(37, 14);
            this.lblGroup.TabIndex = 11;
            this.lblGroup.Text = "Group:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(387, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSaveBack
            // 
            this.btnSaveBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBack.Location = new System.Drawing.Point(506, 5);
            this.btnSaveBack.Name = "btnSaveBack";
            this.btnSaveBack.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.btnSaveBack.Size = new System.Drawing.Size(113, 32);
            this.btnSaveBack.TabIndex = 2;
            this.btnSaveBack.Text = "Save And Back";
            this.btnSaveBack.Click += new System.EventHandler(this.btnSaveBack_Click_1);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.xtcAddItems);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(626, 465);
            this.panelControl2.TabIndex = 3;
            // 
            // xtcAddItems
            // 
            this.xtcAddItems.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(),
            new DevExpress.XtraTab.Buttons.CustomHeaderButton()});
            this.xtcAddItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcAddItems.Location = new System.Drawing.Point(3, 3);
            this.xtcAddItems.Name = "xtcAddItems";
            this.xtcAddItems.SelectedTabPage = this.xtpAddbyText;
            this.xtcAddItems.Size = new System.Drawing.Size(620, 459);
            this.xtcAddItems.TabIndex = 1;
            this.xtcAddItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpAddbyText,
            this.xtpAddbyLists});
            this.xtcAddItems.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtcAddItems_SelectedPageChanging);
            this.xtcAddItems.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtpAddbyText
            // 
            this.xtpAddbyText.Name = "xtpAddbyText";
            this.xtpAddbyText.Size = new System.Drawing.Size(618, 436);
            this.xtpAddbyText.Text = "Add By Text";
            // 
            // xtpAddbyLists
            // 
            this.xtpAddbyLists.Name = "xtpAddbyLists";
            this.xtpAddbyLists.Size = new System.Drawing.Size(618, 436);
            this.xtpAddbyLists.Text = "Add By List";
            // 
            // AddItems
            // 
            this.AcceptButton = this.btnSaveBack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(626, 505);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcAddItems)).EndInit();
            this.xtcAddItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSaveBack;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabControl xtcAddItems;
        private DevExpress.XtraTab.XtraTabPage xtpAddbyText;
        private DevExpress.XtraTab.XtraTabPage xtpAddbyLists;
        private System.Windows.Forms.ComboBox ddlGroup;
        private DevExpress.XtraEditors.LabelControl lblGroup;
    }
}