using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    interface ICar
    {
        string Brake();
        string Gas();
        string Driver { get; }
        string Model { get;}
    }
}
