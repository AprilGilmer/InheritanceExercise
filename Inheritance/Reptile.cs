using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public bool ForkTongue { get; set; }
        public string ScaleColor { get; set; }
        public bool HasShell { get; set; }

    }
}
