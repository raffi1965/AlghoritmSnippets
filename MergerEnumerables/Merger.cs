using System;
using System.Collections.Generic;
using System.Linq;

namespace merger
{
  public class Merger
  {
    public IEnumerable<T> Merge<T>(IEnumerable<T> first, IEnumerable<T> second)
        where T: IComparable
    {
      return Merge(first.GetEnumerator(), second.GetEnumerator());
    }

    public IEnumerable<T> Merge<T>(params IEnumerable<T>[] iterators)
        where T: IComparable
    {
      if (iterators.Length == 1)
        return iterators[0];
      var merged = iterators[0];
      foreach(var iter in iterators.Skip(1))
      {
        merged = Merge(merged, iter);
      }
      return merged;
    }

    public IEnumerable<T> Merge<T>(IEnumerator<T> first, IEnumerator<T> second)
        where T: IComparable
    {
      if (first.MoveNext() == false)
      {
        if (second.MoveNext())
        {
          do
          {
            yield return second.Current;
          }  while (second.MoveNext());
        }
      }
      else if (second.MoveNext() == false)
      {
        do
        {
          yield return first.Current;
        }  while (first.MoveNext());
      }
      else
      {
        IEnumerator<T> rest = null;
        for (;;)
        {
          if (first.Current.CompareTo(second.Current) <= 0)
          {
            yield return first.Current;
            if (first.MoveNext() == false)
            {
              rest = second;
              break;
            }
          }
          else
          {
            yield return second.Current;
            if (second.MoveNext() == false)
            {
              rest = first;
              break;
            }
          }
        }
        do
        {
          yield return rest.Current;
        }  while (rest.MoveNext());
      }
    }
  }
}
