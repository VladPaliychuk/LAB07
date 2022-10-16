using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
        string Name { get; set; }
        int Age { get; set; }
        string Id { get; set; }
        string Birthdate { get; set; }

        string IPerson.Name => Name;
        int IPerson.Age => Age;
        string IBirthable.Birthdate => Birthdate;
        string IIdentifiable.Id => Id;


    }
}
