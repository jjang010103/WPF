namespace ViewSlide.Model.Window1
{
    public class Window1Model : BaseModel
    {
        private string _videoPath;

        public string VideoPath
        {
            get
            {
                return _videoPath;
            }
            set
            {
                _videoPath = value;
                OnPropertyChanged(nameof(VideoPath));
            }
        }

        public Window1Model(string videoPath)
        {
            VideoPath = videoPath;
        }
    }
}
