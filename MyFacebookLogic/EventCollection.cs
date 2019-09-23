using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyFacebookLogic
{
    public class EventCollection : IEnumerable
    {
        private readonly ICollection<IEvent> r_Events;

        public EventCollection(ICollection<IEvent> i_events)
        {
            r_Events = i_events;
        }

        public IEnumerator<IEvent> GetEnumerator()
        {
            foreach (IEvent evnt in r_Events)
            {
                yield return evnt;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return r_Events.GetEnumerator();
        }
    }

}
