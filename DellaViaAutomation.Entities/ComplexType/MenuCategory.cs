using DellaViaAutomation.Entities.Abstract;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.ComplexType
{
    public class MenuCategory : EntityBase, IMenuCategory
    {
        public string Name { get; set; }
        public ICollection<Menu> Menus { get ; set ; }
    }
}
