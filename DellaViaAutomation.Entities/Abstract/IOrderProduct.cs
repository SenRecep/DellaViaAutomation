using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface IOrderProduct
    {
        int Orderid { get; set; }
        int Productid { get; set; }
        Product Product { get; set; }
        int Quantity { get; set; }
    }
}
