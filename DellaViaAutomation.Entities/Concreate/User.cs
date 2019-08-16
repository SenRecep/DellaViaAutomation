using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.Concreate
{
    public partial class User : ComplexType.EntityBase, Abstract.IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
    public partial class User
    {
        public string GetFullName { get { return $"{FirstName} {LastName}"; } }
    }
}
