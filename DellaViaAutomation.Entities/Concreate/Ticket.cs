using DellaViaAutomation.Entities.Abstract;
using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    public class Ticket : EntityBase, ITicket
    {
        public User user { get; set; }
        public Product product { get; set; }
        public string Message { get; set; }
    }
}
