using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace KinderGarten.ViewModel
{
    internal class MainViewInfo : ObservableObject
    {
        public ICommand CmdButton1Click { get; set; }
        public ICommand CmdButton2Click { get; set; }
        public ICommand CmdButton3Click { get; set; }

        private string _frameNavigatePath;

        public string FrameNavigatePath
        {
            get
            {
                return this._frameNavigatePath;
            }

            set
            {
                this.SetProperty(ref this._frameNavigatePath, value);
            }
        }

        public MainViewInfo()
        {
            this.CmdButton1Click = new RelayCommand(this.Button1_Click);
            this.CmdButton2Click = new RelayCommand(this.Button2_Click);
            this.CmdButton3Click = new RelayCommand(this.Button3_Click);
        }

        private void Button1_Click()
        {
            this.FrameNavigatePath = "View/Page1.xaml";
        }

        private void Button2_Click()
        {
            this.FrameNavigatePath = "View/Page2.xaml";
        }

        private void Button3_Click()
        {
            MessageBox.Show("Btn3");
        }
    }
}
