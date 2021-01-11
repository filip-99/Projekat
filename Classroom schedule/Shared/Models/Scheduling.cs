using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Scheduling
    {
        private int day;
        private int period_id;
        private int classroom_number;
        private Boolean occupied;
        private string duty_person;

        public int Day { get => day; set => day = value; }
        public int Period_id { get => period_id; set => period_id = value; }
        public int Classroom_number { get => classroom_number; set => classroom_number = value; }
        public bool Occupied { get => occupied; set => occupied = value; }
        public string Duty_person { get => duty_person; set => duty_person = value; }
    }
}
