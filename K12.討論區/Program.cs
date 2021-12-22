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

            RibbonBarItem rbItem1 = MotherForm.RibbonBarItems["客戶服務", "網頁功能項目"];
            rbItem1["上一頁"].Enable = false;
            rbItem1["上一頁"].Image = Properties.Resources.first_64;
            rbItem1["上一頁"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["上一頁"].Click += delegate
            {
                ForumAdmin.Instance.GoBack();
            };

            rbItem1["下一頁"].Enable = false;
            rbItem1["下一頁"].Image = Properties.Resources.last_64;
            rbItem1["下一頁"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["下一頁"].Click += delegate
            {
                ForumAdmin.Instance.GoForward();
            };
            rbItem1["重新整理"].Enable = false;
            rbItem1["重新整理"].Image = Properties.Resources.reload_64;
            rbItem1["重新整理"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["重新整理"].Click += delegate
            {
                ForumAdmin.Instance.URLRefresh();
            };
            rbItem1["停止"].Enable = false;
            rbItem1["停止"].Image = Properties.Resources.stop_64;
            rbItem1["停止"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["停止"].Click += delegate
            {
                ForumAdmin.Instance.URLStop();
            };

            RibbonBarItem rbItem2 = MotherForm.RibbonBarItems["客戶服務", "FaceBook"];
            rbItem2["ischool 澔學"].Enable = false;
            rbItem2["ischool 澔學"].Size = RibbonBarButton.MenuButtonSize.Medium;
            rbItem2["ischool 澔學"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/pages/ischool-%E6%BE%94%E5%AD%B8/134650313212257");
            };

            rbItem2["1know粉絲團"].Enable = false;
            rbItem2["1know粉絲團"].Size = RibbonBarButton.MenuButtonSize.Medium;
            rbItem2["1know粉絲團"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/1know.net");
            };

            rbItem2["1Know翻轉你的學習"].Enable = false;
            rbItem2["1Know翻轉你的學習"].Size = RibbonBarButton.MenuButtonSize.Medium;
            rbItem2["1Know翻轉你的學習"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/groups/1know/");
            };

            rbItem2["新竹市1Campus平台"].Enable = false;
            rbItem2["新竹市1Campus平台"].Size = RibbonBarButton.MenuButtonSize.Medium;
            rbItem2["新竹市1Campus平台"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/groups/1462857227381317");
            };

            RibbonBarItem rbItem = MotherForm.RibbonBarItems["客戶服務", "開發者"];
            rbItem["開發者精靈"].Enable = false;
            rbItem["開發者精靈"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem["開發者精靈"].Image = Properties.Resources.technology_64;
            rbItem["開發者精靈"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://sites.google.com/a/ischool.com.tw/kai-fa-zhe-jing-ling/");
            };

            RibbonBarItem rbItem_5 = MotherForm.RibbonBarItems["客戶服務", "ischool"];


            rbItem_5["客戶服務"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem_5["客戶服務"].Image = Properties.Resources.recepcionist_64;
            rbItem_5["客戶服務"].Click += delegate
            {
                System.Diagnostics.Process.Start("https://ischool.zendesk.com/hc/zh-tw");
            };
        }

        public static void RegisterTab()
        {
            MotherForm.AddPanel(ForumAdmin.Instance);

        }
    }
}
