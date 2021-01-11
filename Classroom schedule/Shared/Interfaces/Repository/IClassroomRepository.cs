using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IClassroomRepository
    {
        List<Classroom> GetClassroom();
        int InsertClassroom(Classroom c);
        int UpdateClassroom(Classroom c);
    }
}
