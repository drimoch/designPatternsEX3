using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using System.Globalization;

namespace MyFacebookLogic
{
    public class MySchedule
    {
        public Dictionary<DateTime, List<String>> m_FriendsBirthDates { get; set; }



        //initiailize property
        public User m_LoggedInUser { get; set; }

        public MySchedule(User i_LoggedInUser)
        {
            m_FriendsBirthDates = new Dictionary<DateTime, List<String>>();

            m_LoggedInUser = i_LoggedInUser;
        }

        public DateTime[] GetFriendsBirthdates()
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                DateTime currFriendBirthDate = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                currFriendBirthDate = currFriendBirthDate.AddYears(DateTime.Now.Year - currFriendBirthDate.Year);
                if (m_FriendsBirthDates.ContainsKey(currFriendBirthDate))
                {
                    m_FriendsBirthDates[currFriendBirthDate].Add(friend.Id);
                }
                else
                {
                    m_FriendsBirthDates.Add(currFriendBirthDate, new List<string>() { friend.Id }); // or simply do new List<int>(){ i } instead of creating lst earlier 
                }
            }
            return m_FriendsBirthDates.Keys.ToArray();
        }

        public bool GetFriendsWhoBornThisDate(DateTime i_BirthDate,ref   IEnumerable<User> i_FriendsBornInThatDate)
        {
            bool isAnyFriendBornThatDate = m_FriendsBirthDates.ContainsKey(i_BirthDate);
            if (isAnyFriendBornThatDate)
            {
                List<String> friendsBornInThatDateID = m_FriendsBirthDates[i_BirthDate];
                 i_FriendsBornInThatDate = m_LoggedInUser.Friends.Where(friend => friendsBornInThatDateID.Contains(friend.Id));
            }
            return isAnyFriendBornThatDate;
        }
    }
}
