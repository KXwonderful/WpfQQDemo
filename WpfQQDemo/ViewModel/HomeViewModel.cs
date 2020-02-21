using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfQQDemo.ViewModel
{
    class HomeViewModel: BindableBase
    {
        // listview 实体类
        public class Friend
        {
            public string Nickname { get; set; }
            public BitmapImage Head { get; set; }
        }

        // listview 数据源
        private ObservableCollection<Friend> friends;
        public ObservableCollection<Friend> Friends
        {
            get { return friends; }
            set { friends = value; }
        }

        // 头像，昵称数据源
        private BitmapImage head;
        public BitmapImage Head
        {
            get { return head; }
            set { SetProperty(ref head, value); }
        }

        private string nickname;
        public string Nickname
        {
            get { return nickname; }
            set { SetProperty(ref nickname, value); }
        }


        // 添加窗口关闭事件
        public DelegateCommand CloseCommand { get; set; }

        // 添加 listview item 点击事件
        public DelegateCommand<object> SelectItemChangeCommand { get; set; }

        // 构造函数
        public HomeViewModel()
        {
            // 添加测试数据
            friends = new ObservableCollection<Friend>
            {
                new Friend() { Nickname = "蜜桃味的橘子汽水", Head = new BitmapImage(new Uri("pack://application:,,,/Images/head1.jpeg")) },
                new Friend() { Nickname = "棉花糖", Head = new BitmapImage(new Uri("pack://application:,,,/Images/head2.jpeg")) },
                new Friend() { Nickname = "wonderful", Head = new BitmapImage(new Uri("pack://application:,,,/Images/head3.jpg")) },
                new Friend() { Nickname = "凉茶", Head = new BitmapImage(new Uri("pack://application:,,,/Images/head4.jpg")) },
                new Friend() { Nickname = "柠檬味", Head = new BitmapImage(new Uri("pack://application:,,,/Images/head5.jpeg")) },
                new Friend() { Nickname = "棉花糖", Head = new BitmapImage(new Uri("pack://application:,,,/Images/head6.jpg")) }
            };

            // 实例化 关闭窗口 事件
            CloseCommand = new DelegateCommand(() =>
            {
                //Application.Current.Shutdown();
                Environment.Exit(0);
            });


            // 初始化 卡片头像和昵称
            Head = friends[0].Head;
            Nickname = friends[0].Nickname;

            // 实例化 listview item 点击事件
            SelectItemChangeCommand = new DelegateCommand<object>((p) => {
                ListView lv = p as ListView;
                Friend friend = lv.SelectedItem as Friend;
                Head = friend.Head;
                Nickname = friend.Nickname;
            });
        }
    }
}
