using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace MyFacebookLogic
{
    public class GuessWho
    {
        private List<User> m_FriendsUserList;
        private User m_LoggedInUser;
        private User m_CurrentUserShown;
        private CorrectGuessObserver m_CorrectGuessObserver;
        private WrongGuessObserver m_WrongGuessObserver;

        public User CurrentUserShown
        {
            get
            {
                return m_CurrentUserShown;
            }
        }

        public event Action m_WrongGuessHandler;

        private void minusOneLive()
        {
            m_CounterLives--;
        }

        public GuessWho(User i_UserConnected)
        {
            m_LoggedInUser = i_UserConnected;
            m_WrongGuessHandler += minusOneLive;

        }

        public int m_CounterLives
        {
            get;
            set;
        }

        public bool ThereIsNoFriends()
        {
            return m_LoggedInUser.Friends.Count == 0;
        }

        public void RandAFriend()
        {
            m_FriendsUserList = new List<User>(m_LoggedInUser.Friends);

            Random randAFriend = new Random();
            User randomFriend;
            int randomIndex;

            randomIndex = randAFriend.Next(m_LoggedInUser.Friends.Count - 1);
            randomFriend = m_FriendsUserList[randomIndex];

            m_CurrentUserShown = randomFriend;
        }

        public Utilities.eGuessType handleNamePressed(string i_NamePressed)
        {
            //IStrategy strategy = new FullNameChecker();
            bool isConfirmed = isUserConfirmed(new FullNameChecker(), i_NamePressed);

            if ((!isConfirmed) || (string.IsNullOrEmpty(i_NamePressed)))
            {
                return Utilities.eGuessType.WRONG;
            }
            else
            {
                return Utilities.eGuessType.CORRECT;
            }
        }

        private bool isUserConfirmed(IStrategy i_ConfirmStrategy, string i_NamePressed)
        {
            return i_ConfirmStrategy.userConfirm(m_CurrentUserShown, i_NamePressed);
        }

        public void OnWrongGuess()
        {
            if (m_WrongGuessHandler != null)
            {
                m_WrongGuessHandler.Invoke();
            }
        }

        public void PrepareAllComponentsForStartingGame()
        {
            RandAFriend();
            m_CounterLives = (int)Utilities.Constants.LIVES_COUNT;
        }

        internal void initDelegatesInGuessWho(Action<string> i_HandleCorrectGuess, Action<string> i_HandleWrongGuess)
        {
            m_CorrectGuessObserver = new CorrectGuessObserver(i_HandleCorrectGuess);
            m_WrongGuessObserver = new WrongGuessObserver(i_HandleWrongGuess);
        }

        internal void onGuess(string i_MessageToUser, Utilities.eGuessType i_UserGuess)
        {
            IObserver observerToInvoke;

            //can't do this assignment with macro
            if (i_UserGuess == Utilities.eGuessType.CORRECT)
                observerToInvoke = m_CorrectGuessObserver;
            else
                observerToInvoke = m_WrongGuessObserver;

            observerToInvoke.invoke(i_MessageToUser);
        }
    }
}
