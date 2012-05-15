using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace HostsWizard.Utilit
{
    public class LanguageUtility
    {

        public LanguageUtility()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lang">"zh-ch"-简体中文,"en-us"-English</param>
        public void SetCurrentLanguage(string lang, Form form)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            this.SetLanguage(form);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lang">"zh-ch"-简体中文,"en-us"-English</param>
        public void SetCurrentLanguage(Form form)
        {
            var lang = AppConfigHelper.GetAppConfig("Language");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            this.SetLanguage(form);


        }

        private string formName;

        public ResourceManager GetCurrentCulture()
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-TW");
            ResourceManager rm = new ResourceManager("HostsWizard.Resources.Global", Assembly.GetExecutingAssembly());
            return rm;
        }

        public System.Drawing.Bitmap GetImage(string strObjectId)
        {
            ResourceManager rm = GetCurrentCulture();
            object obj = rm.GetObject(strObjectId);
            return (System.Drawing.Bitmap)obj;
        }

        public string getMsg(string strId)
        {
            string currentLanguage = string.Empty;
            try
            {
                ResourceManager rm = GetCurrentCulture();
                CultureInfo ci = Thread.CurrentThread.CurrentCulture;

                currentLanguage = rm.GetString(strId, ci);
            }
            catch (Exception ex)
            {
                // currentLanguage = "Cannot Found:" + strId + " , Please Add it to Resource File.";
                // currentLanguage = string.Empty;
                var er = ex.Message;
            }
            return currentLanguage;

        }

        public void SetLanguage(System.Windows.Forms.Control control)
        {
            //MessageBox.Show(control.GetType().BaseType.Name);
            if (control.GetType().BaseType.Name == "Form")
            {
                formName = control.Name.Replace("frmMainR", "frmMain") + "_";

                control.Text = getMsg(control.Name.Replace("frmMainR", "frmMain"));
            }

            if (control.GetType() == typeof(MenuStrip))
            {
                var tst = getMsg(formName + control.Name);
                if (!string.IsNullOrEmpty(tst))
                {
                    control.Text = tst;
                }
                if (((MenuStrip)control).Items.Count > 0)
                {
                    ForeachMenu(((MenuStrip)control).Items);
                }
            }

            for (int i = 0; i < control.Controls.Count; i++)
            {
                //若在资源文件中设置了值,则替换为对应语言
                var text = getMsg(formName + control.Controls[i].Name);
                if (!string.IsNullOrEmpty(text))
                {
                    control.Controls[i].Text = text;
                }
                if (control.Controls[i].HasChildren)
                {
                    SetLanguage(control.Controls[i]);
                }
                else
                {
                    var item = control.Controls[i];
                    if (item.GetType() == typeof(MenuStrip))
                    {
                        var tst = getMsg(formName + item.Name);
                        if (!string.IsNullOrEmpty(tst))
                        {
                            item.Text = tst;
                        }
                        if (((MenuStrip)item).Items.Count > 0)
                        {
                            ForeachMenu(((MenuStrip)item).Items);
                        }
                    }
                    else if (item.GetType() == typeof(ToolStripMenuItem))
                    {
                        var tst = getMsg(formName + item.Name);
                        if (!string.IsNullOrEmpty(tst))
                        {
                            item.Text = tst;
                        }
                        //if (((ToolStripMenuItem)item).Items.Count > 0)
                        //{
                        //    ForeachMenu(((MenuItem)item).Items);
                        //}
                    }
                    else if (item.GetType() == typeof(DevExpress.XtraBars.BarButtonItem))
                    {
                        var tst = getMsg(formName + item.Name);
                        if (!string.IsNullOrEmpty(tst))
                        {
                            item.Text = tst;
                        }
                    }
                }

                //MessageBox.Show(
                //  control.Controls[i].GetType().Name + 
                //  "-" + control.Controls[i].Name);

                //2011-12-29 r.k
                //switch (control.Controls[i].GetType().Name)
                //{
                //    case "Label":
                //    case "Button":
                //    case "CheckBox":
                //    case "LinkLabel":
                //        control.Controls[i].Text = getMsg(
                //            formName + control.Controls[i].Name);
                //        break;
                //    case "Panel":
                //        SetLanguage(control.Controls[i]);
                //        break;
                //    case "TabControl":
                //        TabControl tbc = (TabControl)control.Controls[i];
                //        for (int j = 0; j < tbc.TabCount; j++)
                //        {
                //            tbc.TabPages[j].Text = getMsg(
                //                formName + tbc.TabPages[j].Name);
                //            SetLanguage(tbc.TabPages[j]);
                //        }
                //        break;
                //    default:
                //        break;
                //}
            }
            //foreach (var item in control.Controls)
            //{
            //    //((HostsWizard.frmMain)control).Controls.Cast<Control>().Where(p=>p.;
            //    Type type = item.GetType();
            //    switch (type.Name)
            //    {
            //        case "BarButtonItem":
            //            var obj = ((DevExpress.XtraBars.BarButtonItem)item);
            //            obj.Caption = getMsg(formName + obj.Name);
            //            break;
            //        case "BarCheckItem":
            //            var obj1 = ((DevExpress.XtraBars.BarCheckItem)item);
            //            obj1.Caption = getMsg(formName + obj1.Name);
            //            break;
            //        case "BarSubItem":
            //            var obj2 = ((DevExpress.XtraBars.BarCheckItem)item);
            //            obj2.Caption = getMsg(formName + obj2.Name);
            //            break;
            //        default:
            //            break;
            //    }



            //}
        }

        private void ForeachMenu(ToolStripItemCollection menustrips)
        {
            foreach (ToolStripItem item in menustrips)
            {
                var it = item as ToolStripMenuItem;
                if (it != null)
                {
                    var tst = getMsg(formName + it.Name);
                    if (!string.IsNullOrEmpty(tst))
                    {
                        it.Text = tst;
                    }

                    if (it.HasDropDownItems)
                    {
                        ForeachMenu(it.DropDownItems);
                    }
                }

            }
        }
    }
}