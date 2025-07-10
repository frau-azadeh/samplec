using System;

namespace MyApplication
{
    class Condition
    {
        public static void MyCondition()
        {
            int x = 5;
            int y = 10;
            if (x < y)
            {
                Console.WriteLine("y is Greater");
            }
            else
            {
                Console.WriteLine("x is Greater");  
            }

        }
    }
}