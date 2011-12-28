namespace HostsWizard
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlGroup = new System.Windows.Forms.ComboBox();
            this.btnAdditem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtDomain = new DevExpress.XtraEditors.TextEdit();
            this.txtIp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddlGroup);
            this.panel1.Controls.Add(this.btnAdditem);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtDomain);
            this.panel1.Controls.Add(this.txtIp);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 189);
            this.panel1.TabIndex = 0;
            // 
            // ddlGroup
            // 
            this.ddlGroup.FormattingEnabled = true;
            this.ddlGroup.Location = new System.Drawing.Point(93, 15);
            this.ddlGroup.Name = "ddlGroup";
            this.ddlGroup.Size = new System.Drawing.Size(360, 20);
            this.ddlGroup.TabIndex = 10;
            // 
            // btnAdditem
            // 
            this.btnAdditem.Location = new System.Drawing.Point(378, 154);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(75, 23);
            this.btnAdditem.TabIndex = 9;
            this.btnAdditem.Text = "Add Item";
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(93, 90);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(360, 21);
            this.txtDomain.TabIndex = 7;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(93, 51);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(360, 21);
            this.txtIp.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Domain:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "IP:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Group:";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 189);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDomain;
        private DevExpress.XtraEditors.TextEdit txtIp;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAdditem;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ComboBox ddlGroup;
    }
}