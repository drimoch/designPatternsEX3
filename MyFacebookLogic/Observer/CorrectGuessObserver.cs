using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFacebookLogic
{
    //public delegate void HandleNamePressed<T>(T i_MessageToUser);

    class CorrectGuessObserver : IObserver
    {
        public Action<string> m_CorrectGuess;

        public CorrectGuessObserver(Action<string> i_HandleCorrectGuess)
        {
            m_CorrectGuess += i_HandleCorrectGuess;
        }

        public void invoke(string i_Message)
        {
            if (m_CorrectGuess != null)
                m_CorrectGuess.Invoke(i_Message);
        }
    }
}
