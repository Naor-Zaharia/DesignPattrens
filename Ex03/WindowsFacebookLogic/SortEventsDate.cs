using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    internal class SortEventsDate : IComparer<Event>
    {
        public int Compare(Event i_FirstEvent, Event i_SecondEvent)
        {
            return i_FirstEvent.StartTime.Value.CompareTo(i_SecondEvent.StartTime.Value);
        }
    }
}