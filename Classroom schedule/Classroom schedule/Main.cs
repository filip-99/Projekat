using Shared.Interfaces.Business;
using BusinessLogicLayer;
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
    public partial class Main : Form
    {
        private readonly ISchedulingBusiness schedulingBusiness;
        private readonly IPeriodBusiness periodBusiness;
        private readonly IClassroomBusiness classroomBusiness;

        public Main()
        {
        }

        public Main(ISchedulingBusiness schedulingBusiness, IPeriodBusiness periodBusiness, IClassroomBusiness classroomBusiness)
        {
            InitializeComponent();
            this.schedulingBusiness = schedulingBusiness;
            this.periodBusiness = periodBusiness;
            this.classroomBusiness = classroomBusiness;
            
        }

        private void buttonScheduling_Click(object sender, EventArgs e)
        {
            Main m = new Main(schedulingBusiness, periodBusiness, classroomBusiness);
            this.Close();
            m.Show();
        }

        
        private void ShowSchedule()
        {
            listBoxSchedule.Items.Clear();

            List<Scheduling> listScheduling = schedulingBusiness.GetAllSchedulings();


            foreach (Scheduling s in listScheduling)
            {
                listBoxSchedule.Items.Add(s.Day + ". \t" + s.Period_id + ". \t" + s.Classroom_number + ". \t" + s.Occupied + ". \t" + s.Duty_person);
            }

        }
        private void ShowPeriods()
        {
            listBoxPeriods.Items.Clear();

            List<Period> listPeriods = periodBusiness.GetAllPeriods();
            foreach (Period p in listPeriods)
            {
                listBoxPeriods.Items.Add(p.Id + ". \t" + p.Start_time + ". \t" + p.End_time);
            }
        }
        private void ShowClassrooms()
        {
            listBoxClassrooms.Items.Clear();

            List<Classroom> listClassroom = classroomBusiness.GetAllClassrooms();

            foreach (Classroom c in listClassroom)
            {
                listBoxClassrooms.Items.Add(c.Number + ". \t" + c.Capacity);
            }

        }

        private void InsertSchedule()
        {
            List<Scheduling> listScheduling = new List<Scheduling>();
            if (!string.IsNullOrEmpty(textBoxDay.Text) && !string.IsNullOrEmpty(textBoxPeriod.Text) && !string.IsNullOrEmpty(textBoxCNumber.Text) && !string.IsNullOrEmpty(textBoxOccupied.Text))
            {
                Scheduling s = new Scheduling();
                s.Day = Convert.ToInt32(textBoxDay.Text);
                s.Period_id = Convert.ToInt32(textBoxPeriod.Text);
                s.Classroom_number = Convert.ToInt32(textBoxCNumber.Text);
                s.Occupied = Convert.ToBoolean(textBoxOccupied.Text);
                s.Duty_person = textBoxOccupied.Text;
                if (string.IsNullOrEmpty(textBoxOccupied.Text) && Convert.ToBoolean(textBoxOccupied.Text) == true)
                {
                    MessageBox.Show("If you have entered a person on duty, the period must be filled in!");
                    return;
                }
                else if (!string.IsNullOrEmpty(textBoxOccupied.Text) && Convert.ToBoolean(textBoxOccupied.Text) == false)
                {
                    MessageBox.Show("If you have entered a period, the person on duty must be filled in!");
                    return;
                }
                foreach (Scheduling sc in schedulingBusiness.GetAllSchedulings())
                    if (Convert.ToInt32(textBoxDay.Text) == sc.Day && Convert.ToInt32(textBoxPeriod.Text) == sc.Period_id && Convert.ToInt32(textBoxCNumber.Text) == sc.Classroom_number && Convert.ToBoolean(textBoxOccupied.Text) == sc.Occupied && textBoxOccupied.Text == sc.Duty_person)
                    {
                        MessageBox.Show("This period already exists");
                        return;
                    }
                if (this.schedulingBusiness.InsertOneScheduling(s))
                {
                    ShowSchedule();
                    MessageBox.Show("Successful entry!");
                }
                else
                    MessageBox.Show("Scheduling is not entered in the database");
            }
            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }
        }
        private void InsertClassroom()
        {
            List<Classroom> listClassroom = new List<Classroom>();
            Classroom c = new Classroom();
            c.Number = Convert.ToInt32(textBoxNumber.Text);
            c.Capacity = Convert.ToInt32(textBoxCapacity.Text);

            if (this.classroomBusiness.InsertOneClassroom(c))
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
            Period p = new Period();
            p.Id = Convert.ToInt32(textBoxID.Text);
            p.Start_time = TimeSpan.Parse(textBoxStart.Text);
            p.End_time = TimeSpan.Parse(textBoxEnd.Text);

            if (!string.IsNullOrEmpty(textBoxID.Text) && !string.IsNullOrEmpty(textBoxStart.Text) && !string.IsNullOrEmpty(textBoxEnd.Text))
            {
                foreach (Period pe in periodBusiness.GetAllPeriods())
                    if (Convert.ToInt32(textBoxID.Text) == pe.Id && TimeSpan.Parse(textBoxStart.Text) == pe.Start_time && TimeSpan.Parse(textBoxEnd.Text) == pe.End_time)
                    {
                        MessageBox.Show("This period already exists");
                        return;
                    }
                if (this.periodBusiness.InsertOnePeriod(p))
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
        private void UpdateSchedule()
        {
            if (!string.IsNullOrEmpty(textBoxDay.Text) && !string.IsNullOrEmpty(textBoxPeriod.Text) && !string.IsNullOrEmpty(textBoxCNumber.Text) && !string.IsNullOrEmpty(textBoxOccupied.Text))
            {
                if (string.IsNullOrEmpty(textBoxOccupied.Text) && Convert.ToBoolean(textBoxOccupied.Text) == true)
                {
                    MessageBox.Show("If you have entered a person on duty, the period must be filled in!");
                    return;
                }
                else if (!string.IsNullOrEmpty(textBoxOccupied.Text) && Convert.ToBoolean(textBoxOccupied.Text) == false)
                {
                    MessageBox.Show("If you have entered a period, the person on duty must be filled in!");
                    return;
                }

                foreach (Scheduling s in schedulingBusiness.GetAllSchedulings())
                    if (Convert.ToInt32(textBoxDay.Text) == s.Day && Convert.ToInt32(textBoxPeriod.Text) == s.Period_id && Convert.ToInt32(textBoxCNumber.Text) == s.Classroom_number && Convert.ToBoolean(textBoxOccupied.Text) == s.Occupied)
                    {
                        MessageBox.Show("You haven't changed anything!");
                        return;
                    }
                Scheduling sc = new Scheduling();
                sc.Day = Convert.ToInt32(textBoxDay.Text);
                sc.Period_id = Convert.ToInt32(textBoxPeriod.Text);
                sc.Classroom_number = Convert.ToInt32(textBoxCNumber.Text);
                sc.Occupied = Convert.ToBoolean(textBoxOccupied.Text);
                sc.Duty_person = textBoxOccupied.Text;
                if (schedulingBusiness.UpdateOneScheduling(sc))
                {
                    MessageBox.Show("Successful change!");
                    ShowSchedule();
                }
                else
                {
                    MessageBox.Show("Unsuccessful change!");
                }
            }
            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }
        }
        //********************************************************************************************
        private void UpdateClassroom()
        {

            if (!string.IsNullOrEmpty(textBoxNumber.Text) && !string.IsNullOrEmpty(textBoxCapacity.Text))
            {
                foreach (Classroom c in classroomBusiness.GetAllClassrooms())
                    if (Convert.ToInt32(textBoxNumber.Text) == c.Number && Convert.ToInt32(textBoxCapacity.Text) == c.Capacity)
                    {
                        MessageBox.Show("You haven't changed anything!");
                        return;
                    }
                Classroom cl = new Classroom();
                cl.Number = Convert.ToInt32(textBoxNumber.Text);
                cl.Capacity = Convert.ToInt32(textBoxCapacity.Text);
                if (classroomBusiness.UpdateOneClassroom(cl))
                {
                    MessageBox.Show("Successful change!");
                    ShowClassrooms();
                }
                else
                {
                    MessageBox.Show("Unsuccessful change!");
                }
            }
            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }
        }
        //*************************************************************************************************

        private void UpdatePeriod()
        {

            if (!string.IsNullOrEmpty(textBoxID.Text) && !string.IsNullOrEmpty(textBoxStart.Text) && !string.IsNullOrEmpty(textBoxEnd.Text))
            {
                foreach (Period pe in periodBusiness.GetAllPeriods())
                    if (Convert.ToInt32(textBoxID.Text) == pe.Id && TimeSpan.Parse(textBoxStart.Text) == pe.Start_time && TimeSpan.Parse(textBoxEnd.Text) == pe.End_time)
                    {
                        MessageBox.Show("You haven't changed anything!");
                        return;
                    }
                Period p = new Period();
                p.Id = Convert.ToInt32(textBoxID.Text);
                p.Start_time = TimeSpan.Parse(textBoxStart.Text);
                p.End_time = TimeSpan.Parse(textBoxEnd.Text);

                if (periodBusiness.UpdateOnePeriod(p))
                {
                    MessageBox.Show("Successful change!");
                    ShowPeriods();
                }
                else
                    MessageBox.Show("Unsuccessful change!");

            }
            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }
        }

        private void buttonShowS_Click(object sender, EventArgs e)
        {
            ShowSchedule();
        }

        private void buttonInsertS_Click(object sender, EventArgs e)
        {
            InsertSchedule();
        }

        private void buttonUpdateS_Click(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void buttonDeleteS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDay.Text) && !string.IsNullOrEmpty(textBoxPeriod.Text) && !string.IsNullOrEmpty(textBoxCNumber.Text) && !string.IsNullOrEmpty(textBoxOccupied.Text))
            {
                Scheduling s = new Scheduling();
                s.Day = Convert.ToInt32(textBoxDay.Text);
                s.Period_id = Convert.ToInt32(textBoxPeriod.Text);
                s.Classroom_number = Convert.ToInt32(textBoxCNumber.Text);
                s.Occupied = Convert.ToBoolean(textBoxOccupied.Text);
                s.Duty_person = textBoxDuty.Text;
                if (this.schedulingBusiness.DeleteOneScheduling(s))
                {
                    ShowSchedule();
                    MessageBox.Show("You deleted part of the schedule!");
                }
                else
                    MessageBox.Show("Unsuccessful delete!");
            }

            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }
        }
//**************************************************************************
        private void buttonShowC_Click(object sender, EventArgs e)
        {
            ShowClassrooms();
        }

        private void buttonInsertC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNumber.Text) && !string.IsNullOrEmpty(textBoxCapacity.Text))
            {
                foreach (Classroom u in classroomBusiness.GetAllClassrooms())
                    if (Convert.ToInt32(textBoxNumber.Text) == u.Number && Convert.ToInt32(textBoxCapacity.Text) == u.Capacity)
                    {
                        MessageBox.Show("This period already exists!");
                        return;
                    }
                InsertClassroom();
            }
            else
            {
                MessageBox.Show("You haven't filled in all the fields!");
            }
        }

        private void buttonUpdateC_Click(object sender, EventArgs e)
        {
            UpdateClassroom();
        }
//*****************************************************************************
        private void buttonShowP_Click(object sender, EventArgs e)
        {
            ShowPeriods();
        }

        private void buttonInsertP_Click(object sender, EventArgs e)
        {
            InsertPeriod();
        }

        private void buttonUpdateP_Click(object sender, EventArgs e)
        {
            UpdatePeriod();
        }
//*************************************************************************************
        private void listBoxSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            string schedule = listBoxSchedule.SelectedItem.ToString();
            textBoxDay.Text = schedule.Split('.')[0].Trim();
            textBoxPeriod.Text = schedule.Split('.')[1].Trim();
            textBoxCNumber.Text = schedule.Split('.')[2].Trim();
            textBoxOccupied.Text = schedule.Split('.')[3].Trim();
            textBoxDuty.Text = schedule.Split('.')[4].Trim();

            buttonUpdateS.Enabled = true;
        }

        private void listBoxClassrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classrooms = listBoxClassrooms.SelectedItem.ToString();
            textBoxNumber.Text = classrooms.Split('.')[0].Trim();
            textBoxCapacity.Text = classrooms.Split('.')[1].Trim();

            buttonUpdateC.Enabled = true;
        }

        private void listBoxPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            string period = listBoxPeriods.SelectedItem.ToString();
            textBoxID.Text = period.Split('.')[0].Trim();
            textBoxStart.Text = period.Split('.')[1].Trim();
            textBoxEnd.Text = period.Split('.')[2].Trim();

            buttonUpdateP.Enabled = true;
        }

        private void buttonShowSchedule_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule(schedulingBusiness, periodBusiness, classroomBusiness);
            this.Close();
            s.Show();
        }
    }
}
