using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron3
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => _beverage.Description + ", Whip";
        public override double Cost()
        {
            return .45 + _beverage.Cost();
        }
    }
}
