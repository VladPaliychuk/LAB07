using System;

namespace Problem3
{
    internal class TaskFerrari
    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            ICar car = new Ferrari(driver);
            Console.WriteLine(car);
        }
    }
}
