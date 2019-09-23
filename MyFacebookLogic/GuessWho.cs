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

        public bool IsUserConfirmed(IStrategy i_ConfirmStrategy, string i_NamePressed)
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

        internal void onGuess(string i_NamePressed, Utilities.eGuessType i_UserGuess, string i_MessageToUser)
        {
            IObserver observerToInvoke;

            //can't do this assignment with macro
            if (i_UserGuess == Utilities.eGuessType.CORRECT)
                observerToInvoke = m_CorrectGuessObserver;
            else
                observerToInvoke = m_WrongGuessObserver;

            observerToInvoke.invoke(i_MessageToUser);
        }

        public string BuildMessageAccordingToUserGuess(Utilities.eGuessType i_UserGuess)
        {
            string messageToBuild;


            switch (i_UserGuess)
            {
                case Utilities.eGuessType.CORRECT:
                    messageToBuild = string.Format("Correct Guess!{0} Wanna play again?", Environment.NewLine);
                    break;


                case Utilities.eGuessType.PARTIAL_FIRST_NAME:
                    messageToBuild = string.Format("Almost, you are close!{0}You guessed correct the first Name", Environment.NewLine);
                    break;

                case Utilities.eGuessType.PARTIAL_LAST_NAME:
                    messageToBuild = string.Format("Almost, you are close!{0}You guessed correct the last Name", Environment.NewLine);
                    break;

                default:
                    //case Utilities.eGuessType.WRONGג
                    messageToBuild = string.Format("Wrong Guess!{0} Please Try Again!", Environment.NewLine);
                    break;
            }

            return messageToBuild;
        }
    }
}
