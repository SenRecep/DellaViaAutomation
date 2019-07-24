using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Basket : ComplexType.EntityBase, Abstract.IBasket
    {
        public int Userid { get ; set ; }
        public int Productid { get ; set ; }
        public Product Product { get ; set ; }
        public int Quantity { get ; set ; }
    }
}
