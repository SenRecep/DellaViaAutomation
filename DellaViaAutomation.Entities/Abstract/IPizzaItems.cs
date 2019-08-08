using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    interface IPizzaItems
    {
         string Name { get; set; }
         String Topping { get; set; }
         Toppings ExtraTopping { get; set; }
         double Price { get; set; }
    }
}
