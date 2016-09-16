using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.Layout;
using DevExpress.XtraEditors;
using System.Drawing;

namespace QLKS
{
    public class Add
    {        
        public void AddTab(DevExpress.XtraTab.XtraTabControl XtraTabCha, string icon, string TabNameAdd, Form UserControl)
        {
           
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
          
            TAbAdd.Name = "TestTab";
            
            TAbAdd.Text = TabNameAdd;
          
            UserControl.TopLevel = false;
            UserControl.Parent = TAbAdd;
          
            UserControl.Dock = DockStyle.Fill;
            
            XtraTabCha.TabPages.Add(TAbAdd);
            UserControl.Show();

        }
    }
}

