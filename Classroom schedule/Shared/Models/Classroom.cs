using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Classroom
    {
        private int number;
        private int capacity;

        public int Number { get => number; set => number = value; }
        public int Capacity { get => capacity; set => capacity = value; }
    }
}
