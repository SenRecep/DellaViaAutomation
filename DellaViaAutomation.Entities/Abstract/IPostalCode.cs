using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
  public interface IPostalCode
    {
        int Code { get; set; }
        string City { get; set; }
    }
}
