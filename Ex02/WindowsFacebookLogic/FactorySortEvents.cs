using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    internal static class FactorySortEvents
    {
        internal static IComparer<Event> GetSorterObject(LogicEnums.eSortType i_SortType)
        {
            switch (i_SortType)
            {
                case LogicEnums.eSortType.AlphabeticSort:
                    return new SortEventsAlphabetic();
                case LogicEnums.eSortType.CounterSort:
                    return new SortEventsCounter();
                case LogicEnums.eSortType.DateSort:
                    return new SortEventsDate();
                default:
                    throw new ArgumentException();
            }
        }
    }
}