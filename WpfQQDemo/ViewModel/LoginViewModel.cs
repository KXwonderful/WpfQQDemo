using Prism.Commands;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfQQDemo.Common;
using WpfQQDemo.Model;
using WpfQQDemo.View;

namespace WpfQQDemo.ViewModel
{
	public class LoginViewModel: ViewModelBase
	{
        #region 初始化
        public LoginViewModel()
        {
            //初始化数据 - 请不要这里做太多任务，如果有需要可以使用Task
            User.UserName = "admin";
            User.UserPwd = "admin";
        }
        #endregion

        #region 属性
        private User user;
        /// <summary>
        /// 当前用户
        /// </summary>
        public User User
        {
            get
            {
                if (user == null)
                {
                    user = new User();
                }
                return user;
            }
            set
            {
                user = value;
                OnPropertyChanged(nameof(User));
            }
        }
        #endregion

        #region 命令
        /// <summary>
        /// 登录操作
        /// </summary>    
        public ICommand LoginCommand => new DelegateCommand<Window>((wd) =>
        {
            if (User.UserName == "admin" && User.UserPwd == "admin")
            {
                // 关闭当前窗口
                if (wd != null) wd.Close();
                //WindowHelper.ShowPageHome();
                PageHome pageHome = new PageHome();
                 pageHome.Show();
               
            }
        });
        #endregion
    }
}