using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace MyFacebookLogic
{
    public class EventsCenter
    {
        private User m_LoggedInUser;

        public Dictionary<DateTime, List<string>> m_FriendsBirthDates { get; set; }

        public Dictionary<DateTime, List<IEvent>> m_EventsPerDates { get; set; }

        public EventCollection m_UserEvents { get; set; }

        private List<DateTime> GetFriendsBirthDates()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (!string.IsNullOrEmpty(friend.Birthday))
                {
                    DateTime currFriendBirthDate = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    currFriendBirthDate = currFriendBirthDate.AddYears(DateTime.Now.Year - currFriendBirthDate.Year);
                    populateDictionary(friend.Id, currFriendBirthDate, m_FriendsBirthDates);
                }
            }

            return m_FriendsBirthDates.Keys.ToList();
        }

        private void populateDictionary<T, S>(S i_itemToAdd, DateTime i_Date, Dictionary<DateTime, List<T>> i_DictToPopulate)
        {
            TimeSpan timeDelta = new TimeSpan(i_Date.Hour, i_Date.Minute, i_Date.Second);
            i_Date = i_Date.Subtract(timeDelta);
            if (i_DictToPopulate is Dictionary<DateTime, List<string>>)
            {
                Dictionary<DateTime, List<string>> dictToPopulate = i_DictToPopulate as Dictionary<DateTime, List<string>>;

                if (dictToPopulate.ContainsKey(i_Date))
                {
                    dictToPopulate[i_Date].Add(i_itemToAdd as string);
                }
                else
                {
                    dictToPopulate.Add(i_Date, new List<string>() { i_itemToAdd as string });
                }
            }

            if (i_DictToPopulate is Dictionary<DateTime, List<IEvent>>)
            {
                Dictionary<DateTime, List<IEvent>> dictToPopulate = i_DictToPopulate as Dictionary<DateTime, List<IEvent>>;

                if (dictToPopulate.ContainsKey(i_Date))
                {
                    dictToPopulate[i_Date].Add(i_itemToAdd as IEvent);
                }
                else
                {
                    dictToPopulate.Add(i_Date, new List<IEvent>() { i_itemToAdd as IEvent });
                }
            }
        }

        private List<DateTime> GetAllEventsDates()
        {
            List<DateTime> eventDates = new List<DateTime>();
            IEnumerator<IEvent> userEventsEumerator = m_UserEvents.GetEnumerator();
            while (userEventsEumerator.MoveNext())
            {
                if (!(userEventsEumerator.Current.StartTime == null || userEventsEumerator.Current.EndTime == null))
                {
                    DateTime curDate = userEventsEumerator.Current.StartTime.Value;

                    eventDates.AddRange(GetDateRange(userEventsEumerator.Current.StartTime.Value, userEventsEumerator.Current.EndTime.Value));
                    while (curDate <= userEventsEumerator.Current.EndTime.Value)
                    {
                        populateDictionary(userEventsEumerator.Current, curDate, m_EventsPerDates);
                        curDate = curDate.AddDays(1);
                    }
                }
            }
         

            return eventDates;
        }

        private List<DateTime> GetDateRange(DateTime i_Start, DateTime i_End)
        {
            List<DateTime> result = new List<DateTime>();
            DateTime curDate = i_Start;

            while (curDate <= i_End)
            {
                result.Add(curDate);
                curDate = curDate.AddDays(1);
            }

            return result;
        }

        public EventsCenter(User i_LoggedInUser)
        {
            m_FriendsBirthDates = new Dictionary<DateTime, List<string>>();
            m_EventsPerDates = new Dictionary<DateTime, List<IEvent>>();
            m_LoggedInUser = i_LoggedInUser;
            m_UserEvents = new EventCollection((ICollection<IEvent>)(from evnt in i_LoggedInUser.Events select new EventProxy(evnt) as IEvent).ToList());
        }

        public DateTime[] GetDatesToMark()
        {
            List<DateTime> datesToMark = new List<DateTime>();
            datesToMark = GetAllEventsDates();
            datesToMark.AddRange(GetFriendsBirthDates());
            return datesToMark.ToArray();
        }

        public bool GetFriendsWhoBornThisDate(DateTime i_BirthDate, ref IEnumerable<string> i_FriendsBornInThatDate)
        {
            bool isAnyFriendBornThatDate = m_FriendsBirthDates.ContainsKey(i_BirthDate);
            if (isAnyFriendBornThatDate)
            {
                List<string> friendsBornInThatDateID = m_FriendsBirthDates[i_BirthDate];
                i_FriendsBornInThatDate = m_LoggedInUser.Friends.Where(friend => friendsBornInThatDateID.Contains(friend.Id)).Select(friend => friend.Name);
            }

            return isAnyFriendBornThatDate;
        }

        public bool GetEventsOnThatDate(DateTime i_EventDate, ref ICollection<IEvent> i_EventsName)
        {
            bool isAnyEventThatDate = m_EventsPerDates.ContainsKey(i_EventDate);
            if (isAnyEventThatDate)
            {
                i_EventsName = m_EventsPerDates[i_EventDate];
            }

            return isAnyEventThatDate;
        }
    }
}
