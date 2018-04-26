using System;

namespace RemoveDuplicateChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = RemoveDuplicateChars("Csharpstar");
            string value2 = RemoveDuplicateChars("Google");
            string value3 = RemoveDuplicateChars("Yahoo");
            string value4 = RemoveDuplicateChars("CNN");
            string value5 = RemoveDuplicateChars("Line1\nLine2\nLine3");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);

            Console.ReadKey();
        }

        static string RemoveDuplicateChars(string stringValue)
        {
            string table = "";

            foreach (char value in stringValue)
            {
                if (table.IndexOf(value) == -1)
                    table += value;
            }
            return table;
        }
    }
}
