using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Ferrari : ICar
    {
        string driver;
        string model = "488-Spider";
        public Ferrari(string driver)
        {
            Driver = driver;
        }

        string Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }
        string Model {
            get { return this.model; }
        }

        string ICar.Model => Model;
        string ICar.Driver => Driver;

        public string Gas()
        {   
            return "Zadu6avam sA!";
        }
        public string Brake()
        {
            return "Brakes!";
        }
        public override string ToString()
        {
            return $"{Model}/{Brake()}/{Gas()}/{Driver}";
        }
    }
}
