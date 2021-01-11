using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IPeriodRepository
    {
        List<Period> GetPeriod();
        int InsertPeriod(Period p);
        int UpdatePeriod(Period p);
    }
}
