using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FISCA.Presentation;

namespace DiscussionForumModule
{
    public partial class ForumAdmin : BlankPanel
    {
        public ForumAdmin()
        {
            InitializeComponent();

            Group = "客戶服務";
            //helpContentPanel1.Naviate("http://www.ischool.com.tw/");
        
            //helpContentPanel1.Naviate("http://forum.ischool.com.tw/index.php");

            helpContentPanel1.Naviate("https://ischool.zendesk.com/home");

            //helpContentPanel1.Naviate("https://www.facebook.com/pages/ischool-%E6%BE%94%E5%AD%B8/134650313212257");
        }

        private static ForumAdmin _DFM_admin;

        public static ForumAdmin Instance
        {
            get { if (_DFM_admin == null) _DFM_admin = new ForumAdmin(); return _DFM_admin; }
        }

        private void InitializeComponent()
        {
            this.helpContentPanel1 = new HelpContentPanel();
            this.ContentPanePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanePanel
            // 
            this.ContentPanePanel.Controls.Add(this.helpContentPanel1);
            this.ContentPanePanel.Location = new System.Drawing.Point(0, 163);
            this.ContentPanePanel.Size = new System.Drawing.Size(870, 421);
            // 
            // helpContentPanel1
            // 
            this.helpContentPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpContentPanel1.Location = new System.Drawing.Point(0, 0);
            this.helpContentPanel1.Name = "helpContentPanel1";
            this.helpContentPanel1.Size = new System.Drawing.Size(870, 421);
            this.helpContentPanel1.TabIndex = 0;
            // 
            // StuAdmin
            // 
            this.Name = "ForumAdmin";
            this.ContentPanePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void ReSet(string url)
        {
            helpContentPanel1.Naviate(url);
        }

        public void GoBack()
        {
            helpContentPanel1.GoBack();
        }

        public void GoForward()
        {
            helpContentPanel1.GoForward();
        }
        public void URLRefresh()
        {
            helpContentPanel1.URLRefresh();
        }
        public void URLStop()
        {
            helpContentPanel1.URLStop();
        }

        public HelpContentPanel helpContentPanel1;
    }
}
