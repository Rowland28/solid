using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingOpenClosedPrinciple
{
    class FeaturedProducts : Product
    {
        public FeaturedProducts(decimal price /*ProductType Type*/) : base(price /*Type*/)
        {
           
        }
        public override void Render()
        {
            Console.WriteLine("******* WOO! *******");
            Console.WriteLine("******* FEATURED PRODUCT HERE **********");
            Console.WriteLine("******* I COST £{0} **********", _price);
        }
    }
}
