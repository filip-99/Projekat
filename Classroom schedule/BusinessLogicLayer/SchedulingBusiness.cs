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
    public class SchedulingBusiness : ISchedulingBusiness
    {
        private readonly ISchedulingRepository schedulingRepository;
        public SchedulingBusiness(ISchedulingRepository schedulingRepository)
        {
            this.schedulingRepository = schedulingRepository;
        }
        //*************************************************************************************************
        public List<Scheduling> GetAllSchedulings()
        {
            return schedulingRepository.GetSchedulings();
        }
        //*************************************************************************************************
        public Boolean InsertOneScheduling(Scheduling s)
        {
            if (this.schedulingRepository.InsertScheduling(s) > 0)
                return true;
            else
                return false;
        }
        //*************************************************************************************************
        public Boolean UpdateOneScheduling(Scheduling s)
        {
            if (schedulingRepository.UpdateScheduling(s) > 0)
                return true;
            else
                return false;
        }
        //*************************************************************************************************
        public Boolean DeleteOneScheduling(Scheduling s)
        {
            if (schedulingRepository.DeleteScheduling(s) > 0)
                return true;
            else
                return false;
        }
    }
}
