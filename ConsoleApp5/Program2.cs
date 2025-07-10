using System;

namespace MyApplication
{
    class Car
    {
        public static void MyCar()
        {
            string[] car = { "mvm", "kmc" };
            Console.WriteLine(car[1]);
            foreach (string s in car)
            {
                Console.WriteLine(s);
            }
        }
    }
}