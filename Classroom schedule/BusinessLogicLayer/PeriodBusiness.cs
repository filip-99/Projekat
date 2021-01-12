using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PeriodBusiness : IPeriodBusiness
    {
        private readonly IPeriodRepository periodRepository;

        public PeriodBusiness(IPeriodRepository periodRepository)
        {
            this.periodRepository = periodRepository;
        }

        public List<Period> GetAllPeriods()
        {
            return periodRepository.GetPeriods();
        }
        //*************************************************************************************************
        public Boolean InsertOnePeriod(Period p)
        {
            if (this.periodRepository.InsertPeriod(p) > 0)
                return true;
            else
                return false;
        }
        //*************************************************************************************************
        public Boolean UpdateOnePeriod(Period p)
        {
            if (periodRepository.UpdatePeriod(p) > 0)
                return true;
            else
                return false;
        }
    }
}
