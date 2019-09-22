using System;

namespace MyFacebookLogic
{
    public interface IEvent
    {
        string Name { get; set; }

        string Location { get; set; }

        string Description { get; set; }

        DateTime? StartTime { get; set; }

        DateTime? EndTime { get; set; }

        string ToString();
    }
}