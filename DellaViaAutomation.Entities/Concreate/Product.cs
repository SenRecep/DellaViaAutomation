using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Product : ComplexType.EntityBase, Abstract.IProduct
    {
        public string Name { get ; set ; }

        public int Categoryid { get ; set ; }
        public Category Category { get ; set ; }

        public string ImageId { get; set; }
        public string OriginalFilename { get; set; }
        public string Description { get ; set ; }

        public decimal Price { get ; set ; }
        public decimal Tax { get ; set ; }
        public decimal Discount { get ; set ; }
    }
}
