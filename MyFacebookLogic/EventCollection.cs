using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyFacebookLogic
{
    public class EventCollection : IEnumerable
    {
        private readonly ICollection<IEvent> r_FriendsCardCollection;

        public EventCollection(ICollection<IEvent> i_FriendsCardCollection)
        {
            r_FriendsCardCollection = i_FriendsCardCollection;
        }

        public IEnumerator<IEvent> GetEnumerator()
        {
            foreach (IEvent evnt in r_FriendsCardCollection)
            {
                yield return evnt;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return r_FriendsCardCollection.GetEnumerator();
        }
    }

}
