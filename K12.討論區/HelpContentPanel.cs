using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiscussionForumModule
{
    public partial class HelpContentPanel : UserControl
    {
        public HelpContentPanel()
        {
            InitializeComponent();

            //EO.WebBrowser.Runtime.AddLicense("mZvLn1mXwAAd457pzf8R7lnb5QUQvFuotcDcr2iptMPboVnq+fPw96ng9vYe" + "wK20psLcrmqns8PbsWqZpAcQ8azg8//ooWunprHavUaBpLHLn3Xq7fgZ4K3s" + "9vbpx23h9cXewI+/uNrsrnzm1QH++ajm+87ou2jq7fgZ4K3s9vbpjEOzs/0U" + "4p7l9/bpjEN14+30EO2s3MKetZ9Zl6TNF+ic3PIEEMidtbjD3rNtqrvJ47Vs" + "s7P9FOKe5ff29ON3hI6xy59Zs/D6DuSn6un26bto4+30EO2s3OnPuIlZl6Sx" + "5+Cl4/MI6YxDl6Sxy59Zl6TNDOOdl/gKG+R2mcng2cKh6fP+EKFZ7ekDHuio" + "5cGz3a9np6ax2r1GgaSxy591puX9F+6wtZE=");
        }


        public void Naviate(string url)
        {
            //Web.Url = url;
        }

        public void GoBack()
        {
            //Web.GoBack();
        }

        public void GoForward()
        {
            //Web.GoForward();
        }

        public void URLRefresh()
        {
            //Web.Reload();
        }

        public void URLStop()
        {
           //Web.StopLoad();
        }
    }
}
