using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface ITicket
    {
        User user { get; set; }
        Product product { get; set; }
        string Message { get; set; }

    }
}
