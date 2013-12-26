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


            //RibbonBarItem rbItem = MotherForm.RibbonBarItems["討論區", "快速連結"];
            //rbItem["官方網站"].Click += delegate
            //{
            //    ForumAdmin.Instance.ReSet("http://www.ischool.com.tw/");
            //};

            RibbonBarItem rbItem1 = MotherForm.RibbonBarItems["客戶服務", "網頁功能項目"];
            rbItem1["上一頁"].Image = Properties.Resources.first_64;
            rbItem1["上一頁"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["上一頁"].Click += delegate
            {
                ForumAdmin.Instance.GoBack();
            };
            rbItem1["下一頁"].Image = Properties.Resources.last_64;
            rbItem1["下一頁"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["下一頁"].Click += delegate
            {
                ForumAdmin.Instance.GoForward();
            };
            rbItem1["重新整理"].Image = Properties.Resources.reload_64;
            rbItem1["重新整理"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["重新整理"].Click += delegate
            {
                ForumAdmin.Instance.URLRefresh();
            };
            rbItem1["停止"].Image = Properties.Resources.stop_64;
            rbItem1["停止"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem1["停止"].Click += delegate
            {
                ForumAdmin.Instance.URLStop();
            };

            RibbonBarItem rbItem_5 = MotherForm.RibbonBarItems["客戶服務", "ischool"];
            string name_1 = "客戶服務URL設定值";
            string name_2 = "目前URL";
            
            //Campus.Configuration.ConfigData cd = Campus.Configuration.Config.User[name_1];
            //if (cd[name_2] != "")
            //{
            //    if (cd[name_2].Contains("http"))
            //    {
            //        ForumAdmin.Instance.ReSet(cd[name_2]);
            //    }
            //}

            rbItem_5["客戶服務"].Size = RibbonBarButton.MenuButtonSize.Large;
            rbItem_5["客戶服務"].Image = Properties.Resources.recepcionist_64;
            rbItem_5["客戶服務"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://ischool.zendesk.com/home");
                //cd[name_2] = "https://ischool.zendesk.com/home";
                //cd.Save();
            };

            RibbonBarItem rbItem = MotherForm.RibbonBarItems["客戶服務", "快速連結"];

            rbItem["開發者精靈"].Size = RibbonBarButton.MenuButtonSize.Medium;
            rbItem["開發者精靈"].Image = Properties.Resources.technology_64;
            rbItem["開發者精靈"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://sites.google.com/a/ischool.com.tw/kai-fa-zhe-jing-ling/");
                //cd[name_2] = "https://sites.google.com/a/ischool.com.tw/kai-fa-zhe-jing-ling/";
                //cd.Save();
            };

            rbItem["討論區(舊)"].Image = Properties.Resources.Logo_black;
            rbItem["討論區(舊)"].Size = RibbonBarButton.MenuButtonSize.Medium;
            rbItem["討論區(舊)"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("http://forum.ischool.com.tw/index.php");
                //cd[name_2] = "http://forum.ischool.com.tw/index.php";
                //cd.Save();
            };

            rbItem["高雄國中"].Size = RibbonBarButton.MenuButtonSize.Medium;
            rbItem["高雄國中"]["校務行政平台"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("http://sites.google.com/a/ischool.com.tw/gao-xiong-shi-guo-zhong-xi-tong-xie-zuo-ping-tai/");
                //cd[name_2] = "http://sites.google.com/a/ischool.com.tw/gao-xiong-shi-guo-zhong-xi-tong-xie-zuo-ping-tai/";
                //cd.Save();
            };

            RibbonBarItem rbItem2 = MotherForm.RibbonBarItems["客戶服務", "FaceBook"];
            rbItem2["ischool粉絲團"].Size = RibbonBarButton.MenuButtonSize.Medium;
            //rbItem2["ischool粉絲團"].Image = Properties.Resources.th;
            rbItem2["ischool粉絲團"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/pages/ischool-%E6%BE%94%E5%AD%B8/134650313212257");
                //cd[name_2] = "https://www.facebook.com/pages/ischool-%E6%BE%94%E5%AD%B8/134650313212257";
                //cd.Save();
            };

            rbItem2["ischool社團"].Size = RibbonBarButton.MenuButtonSize.Medium;
            //rbItem2["ischool社團"].Image = Properties.Resources.th;
            rbItem2["ischool社團"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/groups/427416620714570/");
                //cd[name_2] = "https://www.facebook.com/groups/427416620714570/";
                //cd.Save();
            };

            rbItem2["1know粉絲團"].Size = RibbonBarButton.MenuButtonSize.Medium;
            //rbItem2["1know粉絲團"].Image = Properties.Resources.th;
            rbItem2["1know粉絲團"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/1know.net");
                //cd[name_2] = "https://www.facebook.com/1know.net";
                //cd.Save();
            };

            rbItem2["1know社團"].Size = RibbonBarButton.MenuButtonSize.Medium;
            //rbItem2["1know社團"].Image = Properties.Resources.th;
            rbItem2["1know社團"].Click += delegate
            {
                ForumAdmin.Instance.ReSet("https://www.facebook.com/groups/1know/");
                //cd[name_2] = "https://www.facebook.com/groups/1know/";
                //cd.Save();
            };
            //rbItem["ischool 新聞台"].Size = RibbonBarButton.MenuButtonSize.Medium;
            //rbItem["ischool 新聞台"].Click += delegate
            //{
            //    ForumAdmin.Instance.ReSet("http://betasmartschool.blogspot.com/");
            //};

            //rbItem["ischool 模組開發者網站"].Size = RibbonBarButton.MenuButtonSize.Medium;
            //rbItem["ischool 模組開發者網站"].Click += delegate
            //{
            //    ForumAdmin.Instance.ReSet("https://sites.google.com/a/ischool.com.tw/dev/");
            //};

            //rbItem["ischool Plugin"].Size = RibbonBarButton.MenuButtonSize.Medium;
            //rbItem["ischool Plugin"].Click += delegate
            //{
            //    ForumAdmin.Instance.ReSet("https://sites.google.com/a/ischool.com.tw/plugin/");
            //};
        }

        public static void RegisterTab()
        {
            MotherForm.AddPanel(ForumAdmin.Instance);

        }
    }
}
