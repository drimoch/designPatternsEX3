using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace MyFacebookLogic
{
    public class LastNameStrategy : IStrategy
    {
        public bool userConfirm(User i_UserShown, string i_NamePressed)
        {
            return i_UserShown.LastName.Equals(i_NamePressed);
        }
    }
}
