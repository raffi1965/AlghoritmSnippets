using System;
using System.Collections;

namespace MostFrequentElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 6, 8, 5, 3, 5, 7, 6, 4, 3, 2, 3, 5, 7, 6, 4, 3, 4, 5, 7 };
            Hashtable hashtable = new Hashtable();
            MaxOccurrence(array, hashtable);
        }

        static void MaxOccurrence(int[] array, Hashtable hashtable)
        {
            int mostCommom = array[0];
            int occurences = 0;

            foreach (int num in array)
            {
                if (!hashtable.ContainsKey(num))
                {
                    hashtable.Add(num, 1);
                }
                else
                {
                    int tempOccurences = (int)hashtable[num];
                    tempOccurences++;

                    hashtable.Remove(num);

                    hashtable.Add(num, tempOccurences);

                    if (occurences < tempOccurences)
                    {
                        occurences = tempOccurences;
                        mostCommom = num;
                    }
                }
            }

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }

            Console.WriteLine("The commmon numer is " + mostCommom + " And it appears " + occurences + " times");
            Console.ReadKey();
        }
    }
}
