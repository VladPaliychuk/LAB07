using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Citizen : ICitizen, IPerson
    {
        string age;
        string name;
        string id;
        public Citizen(string age, string name, string id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }
        public string Age => this.age;
        public string Name => this.name;
        public string Id => this.id;
        string ICitizen.Age => Age;
        string ICitizen.Name => Name;
        string IPerson.Id => Id;
    }
}
