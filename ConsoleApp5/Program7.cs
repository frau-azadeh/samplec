using System;

namespace MyApplication
{
    enum Level
    {
        Low,
        Medium,
        High,
    }
    class Program
    {
       public static void MyProgram()
        {
            Level level = Level.Low;
            Console.WriteLine(level);
        }
    }
}