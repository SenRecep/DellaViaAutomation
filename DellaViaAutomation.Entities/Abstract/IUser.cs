using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DellaViaAutomation.Entities.Abstract
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Telephone { get; set; }
        string Password { get; set; }
        bool IsAdmin { get; set; }
        string ImageId { get; set; }
        string OriginalFilename { get; set; }

        ICollection<Concreate.UserAddress> UserAddresses { get; set; }
    }
}
