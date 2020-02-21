using System;
using System.Windows.Threading;

namespace WpfQQDemo.Common
{
    public static class Execute
    {
        private static Action<Action> executor = action => action();
        /// <summary>
        /// ��ʼ��UI������
        /// </summary>
        public static void InitializeWithDispatcher()
        {
            var dispatcher = Dispatcher.CurrentDispatcher;
            executor = action =>
            {
                if (dispatcher.CheckAccess())
                {
                    action();
                }
                else
                {
                    dispatcher.BeginInvoke(action);
                }
            };
        }

        /// <summary>
        /// UI�߳���ִ�з���
        /// </summary>
        public static void OnUIThread(this Action action)
        {
            executor(action);
        }
    }
}