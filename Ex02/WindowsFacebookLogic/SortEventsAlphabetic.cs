using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    internal class SortEventsAlphabetic : IComparer<Event>
    {
        public int Compare(Event i_FirstEvent, Event i_SecondEvent)
        {
            return i_FirstEvent.Name.CompareTo(i_SecondEvent.Name);
        }
    }
}
