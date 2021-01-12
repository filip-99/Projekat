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
    public class ClassroomBusiness : IClassroomBusiness
    {
        private readonly IClassroomRepository classroomRepository;

        public ClassroomBusiness(IClassroomRepository classroomRepository)
        {
            this.classroomRepository = classroomRepository;
        }

        public List<Classroom> GetAllClassrooms()
        {
            return classroomRepository.GetClassrooms();
        }
        //*************************************************************************************************
        public Boolean InsertOneClassroom(Classroom c)
        {
            if (this.classroomRepository.InsertClassroom(c) > 0)
                return true;
            else
                return false;
        }
        //*************************************************************************************************
        public Boolean UpdateOneClassroom(Classroom c)
        {
            if (classroomRepository.UpdateClassroom(c) > 0)
                return true;
            else
                return false;
        }
    }
}
