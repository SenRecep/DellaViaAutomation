using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Product : ComplexType.EntityBase, Abstract.IProduct
    {
        public string Name { get ; set ; }

        public int Categoryid { get ; set ; }
        public Category Category { get ; set ; }

        public string ImageUrl { get ; set ; }
        public string Description { get ; set ; }
        public decimal Price { get ; set ; }
        public decimal Tax { get ; set ; }
        public decimal Discount { get ; set ; }
        public int IsEnable { get ; set ; }
    }
}
