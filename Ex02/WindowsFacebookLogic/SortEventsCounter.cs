using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    internal class SortEventsCounter : IComparer<Event>
    {
        public int Compare(Event i_FirstEvent, Event i_SecondEvent)
        {
            return i_FirstEvent.AttendingCount.Value.CompareTo(i_SecondEvent.AttendingCount.Value);
        }
    }
}