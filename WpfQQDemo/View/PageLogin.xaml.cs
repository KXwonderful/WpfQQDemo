using System.Windows;
using System.Windows.Controls;
using WpfQQDemo.ViewModel;

namespace WpfQQDemo.View
{
    public partial class PageLogin : Window
    {
        public PageLogin()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
    }
}