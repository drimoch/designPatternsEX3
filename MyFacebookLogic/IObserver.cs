using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFacebookLogic
{
    interface IObserver
    {
        void invoke(string i_Message);
    }
}
