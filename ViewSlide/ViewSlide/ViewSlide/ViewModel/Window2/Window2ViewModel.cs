using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ViewSlide.ViewModel.Window2
{
    public class Window2ViewModel : BaseViewModel_Window
    {
        private Model.Window2.Window2Model _model;

        public Model.Window2.Window2Model Model
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

        public Window2ViewModel()
        {
            InitScreenLocation(1);

            Model = new Model.Window2.Window2Model();

            Model.RunLivePhto();
        }
    }
}
