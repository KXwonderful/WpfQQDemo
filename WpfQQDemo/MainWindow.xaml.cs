using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfQQDemo.Common;
using WpfQQDemo.View;

namespace WpfQQDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //注册跳转
            WindowHelper.ShowPageHome = () =>
            {
                //frame.Navigate(new PageHome());
                PageHome pageHome = new PageHome();
                pageHome.Show();
                
            };

            // 跳转至登录页
            PageLogin pageLogin = new PageLogin();
            pageLogin.Show();
            this.Close();
            //frame.Navigate(new PageLogin());
        }
    }
}
