using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFacebookLogic
{
    public class WrongGuessObserver : IObserver
    {
        private Action<string> m_WrongGuess;

        public WrongGuessObserver(Action<string> i_HandleCorrectGuess)
        {
            this.m_WrongGuess = i_HandleCorrectGuess;
        }

        public void invoke(string i_Message)
        {
            if (m_WrongGuess != null)
                m_WrongGuess.Invoke(i_Message);
        }
    }
}
