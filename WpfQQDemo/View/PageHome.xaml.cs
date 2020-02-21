using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfQQDemo.ViewModel;

namespace WpfQQDemo.View
{
    /// <summary>
    /// PageHome.xaml 的交互逻辑
    /// </summary>
    public partial class PageHome : Window
    {
        public PageHome()
        {
            InitializeComponent();

            this.DataContext = new HomeViewModel();
        }

        private void NavBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs args)
        {
            DragMove();
        }

        private void MinWindow(object sender, RoutedEventArgs args)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaxWindow(object sender, RoutedEventArgs args)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }

        }
    }
}
