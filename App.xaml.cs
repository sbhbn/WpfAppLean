using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppLean
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Exception.Message.ToString();
            e.Exception.ToString();//exception stacktrace

            MessageBox.Show("系統發生異常請洽系統管理員", "Unhandled Exception",MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;//捕捉錯誤 不會擴散


        }

        private void Application_Exit(object sender, ExitEventArgs e) 
        {
            if (e.ApplicationExitCode == 0)
            {
                MessageBox.Show("應用程式正常關閉");
            }
            else {
                MessageBox.Show($"應用程式異常關閉:{ e.ApplicationExitCode}");
            }
            
        }
    }
}
