using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.ComplexType
{
    public class OrderPayment : ComplexType.EntityBase, Abstract.IOrderPayment
    {
        public int Orderid { get; set; }
        public Order Order { get; set; }

        public Abstract.PaymentType PaymentType { get; set; }
        public decimal Price { get; set; }
        public string Bank { get; set; }
    }
}
