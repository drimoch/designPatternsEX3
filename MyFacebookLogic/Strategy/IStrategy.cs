using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace MyFacebookLogic
{
    public interface IStrategy
    {
        bool userConfirm(User i_UserShown, string i_NamePressed);
    }
}
