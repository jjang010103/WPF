using System.Windows;
using System.Windows.Controls;

namespace MEMO
{
    /// <summary>
    /// UcChildView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UcChildView : UserControl
    {
        public static readonly DependencyProperty ContentValueDProperty = DependencyProperty.Register(
         nameof(ContentValue), typeof(string), typeof(UcChildView), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty FilePathDProperty = DependencyProperty.Register(
         nameof(FilePath), typeof(string), typeof(UcChildView), new PropertyMetadata(string.Empty));

        public string ContentValue
        {
            get { return (string)GetValue(ContentValueDProperty); }
            set { SetValue(ContentValueDProperty, value); }
        }

        public string FilePath
        {
            get { return (string)GetValue(FilePathDProperty); }
            set { SetValue(FilePathDProperty, value); }
        }

        public UcChildView()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
