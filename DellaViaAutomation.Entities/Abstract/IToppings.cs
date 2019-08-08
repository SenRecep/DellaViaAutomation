using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    interface IToppings
    {
         int Id { get; set; }
         string ToppingName { get; set; }
         double Price { get; set; }
    }
}
