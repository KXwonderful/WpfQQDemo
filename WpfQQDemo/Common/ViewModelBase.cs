using System.ComponentModel;

namespace WpfQQDemo.Common
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region UI���½ӿ�
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region �Ƿ����ڼ���
        private bool isLoad;

        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool IsLoad
        {
            get { return isLoad; }
            set
            {
                isLoad = value;
                OnPropertyChanged(nameof(IsLoad));
            }
        }
        #endregion

        #region �Ƿ���Ҫˢ��
        private bool update;
        /// <summary>
        /// ˢ��
        /// </summary>
        public bool Update
        {
            get { return update; }
            set
            {
                update = value;
                OnPropertyChanged(nameof(Update));
            }
        }
        #endregion
    }
}