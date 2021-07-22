using System;
using System.Collections.Generic;

namespace _34.SortingAlgorithms
{
    public interface IGenericSortingAlgorithm<T> where T : IComparable
    {
        void Sort(IList<T> list);
    }
}