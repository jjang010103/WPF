using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ViewSlide.Utility
{
    public class Image
    {
        /// <summary>
        /// Image Control의 Source에 바인딩할 BitmapImage를 생성한다.
        /// </summary>
        /// <param name="imgStream"></param>
        /// <returns></returns>
        public BitmapImage StreamToImageSource(Stream imgStream)
        {
            using (var ms = new MemoryStream())
            {
                System.Drawing.Image.FromStream(imgStream).Save(ms, ImageFormat.Bmp);
                ms.Seek(0, SeekOrigin.Begin);

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
    }
}
