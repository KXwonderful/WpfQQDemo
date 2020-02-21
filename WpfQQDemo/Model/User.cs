using WpfQQDemo.Common;

namespace WpfQQDemo.Model
{
    /// <summary>
    /// �û���
    /// </summary>
    public class User : ViewModelBase
    {
        private string userName;
        /// <summary>
        /// �û���
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string userPwd;
        /// <summary>
        /// ����
        /// </summary>
        public string UserPwd
        {
            get { return userPwd; }
            set
            {
                userPwd = value;
                OnPropertyChanged(nameof(UserPwd));
            }
        }

        private bool vip;
        /// <summary>
        /// �Ƿ�VIP
        /// </summary>
        public bool Vip
        {
            get { return vip; }
            set
            {
                vip = value;
                OnPropertyChanged(nameof(Vip));
            }
        }
    }
}