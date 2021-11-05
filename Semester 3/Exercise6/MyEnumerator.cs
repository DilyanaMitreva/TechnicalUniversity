using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise6
{
    public class MyEnumerator<T> : IEnumerator<T>, IEnumerable<T>
    {
        private List<T> _list;
        private int _curentIndex;
        private WherePredicate<T> _wherePredicate;

        public T Current => _list[_curentIndex];

        object IEnumerator.Current => _list[_curentIndex];

        public IEnumerator<T> GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => this;

        public MyEnumerator(List<T> list,
            WherePredicate<T> wherePredicate) // its the same delegate in the formProperties file
        {
            _list = list;
            _wherePredicate = wherePredicate;
            Reset();
        }

        //  public bool MoveNext() => ++_curentIndex < _list.Count;

        public bool MoveNext()
        {
            while (++_curentIndex < _list.Count)
            {
                if (_wherePredicate(_list[_curentIndex]))
                {
                    return true;
                }
            }

            return false;
        }

        public void Reset() => _curentIndex = -1;


        public void Dispose()
        {
        }
    }
}