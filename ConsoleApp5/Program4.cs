using System;

namespace MyApplication
{
    class Sort
    {
        public static void MySort()
        {
            int[] MyNumber = { 1, 2, 3, 4, 5 };
            Array.Sort(MyNumber);
            foreach (int i in MyNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}