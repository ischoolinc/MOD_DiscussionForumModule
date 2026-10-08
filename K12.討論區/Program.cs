using FISCA;
using FISCA.Presentation;
using K12.Data.Configuration;
using System.Xml;

namespace DiscussionForumModule
{
    public static class Program
    {
        [MainMethod("DiscussionForumModule")]
        public static void Main()
        {
            RegisterTab();

            MenuButton rbItem_5 = MotherForm.StartMenu["客戶服務"];
            rbItem_5.Image = Properties.Resources.recepcionist_64;

            rbItem_5["115學年度期初教育訓練"].Click += delegate
            {
                System.Diagnostics.Process.Start("https://support.ischool.com.tw/hc/zh-tw/articles/61385045818905-115-%E5%AD%B8%E5%B9%B4%E5%BA%A6-%E6%9C%9F%E5%88%9D%E6%95%99%E8%82%B2%E8%A8%93%E7%B7%B4");
            };

            rbItem_5["客服網站"].Click += delegate
            {
                System.Diagnostics.Process.Start("https://ischool.zendesk.com/hc/zh-tw");
            };
            
            rbItem_5["加入官方Line@"].Click += delegate
            {
                System.Diagnostics.Process.Start("https://lin.ee/Sh8cPhv");
            };

            rbItem_5["提交客服工單"].Click += delegate
            {
                System.Diagnostics.Process.Start("https://ischool.zendesk.com/hc/zh-tw/requests/new");
            };

            rbItem_5["1Campus應用市集"].Click += delegate
            {
                System.Diagnostics.Process.Start("https://market-test.1campus.net/");
            };
        }

        public static void RegisterTab()
        {
            //MotherForm.AddPanel(ForumAdmin.Instance);

        }
    }
}
