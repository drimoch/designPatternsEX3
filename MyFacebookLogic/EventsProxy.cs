using System;

using FacebookWrapper.ObjectModel;

namespace MyFacebookLogic
{
    public class EventProxy : IEvent
    {
        public EventProxy(FacebookWrapper.ObjectModel.Event i_event)
        {
            Event = i_event;
            Name = i_event.Name;
            Location = i_event.Location;
            Description = i_event.Description;
            StartTime = i_event.StartTime.Value;
            EndTime = i_event.EndTime.Value;
        }

        public Event Event { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public override string ToString()
        {
            string start = string.Empty;
            string end = string.Empty;
            if (Event.StartTime != null)
            {
                start = Event.StartTime.Value.ToString();
            }

            if (Event.EndTime != null) 
            {
                end = Event.EndTime.Value.ToString();
            }

            return string.Format(
                Event.Name +
                '\u0007' + start +
                '\u0007' + end +
                '\u0007' + Event.Location +
                '\u0007' + Event.Description);
        }

        public enum eEventField
        {
            name = 0,
            start = 1,
            end = 2,
            location = 3,
            description = 4
        }
    }
}
