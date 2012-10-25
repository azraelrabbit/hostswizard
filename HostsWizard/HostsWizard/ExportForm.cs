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
using HostsWizard.Helpers;
using HostsWizard.DL;

namespace HostsWizard
{
    public partial class frmExportForm : Form
    {
        List<HostsProcesscer> solutionList = new List<HostsProcesscer>();
        public frmExportForm()
        {
            InitializeComponent();
        }


        private void ExportForm_Load(object sender, EventArgs e)
        {
            //多语言
            (new LanguageUtility()).SetCurrentLanguage(this);

            this.saveFileDialog1.Filter = "HostsWizards Solution Files|*.hws";
            saveFileDialog1.DefaultExt = ".hws";
            saveFileDialog1.AddExtension = true;

            //saveFileDialog1.Filter += "|Excel Files|*.xls;*.xlsx";
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
            //导出

            //得到当前行的RowHandle   
            DataRow myDataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //取出你想要的字段   
            Guid sid = (Guid)myDataRow["ID"];
            var item = solutionList.FirstOrDefault(p => p.SolutionID == sid);
            if (item != null)
            {
                ExportSolutionFile(item);
            }
        }

        private void ExportSolutionFile(HostsProcesscer host)
        {

            saveFileDialog1.Filter = "*.hws";
            
            DialogResult dr = saveFileDialog1.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var filePath = saveFileDialog1.FileName;
                byte[] hostcontents = SerializationHelper.GetBinaryFormatSerialize(host);
                FileHelper.WriteSolutionFile(hostcontents, filePath);
                MessageBox.Show("方案已导出到文件:" + filePath);
                // ((frmMainRibbon)this.Owner).SetStatusText("方案已导出到文件:" + filePath);

                string tname = this.Owner.GetType().Name;
                switch (tname)
                {
                    case "frmMain":
                        ((frmMain)this.Owner).SetStatusText("方案已导出到文件:" + filePath);
                        break;
                    case "frmMainR":
                        ((frmMainR)this.Owner).SetStatusText("方案已导出到文件:" + filePath);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
