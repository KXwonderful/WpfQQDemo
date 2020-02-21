using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfQQDemo.Common;

namespace WpfQQDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 重启启动函数
        /// </summary>
        protected override void OnStartup(StartupEventArgs e)
        {
            //初始化UI调度器
            Execute.InitializeWithDispatcher();

            base.OnStartup(e);
        }
    }
}
