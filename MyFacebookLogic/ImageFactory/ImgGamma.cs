using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace MyFacebookLogic
{
    public class ImgGamma : ImageFilter
    {
        private float m_GammaAmount;

        public ImgGamma(Image i_Image) : base(i_Image)
        {
            m_GammaAmount = 1;
        }

        public override Image ChangeBlurness()
        {
            m_GammaAmount += 0.5f;

            return decreaseBlur();
        }

        public override Image ResetImageFilter()
        {
            return decreaseBlur();
        }

        private Image decreaseBlur()
        {
            float gamma = m_GammaAmount * 0.04f;

            Bitmap newBitmap = new Bitmap(m_Image);

            Bitmap bitMapWanted = new Bitmap(newBitmap.Width, newBitmap.Height);

            Graphics graphics = Graphics.FromImage(bitMapWanted);

            ImageAttributes imageAttr = new ImageAttributes();

            imageAttr.SetGamma(gamma);

            graphics.DrawImage(
                newBitmap,
                new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
                0,
                0, 
                newBitmap.Width, 
                newBitmap.Height, 
                GraphicsUnit.Pixel, 
                imageAttr);

            graphics.Dispose();
            imageAttr.Dispose();

            return bitMapWanted;
        }
    }
}
