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
        #region ��ʼ��
        public LoginViewModel()
        {
            //��ʼ������ - �벻Ҫ������̫�������������Ҫ����ʹ��Task
            User.UserName = "admin";
            User.UserPwd = "admin";
        }
        #endregion

        #region ����
        private User user;
        /// <summary>
        /// ��ǰ�û�
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

        #region ����
        /// <summary>
        /// ��¼����
        /// </summary>    
        public ICommand LoginCommand => new DelegateCommand<Window>((wd) =>
        {
            if (User.UserName == "admin" && User.UserPwd == "admin")
            {
                // �رյ�ǰ����
                if (wd != null) wd.Close();
                //WindowHelper.ShowPageHome();
                PageHome pageHome = new PageHome();
                 pageHome.Show();
               
            }
        });
        #endregion
    }
}