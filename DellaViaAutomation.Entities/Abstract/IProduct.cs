using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
   public  interface IProduct
    {
        string Name { get; set; }

        int Categoryid { get; set; }
        Concreate.Category Category { get; set; }

        string ImageUrl { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        decimal Tax { get; set; }
        decimal Discount { get; set; }
        int IsEnable { get; set; }
    }
}
