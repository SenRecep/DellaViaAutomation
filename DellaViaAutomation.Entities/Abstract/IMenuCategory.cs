using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
   public interface IMenuCategory
    {
         string Name { get; set; }
        ICollection<Menu> Menus { get; set; }
    }
}
