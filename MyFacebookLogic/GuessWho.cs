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
            if ((!m_CurrentUserShown.Name.ToUpper().Equals(i_NamePressed.ToUpper())) ||
                string.IsNullOrEmpty(i_NamePressed))
            {
                return Utilities.eGuessType.WRONG;
            }
            else
            {
                return Utilities.eGuessType.CORRECT;
            }
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
    }
}
