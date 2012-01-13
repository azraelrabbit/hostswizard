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

<<<<<<< .mine=======            //this.saveFileDialog1.Filter = "HostsWizards Solution Files|*.hws";
            //saveFileDialog1.DefaultExt = ".hws";
            //saveFileDialog1.AddExtension = true;

>>>>>>> .theirs            //saveFileDialog1.Filter += "|Excel Files|*.xls;*.xlsx";
            //saveFileDialog1.Filter += "|Word Files|*.doc;*.docx";
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
<<<<<<< .mine            //删除

            //得到当前行的RowHandle   
=======            // 删除:
            ////得到当前行的RowHandle   
>>>>>>> .theirs            //DataRow myDataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            var rowItem = (HostsProcesscer)gridView1.FocusedColumn.View.GetRow(gridView1.FocusedColumn.View.GetFocusedDataSourceRowIndex());

            ////去出你想要的字段   
            Guid sid = rowItem.SolutionID;  // (Guid)myDataRow["ID"];
            DL.SolutionDL dl = new SolutionDL();
            dl.DeleteSolution(sid);
            LoadSolutionList();
            BindSolutionList();
            ////导出
                DelSolution(item);
            ////得到当前行的RowHandle   
            //DataRow myDataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            ////去出你想要的字段   
            //Guid sid = (Guid)myDataRow["ID"];
            //var item = solutionList.FirstOrDefault(p => p.SolutionID == sid);
            //if (item != null)
            //{

            //}
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
