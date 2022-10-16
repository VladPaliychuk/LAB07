using Problem5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Pet : IPEt, IBirth
    {
        string name;
        string birthdate;
        public Pet(string name, string birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }

        public string Name => this.name;

        public string Birthdate => this.birthdate;
        //string IPEt.Name => this.name;
        //string IBirth.Birthdate => this.birthdate;
    }
}
