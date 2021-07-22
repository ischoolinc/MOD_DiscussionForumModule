using System.Windows.Forms;

namespace DiscussionForumModule
{
    partial class HelpContentPanel
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            //this.Web = new EO.WebBrowser.WebView();
            //this.wCtrl1 = new EO.WinForm.WebControl();
            this.SuspendLayout();
            // 
            // Web
            // 
            //this.Web.InputMsgFilter = null;
            //this.Web.ObjectForScripting = null;
            //this.Web.Title = null;
            // 
            // wCtrl1
            // 
            //this.wCtrl1.BackColor = System.Drawing.Color.White;
            //this.wCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.wCtrl1.Location = new System.Drawing.Point(0, 0);
            //this.wCtrl1.Name = "wCtrl1";
            //this.wCtrl1.Size = new System.Drawing.Size(625, 522);
            //this.wCtrl1.TabIndex = 0;
            //this.wCtrl1.WebView = this.Web;
            // 
            // HelpContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Controls.Add(this.wCtrl1);
            this.Name = "HelpContentPanel";
            this.Size = new System.Drawing.Size(625, 522);
            this.ResumeLayout(false);

        }

        #endregion
        //private WebControl wCtrl1;
        //private WebView Web;

    }
}
