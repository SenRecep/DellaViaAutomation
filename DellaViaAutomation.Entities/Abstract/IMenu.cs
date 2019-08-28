using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface IMenu
    {
        string Name { get; set; }
        string ImageId { get; set; }
        string OriginalFilename { get; set; }
        int MenuCategoryid { get; set; }
        Menu MenuCategory { get; set; }
        ICollection<FoodandBeverage> Products { get; set; }
    }
}
