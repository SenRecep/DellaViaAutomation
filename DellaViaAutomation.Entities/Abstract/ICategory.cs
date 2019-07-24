using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface ICategory
    {
        int Parentid { get; set; }
        string Name { get; set; }
    }
}
