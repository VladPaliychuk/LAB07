using Problem6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Citizen : ICitizen, IPerson, IBirth
    {
        string age;
        string name;
        string id;
        string birthdate;
        public Citizen(string age, string name, string id, string birthdate)
        {
            this.age = age;
            this.name = name;
            this.id = id;
            this.birthdate = birthdate;
        }
        public string Age => this.age;
        public string Name => this.name;
        public string Id => this.id;
        public string Birthdate => this.birthdate;
        //string IBirth.Birthdate => this.birthdate;
        //string ICitizen.Age => Age;
        //string ICitizen.Name => Name;
        //string IPerson.Id => Id;
    }
}
