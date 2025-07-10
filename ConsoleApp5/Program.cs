using System;
namespace MyApplication
{
    class App
    {
        static void Main(string[] args)
        {
            string name = "Azadeh";
            string family = "Sahrifi Soltani";
            Console.WriteLine($"{name} {family}");
            Console.WriteLine(Number.MyNumber(5));
            Car.MyCar();
            Condition.MyCondition();
            Sort.MySort();
            Color.MyColor();
            Person person = new Person();
            person.Name = "Arezou";
            Console.WriteLine(person.Name);
            Program.MyProgram();
        }
    }
}