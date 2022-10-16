using System;
using System.Collections.Generic;

namespace Problem5
{
    internal class BorderControl
    {
        static void Main(string[] args)
        {
            var persons = new List<IPerson>();
            int k = 0;
            string input = Console.ReadLine();
            do
            {
                string[] inputSplit=input.Split(' ');
                if(inputSplit.Length == 3)
                {
                    string name = inputSplit[0];
                    string age = inputSplit[1];
                    string id = inputSplit[2];
                    //IPerson citizen = new Citizen(age, name, id);
                    persons.Add(new Citizen(age, name, id));
                }
                if(inputSplit.Length == 2)
                {
                    string model = inputSplit[0];
                    string id = inputSplit[1];
                    //IPerson robot = new Robot(model, id);
                    persons.Add(new Robot(model, id));
                }
                k++;
                input= Console.ReadLine();
            }
            while(input != "END");

            //int fakeId = int.Parse(Console.ReadLine());
            string fakeId = Console.ReadLine();

            foreach(var person in persons)
            {
                //int ID = int.Parse(person.Id);
                string ID = person.Id;
                int L1 = ID.Length-1;
                int L2 = fakeId.Length;
                char[] ID1 = ID.ToCharArray();
                char[] ID2 = fakeId.ToCharArray();
                int j = L2;
                int n = L2;

                for(int i = L1; i > L1-L2; i--)
                {
                    if(ID1[i] == ID2[j-1])
                    {
                        n--;
                    }
                    j--;
                    if (n == 0)
                    {
                        Console.WriteLine(ID);
                        break;
                    }
                }                
            }
        }
    }
}
