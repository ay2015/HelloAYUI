using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace HelloAYUI
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //其他参考设置
            //string windowuser = @"D:\";
            //AyuiConfig.AYUI_BackgroundImageDirectoryPath = windowuser + @"\44\ayuiresource\bg\";
            //AyuiConfig.AYUI_BackgroundImageThumbDirectoryPath = windowuser + @"44\t\thumb\";
            //AyuiConfig.AYUI_RelativeBg_BgPath = @"\ayuiresource\bg\";
            //AyuiConfig.AYUI_RelativeBg_ThumbPath = @"\t\thumb\";
            //AyuiConfig.AYUI_DiyColorTabTitle = "AY推荐颜色";
            //AyuiConfig.AYUI_DiyImageDirectoryName = "历史图片";
            //AyuiConfig.AYUI_ConfigFileNamePath = windowuser + @"44\ayuiresource\application.xml";
            //AyuiConfig.AYUI_ColorsCollectionBuilder(new List<string> { "#FFFFFF" }, true);

            //可以这里.AddFonts("aydemo", "#iconfont") 添加第三方字体
            Application.Current.InitGlobalPackUri().AddResourceDictionary(AyExtension.CreatePackUriString("/Contents/Styles/AYUIProjectDictionary.xaml")).AYUI();
            base.OnStartup(e);
        }
    }
}
