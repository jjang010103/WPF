using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ViewSlide.Model.Window3
{
    public class Window3Model : BaseModel
    {
        private string[] _images;

        private int _imageIndex;

        private string _imagePath;

        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;

                OnPropertyChanged(nameof(ImagePath));
            }
        }

        public Window3Model()
        {
            _images = new string[]
                        {
                        @"C:\Document\Sub Project\ViewSlide\Intro1.png",
                        @"C:\Document\Sub Project\ViewSlide\Intro2.png",
                        @"C:\Document\Sub Project\ViewSlide\Intro3.png"
                        };

            _imageIndex = 0;
        }

        public void ChangeImagePathToNextSlideImage()
        {
            if (_imageIndex == _images.Length) _imageIndex = 0;

            ImagePath = _images[_imageIndex++];
        }
    }
}
