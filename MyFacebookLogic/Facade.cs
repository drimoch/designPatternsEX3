using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace MyFacebookLogic
{
    public class MyFacbookLogicFacade
    {
        private GuessWho m_GuessWho;
        private EventsCenter m_EventsCenter;
        private AppSettings m_AppSettings;

        public AppSettings AppSettings
        {
            get
            {
                return m_AppSettings;
            }

            set
            {
                m_AppSettings = value;
            }
        }

        public MyFacbookLogicFacade()
        {
        }

        public void SetFeaturesLogic(User i_UserConnected)
        {
            m_GuessWho = new GuessWho(i_UserConnected);
            m_EventsCenter = new EventsCenter(i_UserConnected);
        }

        /*-------------------------------------------------------------------------------*/
        public DateTime[] GetDatesToMark()
        {
            return m_EventsCenter.GetDatesToMark();
        }

        public void LoadSettingsFromFile()
        {
            m_AppSettings = AppSettings.LoadFromFile();
        }

        public IEnumerable<string> GetFriendsWhoBornThatDate(DateTime i_BirthDate)
        {
            IEnumerable<string> friendsName = new List<string>();
            m_EventsCenter.GetFriendsWhoBornThisDate(i_BirthDate, ref friendsName);
            return friendsName;
        }

        public IEnumerable<IEvent> GetEventsOnThatDate(DateTime i_dateToCheck)
        {
            IEnumerable<IEvent> eventsOnThatDate = new List<EventProxy>();
            m_EventsCenter.GetEventsOnThatDate(i_dateToCheck, ref eventsOnThatDate);
            return eventsOnThatDate;
        }

        public bool isLastUserRemembered()
        {
            return m_AppSettings.m_RememberUser;
        }

        public void PrepareComponents()
        {
            m_GuessWho.PrepareAllComponentsForStartingGame();
        }

        public bool IsCorrect(Utilities.eGuessType i_UserGuess)
        {
            return i_UserGuess == Utilities.eGuessType.CORRECT;
        }

        public bool IsGameOver()
        {
            return m_GuessWho.m_CounterLives == 0;
        }

        public bool ThereIsNoFriends()
        {
            return m_GuessWho.ThereIsNoFriends();
        }

        public int CounterLives()
        {
        return m_GuessWho.m_CounterLives;
        }

        public void OnWrongGuess()
        {
            m_GuessWho.OnWrongGuess();
        }

        public User CurrentUserShown()
        {
            return m_GuessWho.CurrentUserShown;
        }

        public Utilities.eGuessType handleNamePressed(string i_NamePressed)
        {
            return m_GuessWho.handleNamePressed(i_NamePressed);
        }
    }      
}
