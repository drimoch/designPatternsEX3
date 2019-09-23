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
            ICollection<EventProxy> eventsOnThatDate = new List<EventProxy>() ;
            ICollection<IEvent> eventsOnThatDateCollection = (from evnt in eventsOnThatDate select evnt as IEvent).ToList();
            m_EventsCenter.GetEventsOnThatDate(i_dateToCheck, ref eventsOnThatDateCollection);
            return eventsOnThatDateCollection;
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

        //public Utilities.eGuessType handleNamePressed(string i_NamePressed)
        //{
        //    return m_GuessWho.handleNamePressed(i_NamePressed);
        //}

        public void InitDelegates(Action<string> i_HandleCorrectGuess, Action<string> i_HandleWrongGuess)
        {
            m_GuessWho.initDelegatesInGuessWho(i_HandleCorrectGuess, i_HandleWrongGuess);
        }

        public Utilities.eGuessType HandleNamePressed(string i_NamePressed)
        {
            if (m_GuessWho.IsUserConfirmed(new FirstNameStrategy(), i_NamePressed))
            {
                return Utilities.eGuessType.PARTIAL_FIRST_NAME;
            }

            if (m_GuessWho.IsUserConfirmed(new LastNameStrategy(), i_NamePressed))
            {
                return Utilities.eGuessType.PARTIAL_LAST_NAME;
            }

            if ((m_GuessWho.IsUserConfirmed(new FullNameStrategy(), i_NamePressed)
                || (string.IsNullOrEmpty(i_NamePressed))))
            {
                return Utilities.eGuessType.WRONG;
            }
            else
            {
                return Utilities.eGuessType.CORRECT;
            }
        }

        public void OnGuess(string i_NamePressed)
        {
            Utilities.eGuessType userGuess = HandleNamePressed(i_NamePressed);

            string messageToUser = m_GuessWho.BuildMessageAccordingToUserGuess(userGuess);

            m_GuessWho.onGuess(i_NamePressed, userGuess, messageToUser);
        }
    }
}
