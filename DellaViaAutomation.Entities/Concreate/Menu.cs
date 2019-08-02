using DellaViaAutomation.Entities.Abstract;
using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Menu : EntityBase, IMenu
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<FoodandBeverage> Products { get; set; }
    }
}
