using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFacebookLogic
{
    public class ImgBlur : ImageFilter
    {
        private int m_BlurAmount;

        public ImgBlur(Image i_Image) : base(i_Image)
        {
            m_BlurAmount = 7;
        }

        public override Image ChangeBlurness()
        {
            m_BlurAmount -= 1;
            return decreaseBlur();
        }

        public override Image ResetImageFilter()
        {
            return decreaseBlur();
        }

        private Image decreaseBlur()
        {
            Bitmap newBitmap = new Bitmap(m_Image);

            for (int x = m_BlurAmount; x <= m_Image.Width - m_BlurAmount; x++)
            {
                for (int y = m_BlurAmount; y <= m_Image.Height - m_BlurAmount; y++)
                {
                    try
                    {
                        Color nextX = newBitmap.GetPixel(x + m_BlurAmount, y);
                        Color prevX = newBitmap.GetPixel(x - m_BlurAmount, y);
                        Color prevY = newBitmap.GetPixel(x, y - m_BlurAmount);
                        Color nextY = newBitmap.GetPixel(x, y + m_BlurAmount);

                        int avgR = (prevX.R + nextX.R + prevY.R + nextY.R) / 4;
                        int avgG = (prevX.G + nextX.G + prevY.G + nextY.G) / 4;
                        int avgB = (prevX.B + nextX.B + prevY.B + nextY.B) / 4;

                        newBitmap.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return newBitmap;
        }
    }
}