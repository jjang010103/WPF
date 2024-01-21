using KinderGarten.ViewModel;
using System.Windows.Controls;

namespace KinderGarten.View
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            this.DataContext = App.Current.Services.GetService(typeof(Page1ViewModel));
        }
    }
}
