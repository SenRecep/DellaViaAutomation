using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DellaViaAutomation.Entities.Abstract;

namespace DellaViaAutomation.Entities.Concreate
{
    public class PostalCode : ComplexType.EntityBase, Abstract.IPostalCode
    {
        public string City { get; set; }
        int IPostalCode.PostalCode { get; set; }
    }
}
