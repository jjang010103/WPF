using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ViewSlide.ViewModel.Window3
{
    public class Window3ViewModel : BaseViewModel_Window
    {
        private Model.Window3.Window3Model _model;
        private string _ImageTag;


        public Model.Window3.Window3Model Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        public string ImageTag
        {
            get
            {
                return _ImageTag;
            }
            set
            {
                _ImageTag = value;

                OnPropertyChanged(nameof(ImageTag));
            }
        }

        public Window3ViewModel()
        {
            InitScreenLocation(1);

            Model = new Model.Window3.Window3Model();

            RunImageSlide();
        }

        private void RunImageSlide()
        {
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(6);

            timer.Tick += (s, e) =>
            {
                Model.ChangeImagePathToNextSlideImage();

                ImageTag = "";
                ImageTag = "r";
            };

            timer.Start();
        }
    }
}
