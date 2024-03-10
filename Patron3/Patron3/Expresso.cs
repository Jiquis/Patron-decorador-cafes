using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron3
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso coffee";
        }
        public override double Cost()
        {
            return 1.11;
        }
    }
}
