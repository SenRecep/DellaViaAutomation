using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DellaViaAutomation.Entities.Abstract
{
   public  interface IProduct
    {
        string Name { get; set; }

        int Categoryid { get; set; }
        Concreate.Category Category { get; set; }
        string ImageId { get; set; }
        string OriginalFilename { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        decimal Tax { get; set; }
        decimal Discount { get; set; }
    }
}
