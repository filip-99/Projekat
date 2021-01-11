using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Period
    {
        private int id;
        private TimeSpan start_time;
        private TimeSpan end_time;

        public int Id { get => id; set => id = value; }
        public TimeSpan Start_time { get => start_time; set => start_time = value; }
        public TimeSpan End_time { get => end_time; set => end_time = value; }
    }
}
