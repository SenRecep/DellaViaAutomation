using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface IOrderPayment
    {
        int Orderid { get; set; }
        PaymentType PaymentType { get; set; }
        decimal Price { get; set; }
        string Bank { get; set; }
    }
}
