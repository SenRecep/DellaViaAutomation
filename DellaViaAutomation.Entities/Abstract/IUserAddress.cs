using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface IUserAddress
    {
        int Userid { get; set; }
        Concreate.User User { get; set; }

        string Title { get; set; }
        Concreate.PostalCode postalCode { get; set; }
        string Address { get; set; }
    }
}
