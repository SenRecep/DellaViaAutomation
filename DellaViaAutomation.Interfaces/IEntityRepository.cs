using DellaViaAutomation.Dal.Abstract.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Interfaces
{
    public interface IEntityRepository<T> : IRepository<T> where T : class
    {
    }
}
