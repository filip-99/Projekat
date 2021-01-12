using BusinessLogicLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_schedule
{
    public partial class UserControlScheduling : UserControl
    {
        private readonly ISchedulingBusiness schedulingBusiness;
        private readonly IClassroomBusiness classroomBusiness;
        private readonly IPeriodBusiness periodBusiness;

        public UserControlScheduling()
        {
            InitializeComponent();
        }
        private void ShowSchedule()
        {
            listBoxSchedule.Items.Clear();

            List<Scheduling> listScheduling = schedulingBusiness.GetAllSchedulings();

            foreach (Scheduling r in listScheduling)
            {
                listBoxSchedule.Items.Add(r.Day + ". \t" + r.Period_id + ". \t" + r.Classroom_number + ". \t" + r.Occupied + ". \t" + r.Duty_person);
            }

        }
        private void ShowPeriods()
        {
            listBoxPeriods.Items.Clear();

            List<Period> listPeriods = periodBusiness.GetAllPeriods();
            foreach (Period t in listPeriods)
            {
                listBoxPeriods.Items.Add(t.Id + ". \t" + t.Start_time + ". \t" + t.End_time);
            }
        }
        private void ShowClassrooms()
        {
            listBoxClassrooms.Items.Clear();

            List<Classroom> listClassroom = classroomBusiness.GetAllClassrooms();

            foreach (Classroom u in listClassroom)
            {
                listBoxClassrooms.Items.Add(u.Number + ". \t" + u.Capacity);
            }

        }

        private void UserControlScheduling_Load(object sender, EventArgs e)
        {

        }
    }
}
