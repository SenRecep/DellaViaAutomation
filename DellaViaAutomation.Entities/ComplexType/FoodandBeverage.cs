using DellaViaAutomation.Entities.Abstract;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.ComplexType
{
    public class FoodandBeverage :Product, IFoodandBeverage
    {
        public FoodandBeverageSize FoodandBeverageSize { get; set; }
    }
}
