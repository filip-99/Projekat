using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IClassroomBusiness
    {
        List<Classroom> GetAllClassrooms();
        Boolean InsertOneClassroom(Classroom c);
        Boolean UpdateOneClassroom(Classroom c);
    }
}
