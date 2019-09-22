using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyFacebookLogic
{
    public class ImageFactory
    {
        public static ImageFilter CreateImageFilter(Utilities.eFilterType i_FilterType, Image i_UserImage)
        {
            ImageFilter imageFilter;

            switch(i_FilterType)
            {
                case Utilities.eFilterType.BLUR:
                    imageFilter = new ImgBlur(i_UserImage);
                    break;

                case Utilities.eFilterType.GAMMA:
                    imageFilter = new ImgGamma(i_UserImage);
                    break;

                default: // case Utilities.eFilterType.TRANPARENT
                    imageFilter = new ImgTransparency(i_UserImage);
                    break;
            }

            return imageFilter;
        }

        public static ImageFilter CreateImageFilter(Utilities.eFilterType tRANPARENT, object imageNormal)
        {
            throw new NotImplementedException();
        }
    }
}
