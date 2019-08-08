using DellaViaAutomation.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    class PizzaItems : IPizzaItems
    {
        public string Name { get; set; }
        public  String Topping { get; set; }
        public Toppings ExtraTopping { get; set; }
        public double Price {
            get {
                return Price;
            }
            
            set 
            {
                Price += ExtraTopping.Price; 
            }
        }
    }
}
