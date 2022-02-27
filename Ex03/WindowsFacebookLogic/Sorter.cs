using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebookLogic
{
    public class Sorter<T>
    {
        public Sorter()
        {
        }

        public Sorter(IComparer<T> i_Comparer)
        {
            Comparer = i_Comparer;
        }

        public IComparer<T> Comparer { get; set; }

        internal List<T> Sort(FacebookObjectCollection<T> i_CollectionForSort)
        {
            List<T> sortedFacebookObj = convertFacebookObjectCollectionToList(i_CollectionForSort);

            if (Comparer != null)
            {
                sortedFacebookObj.Sort(Comparer);
            }

            return sortedFacebookObj;
        }

        private List<T> convertFacebookObjectCollectionToList(FacebookObjectCollection<T> i_CollectionForSort)
        {
            List<T> facebookObjList = new List<T>();

            foreach (T currentFacebookObj in i_CollectionForSort)
            {
                facebookObjList.Add(currentFacebookObj);
            }

            return facebookObjList;
        }
    }
}