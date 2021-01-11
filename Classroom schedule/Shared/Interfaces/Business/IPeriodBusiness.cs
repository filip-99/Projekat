using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IPeriodBusiness
    {
        List<Period> GetAllPeriods();
        Boolean InsertOnePeriod(Period p);
        Boolean UpdateOnePeriod(Period p);
    }
}
