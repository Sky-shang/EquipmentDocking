using MaterialDesignThemes.Wpf;
using MenuMVVM.Models;
using System.Collections.Generic;
using System.Windows.Media;

namespace MenuMVVM.ViewModels
{
    public class MainViewModel
    {
        public string Logo { get; set; }
        public List<MenuItem> LeftMenus { get; set; }
        public MainViewModel()
        {
            Logo = "https://img.dotnet9.com/logo-foot.png";

            LeftMenus = new List<MenuItem>();
            LeftMenus.Add(new MenuItem("图片", PackIconKind.Image, new ItemCount(Brushes.Black, 2)));
            LeftMenus.Add(new MenuItem("音乐", PackIconKind.Music, new ItemCount(Brushes.DarkBlue, 4)));
            LeftMenus.Add(new MenuItem("视频", PackIconKind.Video, new ItemCount(Brushes.DarkGreen, 7)));
            LeftMenus.Add(new MenuItem("文档", PackIconKind.Folder, new ItemCount(Brushes.DarkOrange, 9)));
        }
    }
}