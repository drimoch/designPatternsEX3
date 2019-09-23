using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace MyFacebookLogic
{
    public class ImgTransparency : ImageFilter
    {
        private float m_ImageTransparency;

        public ImgTransparency(Image i_Image) : base(i_Image)
        {
            m_ImageTransparency = 0.1f;
        }

        public override Image ChangeBlurness()
        {
            m_ImageTransparency += 0.05f;
            return decreaseBlur();
        }

        public override Image ResetImageFilter()
        {
            return decreaseBlur();
        }

        private Image decreaseBlur()
        {
            Bitmap bmp = new Bitmap(m_Image.Width, m_Image.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = m_ImageTransparency;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(m_Image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, m_Image.Width, m_Image.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();

            return bmp;
        }
    }
}