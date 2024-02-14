namespace ViewSlide.ViewModel.Window1
{
    public class Window1ViewModel : BaseViewModel_Window
    {
        private Model.Window1.Window1Model _model;

        public Model.Window1.Window1Model Model
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

        public Window1ViewModel()
        {
            InitScreenLocation(0);

            Model = new Model.Window1.Window1Model(@"C:\Users\mgjang\Downloads\ViewSlide\YourPhoneRdx.mp4");
        }
    }
}
