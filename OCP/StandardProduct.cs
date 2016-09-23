using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingOpenClosedPrinciple
{
    class StandardProduct : Product
        {
            public StandardProduct(decimal price /*ProductType Type*/) : base(price /*Type*/)
            {
       
            }
            public override void Render()
            {
            Console.WriteLine("Hi, I am a standard product that costs £{0}", _price);
        }
    }
}
