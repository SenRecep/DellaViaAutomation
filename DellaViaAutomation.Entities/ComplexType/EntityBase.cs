using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Entities.ComplexType
{
    public class EntityBase : Abstract.IEntityBase
    {
        public int id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserid { get; set; }
        public bool IsActive { get; set; }
    }
}
