using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KinderGarten.Store;
using KinderGarten.View;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;
using System.Windows.Input;

namespace KinderGarten.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ICommand CmdButton1Click { get; set; }
        public ICommand CmdButton2Click { get; set; }
        public ICommand CmdButton3Click { get; set; }

        private Page _frameNavigatePage;

        public Page FrameNavigatePage
        {
            get
            {
                return this._frameNavigatePage;
            }

            set
            {
                this.SetProperty(ref this._frameNavigatePage, value);
            }
        }

        public MainViewModel()
        {
            this.CmdButton1Click = new RelayCommand(this.Button1_Click);
            this.CmdButton2Click = new RelayCommand(this.Button2_Click);
            this.CmdButton3Click = new RelayCommand(this.Button3_Click);

            this.FrameNavigatePage = App.Current.Services.GetRequiredService<MainPage>();

            var childStore = App.Current.Services.GetRequiredService<ChildrenStore>();
            childStore.Add(new Model.ChildrenInfo("Erik", 5));
            childStore.Add(new Model.ChildrenInfo("Nick", 6));
            childStore.Add(new Model.ChildrenInfo("Malpoi", 7));
            childStore.Add(new Model.ChildrenInfo("Drake", 7));
        }

        private void Button1_Click()
        {
            this.FrameNavigatePage = App.Current.Services.GetRequiredService<Page1>();
        }

        private void Button2_Click()
        {
            this.FrameNavigatePage = App.Current.Services.GetRequiredService<Page2>();
        }

        private void Button3_Click()
        {
            this.FrameNavigatePage = App.Current.Services.GetRequiredService<Page3>();
        }
    }
}
