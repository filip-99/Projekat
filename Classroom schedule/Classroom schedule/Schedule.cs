using Shared.Interfaces.Business;
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
    public partial class Schedule : Form
    {
        private readonly ISchedulingBusiness schedulingBusiness;
        private readonly IPeriodBusiness periodBusiness;
        private readonly IClassroomBusiness classroomBusiness;
        public Schedule(ISchedulingBusiness schedulingBusiness, IPeriodBusiness periodBusiness, IClassroomBusiness classroomBusiness)
        {
            this.schedulingBusiness = schedulingBusiness;
            this.periodBusiness = periodBusiness;
            this.classroomBusiness = classroomBusiness;
            InitializeComponent();
        }
        //****************************************************************************************************************
        private void ShowWholeSchedule()
        {
            var innerJoin =
               from scheduling in schedulingBusiness.GetAllSchedulings()
               join classroom in classroomBusiness.GetAllClassrooms()
               on scheduling.Classroom_number equals classroom.Number
               join period in periodBusiness.GetAllPeriods()
               on scheduling.Period_id equals period.Id
               select new { ClassroomCapacity = classroom.Capacity, ClassroomNumber = classroom.Number, SchedulingDay = scheduling.Day, SchedulingPeriod = scheduling.Period_id, SchedulingNumber = classroom.Number, SchedulingOccupied = scheduling.Occupied, SchedulingDuty = scheduling.Duty_person, PeriodStart = period.Start_time, PeriodEnd = period.End_time };
            //Whole schedule[Scheduling + Classrooms]
            listBoxSchedule.Items.Add("Day\tClassroom number\tPeriod\tOccupied\tCapacity \t\tStart time \tEnd time\t\tPerson on duty");
            foreach (var i in innerJoin)
            {
                listBoxSchedule.Items.Add(i.SchedulingDay + "\t" + i.ClassroomNumber + "\t\t" + i.SchedulingPeriod + " \t" + i.SchedulingOccupied + "  \t" + i.ClassroomCapacity + "\t\t" + i.PeriodStart + " \t " + i.PeriodEnd + " \t" + i.SchedulingDuty);
            }
        }
        private void ShowFreePeriods()
        {
            var innerJoin =
            from scheduling in schedulingBusiness.GetAllSchedulings()
            join classroom in classroomBusiness.GetAllClassrooms()
            on scheduling.Classroom_number equals classroom.Number
            join period in periodBusiness.GetAllPeriods()
            on scheduling.Period_id equals period.Id
            select new { ClassroomCapacity = classroom.Capacity, ClassroomNumber = classroom.Number, SchedulingDay = scheduling.Day, SchedulingPeriod = scheduling.Period_id, SchedulingNumber = classroom.Number, SchedulingOccupied = scheduling.Occupied, SchedulingDuty = scheduling.Duty_person, PeriodStart = period.Start_time, PeriodEnd = period.End_time };
            listBoxSchedule.Items.Add("Day\tClassroom number\tPeriod\tOccupied\tCapacity \t\tStart time \tEnd time\t\tPerson on duty");
            foreach (var i in innerJoin)
            {
                if (i.SchedulingOccupied == false)
                    listBoxSchedule.Items.Add(i.SchedulingDay + "\t" + i.ClassroomNumber + "\t\t" + i.SchedulingPeriod + " \t" + i.SchedulingOccupied + "  \t" + i.ClassroomCapacity + "\t\t" + i.PeriodStart + " \t " + i.PeriodEnd + " \t" + i.SchedulingDuty);
            }
        }
        //*************************************************************************************************
        //Schedule for one classroom
        private void ScheduleForOneClassroom()
        {
            var innerJoin =
               
            from scheduling in schedulingBusiness.GetAllSchedulings()
            join classroom in classroomBusiness.GetAllClassrooms()
            on scheduling.Classroom_number equals classroom.Number
            join period in periodBusiness.GetAllPeriods()
            on scheduling.Period_id equals period.Id
            select new { ClassroomCapacity = classroom.Capacity, ClassroomNumber = classroom.Number, SchedulingDay = scheduling.Day, SchedulingPeriod = scheduling.Period_id, SchedulingNumber = classroom.Number, SchedulingOccupied = scheduling.Occupied, SchedulingDuty = scheduling.Duty_person, PeriodStart = period.Start_time, PeriodEnd = period.End_time };
            int ClNum;
            if (!string.IsNullOrEmpty(textBoxCSchedule.Text))
            {
                listBoxHelp.Items.Clear();
                ClNum = Convert.ToInt32(textBoxCSchedule.Text);
                listBoxHelp.Items.Add("Day\tClassroom number\tPeriod\tOccupied\tCapacity \t\tStart time \tEnd time\t\tPerson on duty");
                foreach (var i in innerJoin)
                {
                    if (i.ClassroomNumber == ClNum)
                        listBoxHelp.Items.Add(i.SchedulingDay + "\t" + i.ClassroomNumber + "\t\t" + i.SchedulingPeriod + " \t" + i.SchedulingOccupied + "  \t" + i.ClassroomCapacity + "\t\t" + i.PeriodStart + " \t " + i.PeriodEnd + " \t" + i.SchedulingDuty);
                }
            }
            else
            {
                MessageBox.Show("You did not enter which classroom you are checking for!");
                return;
            }
        }
        //*************************************************************************************************
        //FREE PERIODS FOR ONE CLASSROOM
        private void FreePeriodsForOneClassroom()
        {
            if (!string.IsNullOrEmpty(textBoxFreePeriods.Text))
            {
                var innerJoin =
              from scheduling in schedulingBusiness.GetAllSchedulings()
              join classroom in classroomBusiness.GetAllClassrooms()
              on scheduling.Classroom_number equals classroom.Number
              join period in periodBusiness.GetAllPeriods()
              on scheduling.Period_id equals period.Id
              select new { ClassroomCapacity = classroom.Capacity, ClassroomNumber = classroom.Number, SchedulingDay = scheduling.Day, SchedulingPeriod = scheduling.Period_id, SchedulingNumber = classroom.Number, SchedulingOccupied = scheduling.Occupied, SchedulingDuty = scheduling.Duty_person, PeriodStart = period.Start_time, PeriodEnd = period.End_time };
                int ClNum;

                listBoxHelp.Items.Clear();

                ClNum = Convert.ToInt32(textBoxFreePeriods.Text);
                listBoxHelp.Items.Add("Day\tClassroom number\tPeriod\tOccupied\tCapacity \t\tStart time \tEnd time\t\tPerson on duty");
                foreach (var i in innerJoin)
                {
                    if (i.ClassroomNumber == ClNum && i.SchedulingOccupied == false)
                        listBoxHelp.Items.Add(i.SchedulingDay + "\t" + i.ClassroomNumber + "\t\t" + i.SchedulingPeriod + " \t" + i.SchedulingOccupied + "  \t" + i.ClassroomCapacity + "\t\t" + i.PeriodStart + " \t " + i.PeriodEnd + " \t" + i.SchedulingDuty);
                }
            }
            else
            {
                MessageBox.Show("You did not enter which classroom you are checking for!");
                return;
            }
        }
        //*************************************************************************************************
        //Periods in range
        private void PeriodsInRange()
        {
            if (!string.IsNullOrEmpty(textBoxFrom.Text) && !string.IsNullOrEmpty(textBoxTo.Text))
            {

                listBoxHelp.Items.Clear();
                var innerJoin =
               from scheduling in schedulingBusiness.GetAllSchedulings()
               join classroom in classroomBusiness.GetAllClassrooms()
               on scheduling.Classroom_number equals classroom.Number
               join period in periodBusiness.GetAllPeriods()
               on scheduling.Period_id equals period.Id
               select new { ClassroomCapacity = classroom.Capacity, ClassroomNumber = classroom.Number, SchedulingDay = scheduling.Day, SchedulingPeriod = scheduling.Period_id, SchedulingNumber = classroom.Number, SchedulingOccupied = scheduling.Occupied, SchedulingDuty = scheduling.Duty_person, PeriodStart = period.Start_time, PeriodEnd = period.End_time };
                //All periods[Scheduling + Classrooms]
                listBoxHelp.Items.Add("Day\tClassroom number\tPeriod\tOccupied\tCapacity\t\tStart time\tEnd time\t\tPerson on duty");
                listBoxHelp.Items.Add("Day\tClassroom number\tPeriod\tOccupied\tCapacity\t\tStart time\tEnd time\t\tPerson on duty");
                foreach (var i in innerJoin)
                {
                    if (i.PeriodStart >= TimeSpan.Parse(textBoxFrom.Text) && i.PeriodEnd <= TimeSpan.Parse(textBoxTo.Text))
                        listBoxHelp.Items.Add(i.SchedulingDay + "\t" + i.ClassroomNumber + "\t\t" + i.SchedulingPeriod + " \t" + i.SchedulingOccupied + "  \t" + i.ClassroomCapacity + "\t" + i.PeriodStart + " \t " + i.PeriodEnd + " \t" + i.SchedulingDuty);
                }
            }
            else
            {
                MessageBox.Show("You didn't fill some field!");
            }
        }


        private void buttonScheduling_Click(object sender, EventArgs e)
        {
            Login2 l = new Login2(schedulingBusiness, periodBusiness, classroomBusiness);
            this.Hide();
            l.ShowDialog();
            l.BringToFront();

        }

        private void buttonShowSchedule_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule(schedulingBusiness, periodBusiness, classroomBusiness);
            this.Hide();
            s.ShowDialog();
            s.BringToFront();
        }

        private void buttonShowS_Click(object sender, EventArgs e)
        {
            listBoxSchedule.Items.Clear();
            ShowWholeSchedule();
        }

        private void buttonOnlyFree_Click(object sender, EventArgs e)
        {
            listBoxSchedule.Items.Clear();
            ShowFreePeriods();
        }

        private void buttonShowCSchedule_Click(object sender, EventArgs e)
        {
            listBoxHelp.Items.Clear();
            ScheduleForOneClassroom();
        }

        private void buttonShowFreeClassrooms_Click(object sender, EventArgs e)
        {
            listBoxHelp.Items.Clear();
            FreePeriodsForOneClassroom();
        }

        private void buttonFromTo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCSchedule.Text))
            {
                listBoxHelp.Items.Clear();
                PeriodsInRange();
            }
            else
            {
                MessageBox.Show("You didn't fill some field!");
            }
        }

        private void listBoxSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            string schedule = listBoxSchedule.SelectedItem.ToString();
           textBoxCSchedule.Text = schedule.Split('\t')[1].Trim();
            textBoxFreePeriods.Text = schedule.Split('\t')[1].Trim();
            textBoxFrom.Text = schedule.Split('\t')[7].Trim();
            textBoxTo.Text = schedule.Split('\t')[8].Trim();
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }   
    }
}
