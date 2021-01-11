using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface ISchedulingRepository
    {
        List<Scheduling> GetSchedulings();
        int InsertScheduling(Scheduling s);
        int UpdateScheduling(Scheduling s);
        int DeleteScheduling(Scheduling s);
    }
}
