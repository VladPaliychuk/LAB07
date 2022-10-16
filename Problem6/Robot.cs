using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Robot : IRobot, IPerson
    {
        string model;
        string id;
        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }

        public string Model => this.model;

        //string IRobot.Model => Model;

        public string Id => this.id;

        //string IPerson.Id => Id;
    }
}
