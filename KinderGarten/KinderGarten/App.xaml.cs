using KinderGarten.Store;
using KinderGarten.View;
using KinderGarten.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace KinderGarten
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        public App()
        {
            this.Services = ConfigureServices();

            var mainView = Services.GetRequiredService<MainWindow>();
            mainView.Show();
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            //Store
            services.AddSingleton(typeof(ChildrenStore));

            //ViewModel
            services.AddSingleton(typeof(MainViewModel));
            services.AddSingleton(typeof(Page1ViewModel));

            //View
            services.AddSingleton(s => new MainWindow()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });
            services.AddSingleton(new MainPage());
            services.AddSingleton(s => new Page1()
            {
                DataContext = s.GetRequiredService<Page1ViewModel>()
            });
            services.AddSingleton(s => new Page2()
            {

            });
            services.AddSingleton(s => new Page3()
            {

            });

            return services.BuildServiceProvider();
        }
    }
}
