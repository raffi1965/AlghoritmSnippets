using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedListReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Person> persons = new LinkedList<Person>();

            LinkedList<Person> reversed = new LinkedList<Person>();

            persons.AddLast(new Person { Name = "Tom" });
            persons.AddLast(new Person { Name = "John" });
            persons.AddLast(new Person { Name = "Bill" });
            persons.AddLast(new Person { Name = "Rafik" });

            var list = persons.ToList();
            var reversedList = Reverse(list).ToList();

            //var current = persons.Last;
            //reversed.AddLast((Person)current.Value.Clone());
            //while (current.Previous != null)
            //{
            //    current = current.Previous;
            //    reversed.AddLast((Person)current.Value.Clone());
            //}
        }

        static IEnumerable<Person> Reverse(List<Person> list)
        {
            for (int i = list.Count - 1; i >= 0; --i)
                yield return list[i];
        }


        class Person : ICloneable
        {
            public string Name { get; set; }

            public object Clone()
            {
                return this.MemberwiseClone();
            }
        }

    }
}
