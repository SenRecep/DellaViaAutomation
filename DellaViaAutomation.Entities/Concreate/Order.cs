﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DellaViaAutomation.Entities.ComplexType;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Order : ComplexType.EntityBase, Abstract.IOrder
    {
        public int Userid { get ; set ; }
        public User User { get ; set ; }
        public int UserAddressid { get ; set ; }
        public UserAddress UserAddress { get ; set ; }
        public int Statusid { get ; set ; }
        public Status Status { get ; set ; }
        public decimal TotalProductPrice { get ; set ; }
        public decimal TotalTaxPrice { get ; set ; }
        public decimal TotalDiscountPrice { get ; set ; }
        public decimal TotalPrice { get ; set ; }
        public IEnumerable<OrderPayment> OrderPayments { get ; set ; }
        public IEnumerable<OrderProduct> OrderProducts { get ; set ; }
    }
}
