using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFacebookLogic
{
    public class Utilities
    {
        public enum eGuessType
        {
            CORRECT = 1,
            WRONG = 2,
            PARTIAL_FIRST_NAME = 3,
            PARTIAL_LAST_NAME = 4
        }

        public enum Constants
        {
            LIVES_COUNT = 7
        }

        public enum eFilterType
        {
            BLUR = 1,
            GAMMA, TRANPARENT
        }
    }
}
