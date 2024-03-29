﻿using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
  public interface IOrder
    {
        int UserAddressid { get; set; }
        UserAddress UserAddress { get; set; }

        int Statusid { get; set; }
        Status Status { get; set; }

        decimal TotalProductPrice { get; set; }
        decimal TotalTaxPrice { get; set; }
        decimal TotalDiscountPrice { get; set; }
        decimal TotalPrice { get; set; }

        ICollection<OrderPayment> OrderPayments { get; set; }
        ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
