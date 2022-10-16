using Problem5;
using System;
using System.Collections.Generic;

namespace Problem6
{
    internal class BirthdayCelebration
    {
        static void Main(string[] args)
        {
            var persons = new List<IBirth>();

            string input = Console.ReadLine();
            do
            {
                string[] inputSplit = input.Split(' ');
                if (inputSplit[0]=="Citizen")
                {
                    string name = inputSplit[1];
                    string age = inputSplit[2];
                    string id = inputSplit[3];
                    string birthdate = inputSplit[4];
                    persons.Add(new Citizen(age, name, id, birthdate));
                }
                if (inputSplit[0]=="Pet")
                {
                    string name = inputSplit[1];
                    string birthdate = inputSplit[2];
                    persons.Add(new Pet(name, birthdate));
                }
                input = Console.ReadLine();
            }
            while (input != "End");

            string year = Console.ReadLine();

            int k=0;
            foreach(var person in persons)
            {
                var birth = person.Birthdate.Split('/');
                if (birth[2] == year)
                {
                    Console.WriteLine(person.Birthdate);
                    k++;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("<empty output>");
            }
        }
    }
}
