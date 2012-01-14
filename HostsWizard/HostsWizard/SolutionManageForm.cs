using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HostsWizard.Utilit;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraPrinting;
using HostsWizard.Helpers;
using HostsWizard.DL;

namespace HostsWizard
{
    public partial class SolutionManageForm : Form
    {
        List<HostsProcesscer> solutionList = new List<HostsProcesscer>();
        public SolutionManageForm()
        {
            InitializeComponent();
        }

        private void SolutionManageForm_Load(object sender, EventArgs e)
        {
            //多语言
            (new LanguageUtility()).SetCurrentLanguage(this);

            LoadSolutionList();
            BindSolutionList();
        }

        private void LoadSolutionList()
        {
            SolutionDL dl = new SolutionDL();
            solutionList = dl.GetSolutionAll();
        }

        private void BindSolutionList()
        {
            gridControl1.DataSource = solutionList;
        }

        private void btnExport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            // 删除:
            ////得到当前行的RowHandle   

            var rowItem = (HostsProcesscer)gridView1.FocusedColumn.View.GetRow(gridView1.FocusedColumn.View.GetFocusedDataSourceRowIndex());
            DelSolution(rowItem);

        }

        private void DelSolution(HostsProcesscer host)
        {

            // saveFileDialog1.Filter = "*.hws";
            // DialogResult dr = saveFileDialog1.ShowDialog(this);
            DialogResult dr = MessageBox.Show("确认删除方案:" + host.SolutionName + " ?", "注意", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                SolutionDL dl = new SolutionDL();
                dl.DeleteSolution(host.SolutionID);
                LoadSolutionList();
                BindSolutionList();
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolutionManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmMain)this.Owner).ReloadSolution();
        }

    }
}
