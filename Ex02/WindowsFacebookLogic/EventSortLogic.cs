using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    internal static class EventSortLogic
    {
        internal static List<Event> SortEvent(LogicEnums.eSortType i_SortType, FacebookObjectCollection<Event> i_EventsForSort)
        {
            List<Event> sortedEvents = converEventsFacebookObjectCollectionToList(i_EventsForSort);
            sortedEvents.Sort(FactorySortEvents.GetSorterObject(i_SortType));
            return sortedEvents;
        }

        private static List<Event> converEventsFacebookObjectCollectionToList(FacebookObjectCollection<Event> i_EventsForSort)
        {
            List<Event> eventsList = new List<Event>();
            foreach (Event currentEvent in i_EventsForSort)
            {
                eventsList.Add(currentEvent);
            }

            return eventsList;
        }
    }
}