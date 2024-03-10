using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron3
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = "Unknow Beverage";
        public abstract double Cost();
    }
}
