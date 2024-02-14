//using LKCameraLib.Args;
//using LKCameraLib.Camera;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ViewSlide.Model.Window2
{
    public class Window2Model : BaseModel
    {
        //private CanonCam _canonCam;

        private BitmapImage _liveImage;

        public BitmapImage LiveImage
        {
            get
            {
                return _liveImage;
            }
            set
            {
                _liveImage = value;

                OnPropertyChanged(nameof(LiveImage));
            }
        }

        public void RunLivePhto()
        {
            //_canonCam = new CanonCam();
            //_canonCam.Initialize();
            //_canonCam.EventLive += EventLive;
            //_canonCam.LivePhoto(true);
        }

        object _loc = new object();

        private void EventLive(object sender, object e)
        {
            Application.Current?.Dispatcher.Invoke(new Action(() =>
            {
                lock (_loc)
                {
                    //if (e is LiveEventArgs args)
                    //{
                    //    LiveImage = new Utility.Image().StreamToImageSource(args.img);
                    //}
                }
            }));
        }
    }
}
