using System;
using System.Collections.Generic;
using System.Linq;

namespace merger
{
    public class Merger
  {
    public IEnumerable<T> Merge<T>(IEnumerable<T> first, IEnumerable<T> second) where T: IComparable
    {
      return Merge(first.GetEnumerator(), second.GetEnumerator());
    }

    public IEnumerable<T> Merge<T>(params IEnumerable<T>[] enumerables) where T: IComparable
    {
      if (enumerables.Length == 1)
        return enumerables[0];

      var merged = enumerables[0];

      foreach (var enumerable in enumerables.Skip(1))
      {
        merged = Merge(merged, enumerable);
      }
      return merged;
    }

    public IEnumerable<T> Merge<T>(IEnumerator<T> first, IEnumerator<T> second) where T: IComparable
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
