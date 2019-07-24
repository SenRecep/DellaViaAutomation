using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DellaViaAutomation.Entities.Concreate;

namespace DellaViaAutomation.Entities.ComplexType
{
    public class OrderProduct : ComplexType.EntityBase, Abstract.IOrderProduct
    {
        public int Orderid { get ; set ; }
        public Order Order { get; set; }

        public int Productid { get ; set ; }
        public Product Product { get ; set ; }

        public int Quantity { get ; set ; }
    }
}
