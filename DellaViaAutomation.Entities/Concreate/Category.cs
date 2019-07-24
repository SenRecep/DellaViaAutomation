using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DellaViaAutomation.Entities.Abstract;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Category : ComplexType.EntityBase, Abstract.ICategory
    {
        public int Parentid { get ; set ; }
        public string Name { get ; set ; }
    }
}
