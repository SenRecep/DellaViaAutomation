using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DellaViaAutomation.Entities.Abstract;
using DellaViaAutomation.Entities.ComplexType;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Category : ComplexType.EntityBase, Abstract.ICategory
    {
        public int Parentid { get ; set ; }
        public string Name { get ; set ; }
        public string ImageId { get; set; }
        public string OriginalFilename { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
