using MenuMVVM.ViewModels;
using System.Windows;

namespace MenuMVVM.Views
{
    /// <summary>
    /// 演示主窗体，只用于简单的绑定ListView控件
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            this.DataContext = new MainViewModel();
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}