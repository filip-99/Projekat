using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface ISchedulingBusiness
    {
        List<Scheduling> GetAllSchedulings();
        Boolean InsertOneScheduling(Scheduling s);
        Boolean UpdateOneScheduling(Scheduling s);
        Boolean DeleteOneScheduling(Scheduling s);
    }
}
