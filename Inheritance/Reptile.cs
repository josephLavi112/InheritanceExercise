using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsExtinct { get; set; }
        public bool HasScales { get; set; }
        public bool HasShell { get; set; }
        public bool HasLegs { get; set; }
         
    }
}
