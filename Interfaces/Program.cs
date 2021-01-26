using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Year = 1999;
            myCar.StartEngine();

            var myTruck = new Truck();
            myTruck.StartEngine();
            Console.WriteLine("Done!");
        }
    }
}
