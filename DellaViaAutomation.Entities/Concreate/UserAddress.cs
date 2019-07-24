using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    public class UserAddress : ComplexType.EntityBase, Abstract.IUserAddress
    {
        public int Userid { get; set; }
        public User User { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }
        public PostalCode postalCode { get; set; }
    }
}
