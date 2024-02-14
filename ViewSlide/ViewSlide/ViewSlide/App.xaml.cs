//using LKCameraLib.Camera;
//using LKCameraLib.Interface;
using System;
using System.Windows;

namespace ViewSlide
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public new static App Current => (App)Application.Current;

        public void App_Startup(object sender, StartupEventArgs e)
        {
            InitCommand();

            new View.Window1.Window1().Show();
            new View.Window2.Window2().Show();
            new View.Window3.Window3().Show();
        }

        public void Release()
        {
            System.Windows.Application.Current.Shutdown();
            Environment.Exit(0);
        }

        private void InitCommand()
        {
            new Command.WindowKeyDown_esc().InsertCommand();
            new Command.WindowKeyDown_Space().InsertCommand();
        }
    }
}
