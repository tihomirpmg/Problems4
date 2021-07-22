using System;
using System.Collections.Generic;
using System.Text;

namespace _34.SortingAlgorithms
{
    public class InsertSort<T> : IGenericSortingAlgorithm<T> where T : IComparable
    {
        public void Sort(IList<T> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                T it = list[i];
                int indexGap = i;
                while (indexGap > 0 && list[indexGap - 1].CompareTo(it) > 0)
                {
                    list[indexGap] = list[--indexGap];
                }
                list[indexGap] = it;
            }
        }
    }
}
