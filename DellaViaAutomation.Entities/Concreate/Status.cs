using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DellaViaAutomation.Entities.Abstract;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Status : ComplexType.EntityBase, Abstract.IStatus
    {

        string IStatus.Name { get; set; }
    }
}
