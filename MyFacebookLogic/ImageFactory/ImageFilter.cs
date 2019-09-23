using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace MyFacebookLogic
{
    public abstract class ImageFilter
    {
        protected Image m_Image { get; set; }

        public ImageFilter(Image i_ImageToAssign)
        {
            m_Image = i_ImageToAssign;
        }

        public abstract Image ChangeBlurness();

        public abstract Image ResetImageFilter();
    }
}
