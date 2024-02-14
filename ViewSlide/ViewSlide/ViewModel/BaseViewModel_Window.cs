using System;
using System.Drawing;
using System.Linq;
using System.Windows;

namespace ViewSlide.ViewModel
{
    public class BaseViewModel_Window : BaseViewModel
    {
        private int _currentScreenIndex;
        private int _left;
        private int _top;
        private int _width;
        private int _height;

        public int Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;

                OnPropertyChanged(nameof(Left));
            }
        }

        public int Top
        {
            get
            {
                return _top;
            }
            set
            {
                _top = value;

                OnPropertyChanged(nameof(Top));
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;

                OnPropertyChanged(nameof(Width));
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;

                OnPropertyChanged(nameof(Height));
            }
        }

        public void InitScreenLocation(int screenIndex)
        {
            _currentScreenIndex = screenIndex;

            ChangeScreenLocation(_currentScreenIndex);
        }

        public void MoveNextScreenLocation()
        {
            if (System.Windows.Forms.Screen.AllScreens.Length - 1 == _currentScreenIndex)
            {
                _currentScreenIndex = 0;
            }
            else
            {
                _currentScreenIndex++;
            }

            ChangeScreenLocation(_currentScreenIndex);
        }

        private void ChangeScreenLocation(int screenIndex)
        {
            if (System.Windows.Forms.Screen.AllScreens.Length - 1 < screenIndex) return;

            Rectangle screenArea = System.Windows.Forms.Screen.AllScreens[screenIndex].Bounds;

            Left = screenArea.Left;
            Top = screenArea.Top;
            Width = screenArea.Width;
            Height = screenArea.Height;
        }
    }
}
