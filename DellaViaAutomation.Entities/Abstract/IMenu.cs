using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface IMenu
    {
        string Name { get; set; }
        string ImageUrl { get; set; }
        int MenuCategoryid { get; set; }
        Menu MenuCategory { get; set; }
        ICollection<FoodandBeverage> Products { get; set; }
    }
}
