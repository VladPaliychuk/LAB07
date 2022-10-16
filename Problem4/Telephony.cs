using System;

namespace Problem4
{
    internal class Telephony
    {
        static void Main(string[] args)
        {
            string[] numbers=Console.ReadLine().Split(' ');
            int k=-1;
            int n = numbers.Length;
            do
            {
                k++;
                try
                {
                    IToCall phone = new Smartphone(numbers[k]);
                    phone.Call(numbers[k]);
                    Console.WriteLine(phone.Call(numbers[k]));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                n--;
            }
            while (n != 0);

            string[] webs=Console.ReadLine().Split(' ');
            k = -1;
            n = webs.Length;
            do
            {
                k++;
                try
                {
                    IToVisit phone = new Smartphone(numbers[k]);
                    phone.Visit(webs[k]);
                    Console.WriteLine(phone.Visit(webs[k]));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                n--;
            }
            while (n != 0);
        }
    }
}
