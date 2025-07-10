using System;

namespace MyApplication
{
    class Color
    {
        public string carColor ;
        public string carModel ;
    public Color() {
            carColor = "Red";
            carModel = "KMC";
        }
     public static void MyColor()
        {
            Color Ford = new Color();
            Console.WriteLine(Ford.carColor);
            Console.WriteLine(Ford.carModel);
        }
    }
}