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
        //*******************************************************************************************************************************************
        private void ShowSchedule()
        {
            listBoxSchedule.Items.Clear();

            List<Scheduling> listScheduling = schedulingBusiness.GetAllSchedulings();

            foreach (Scheduling r in listScheduling)
            {
                listBoxSchedule.Items.Add(r.Day + ". \t" + r.Period_id + ". \t" + r.Classroom_number + ". \t" + r.Occupied + ". \t" + r.Duty_person);
            }

        }
        //*********************************************************************************************************************************************
        private void ShowPeriods()
        {
            listBoxPeriods.Items.Clear();

            List<Period> listPeriods = periodBusiness.GetAllPeriods();
            foreach (Period t in listPeriods)
            {
                listBoxPeriods.Items.Add(t.Id + ". \t" + t.Start_time + ". \t" + t.End_time);
            }
        }
        //*******************************************************************************************************************************************
        private void ShowClassrooms()
        {
            listBoxClassrooms.Items.Clear();

            List<Classroom> listClassroom = classroomBusiness.GetAllClassrooms();

            foreach (Classroom u in listClassroom)
            {
                listBoxClassrooms.Items.Add(u.Number + ". \t" + u.Capacity);
            }

        }
        //*********************************************************************************************************************************************
        private void InsertSchedule()
        {
            List<Scheduling> listScheduling = new List<Scheduling>();
            if (!string.IsNullOrEmpty(textBoxDay.Text) && !string.IsNullOrEmpty(textBoxPeriod.Text) && !string.IsNullOrEmpty(textBoxCNumber.Text) && !string.IsNullOrEmpty(textBoxOccupied.Text))
            {
                Scheduling r = new Scheduling();
                r.Day = Convert.ToInt32(textBoxDay.Text);
                r.Period_id = Convert.ToInt32(textBoxPeriod.Text);
                r.Classroom_number = Convert.ToInt32(textBoxCNumber.Text);
                r.Occupied = Convert.ToBoolean(textBoxOccupied.Text);
                r.Duty_person = textBoxDuty.Text;
                if (string.IsNullOrEmpty(textBoxDuty.Text) && Convert.ToBoolean(textBoxOccupied.Text) == true)
                {
                    MessageBox.Show("If you have entered a person on duty, the period must be filled in!");
                    return;
                }
                else if (!string.IsNullOrEmpty(textBoxDuty.Text) && Convert.ToBoolean(textBoxOccupied.Text) == false)
                {
                    MessageBox.Show("If you have entered a period, the person on duty must be filled in!");
                    return;
                }
                foreach (Scheduling rz in schedulingBusiness.GetAllSchedulings())
                    if (Convert.ToInt32(textBoxDay.Text) == rz.Day && Convert.ToInt32(textBoxPeriod.Text) == rz.Period_id && Convert.ToInt32(textBoxCNumber.Text) == rz.Classroom_number && Convert.ToBoolean(textBoxOccupied.Text) == rz.Occupied && textBoxDuty.Text == rz.Duty_person)
                    {
                        MessageBox.Show("This period already exists");
                        return;
                    }
                if (this.schedulingBusiness.InsertOneScheduling(r))
                {
                    ShowSchedule();
                    MessageBox.Show("Successful entry!");
                }
                else
                    MessageBox.Show("Scheduling is not entered in the database!");
            }
            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }
        }
        //*********************************************************************************************
        private void InsertClassroom()
        {
            List<Classroom> listClassroom = new List<Classroom>();
            Classroom u = new Classroom();
            u.Number = Convert.ToInt32(textBoxNumber.Text);
            u.Capacity = Convert.ToInt32(textBoxCapacity.Text);

            if (this.classroomBusiness.InsertOneClassroom(u))
            {
                ShowClassrooms();
                MessageBox.Show("Successful entry!");
            }
            else
                MessageBox.Show("Classroom is not entered in the database!");
        }
        //******************************************************************************************
        private void InsertPeriod()
        {

            List<Period> listTPeriod = new List<Period>();
            Period t = new Period();
            t.Id = Convert.ToInt32(textBoxID.Text);
            t.Start_time = TimeSpan.Parse(textBoxStart.Text);
            t.End_time = TimeSpan.Parse(textBoxEnd.Text);

            if (!string.IsNullOrEmpty(textBoxID.Text) && !string.IsNullOrEmpty(textBoxStart.Text) && !string.IsNullOrEmpty(textBoxEnd.Text))
            {
                foreach (Period te in periodBusiness.GetAllPeriods())
                    if (Convert.ToInt32(textBoxID.Text) == te.Id && TimeSpan.Parse(textBoxStart.Text) == te.Start_time && TimeSpan.Parse(textBoxEnd.Text) == te.End_time)
                    {
                        MessageBox.Show("This period already exists");
                        return;
                    }
                if (this.periodBusiness.InsertOnePeriod(t))
                {
                    ShowPeriods();
                    MessageBox.Show("Successful entry!");
                }
                else
                    MessageBox.Show("Period is not entered in the database!");
            }
            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }

        }
        //***********************************************************************************************

        private void UserControlScheduling_Load(object sender, EventArgs e)
        {

        }
    }
}
