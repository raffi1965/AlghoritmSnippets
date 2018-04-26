using System;

namespace RevertString
{
    class Program
    {
        public static string helloWorld = "hello World";

        static void Main(string[] args)
        {
            //var arr = helloWorld.ToCharArray(0, helloWorld.Length);
            //char[] b = new char[helloWorld.Length];

            //for (int i = 0; i < helloWorld.Length; i++)
            //    b[(arr.Length - 1) - i] = arr[i];

            //var reversedStr = new String(b);

            //Console.WriteLine(reversedStr);

            //Console.ReadKey();

            Swap(helloWorld);
        }


        static void Swap(string message)
        {
            char[] array = message.ToCharArray(0, helloWorld.Length);

            var count = 0;
            var countdown = array.Length -1;

            while (count != countdown)
            {
                var temp = array[countdown];
                array[countdown] = array[count];
                array[count] = temp;

                count++;
                countdown--;
            }

            Console.WriteLine(new string(array));
            Console.ReadKey();
        }

    }
}
