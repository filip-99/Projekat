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
        private void UpdateSchedule()
        {
            if (!string.IsNullOrEmpty(textBoxDay.Text) && !string.IsNullOrEmpty(textBoxPeriod.Text) && !string.IsNullOrEmpty(textBoxCNumber.Text) && !string.IsNullOrEmpty(textBoxOccupied.Text))
            {
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

                foreach (Scheduling r in schedulingBusiness.GetAllSchedulings())
                    if (Convert.ToInt32(textBoxDay.Text) == r.Day && Convert.ToInt32(textBoxPeriod.Text) == r.Period_id && Convert.ToInt32(textBoxCNumber.Text) == r.Classroom_number && Convert.ToBoolean(textBoxOccupied.Text) == r.Occupied)
                    {
                        MessageBox.Show("You haven't changed anything!");
                        return;
                    }
                Scheduling re = new Scheduling();
                re.Day = Convert.ToInt32(textBoxDay.Text);
                re.Period_id = Convert.ToInt32(textBoxPeriod.Text);
                re.Classroom_number = Convert.ToInt32(textBoxCNumber.Text);
                re.Occupied = Convert.ToBoolean(textBoxOccupied.Text);
                re.Duty_person = textBoxDuty.Text;
                if (schedulingBusiness.UpdateOneScheduling(re))
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
                foreach (Classroom u in classroomBusiness.GetAllClassrooms())
                    if (Convert.ToInt32(textBoxNumber.Text) == u.Number && Convert.ToInt32(textBoxCapacity.Text) == u.Capacity)
                    {
                        MessageBox.Show("You haven't changed anything!");
                        return;
                    }
                Classroom uc = new Classroom();
                uc.Number = Convert.ToInt32(textBoxNumber.Text);
                uc.Capacity = Convert.ToInt32(textBoxCapacity.Text);
                if (classroomBusiness.UpdateOneClassroom(uc))
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
                foreach (Period te in periodBusiness.GetAllPeriods())
                    if (Convert.ToInt32(textBoxID.Text) == te.Id && TimeSpan.Parse(textBoxStart.Text) == te.Start_time && TimeSpan.Parse(textBoxEnd.Text) == te.End_time)
                    {
                        MessageBox.Show("You haven't changed anything!");
                        return;
                    }
                Period t = new Period();
                t.Id = Convert.ToInt32(textBoxID.Text);
                t.Start_time = TimeSpan.Parse(textBoxStart.Text);
                t.End_time= TimeSpan.Parse(textBoxEnd.Text);

                if (periodBusiness.UpdateOnePeriod(t))
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
        //************************************************************************************
       
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
                    Scheduling r = new Scheduling();
                    r.Day = Convert.ToInt32(textBoxDay.Text);
                    r.Period_id = Convert.ToInt32(textBoxPeriod.Text);
                    r.Classroom_number = Convert.ToInt32(textBoxCNumber.Text);
                    r.Occupied = Convert.ToBoolean(textBoxOccupied.Text);
                    r.Duty_person = textBoxDuty.Text;
                    if (this.schedulingBusiness.DeleteOneScheduling(r))
                    {
                        ShowSchedule();
                        MessageBox.Show("You have deleted one part of the schedule!");
                    }
                    else
                        MessageBox.Show("Unsuccessful delete!");
                }

                else
                {
                    MessageBox.Show("You haven't filled in all the fields!");
                }
            
        }
        //**********************************************************************************
        private void buttonShowC_Click(object sender, EventArgs e)
        {
            ShowClassrooms();
        }

        private void buttonUpdateC_Click(object sender, EventArgs e)
        {
            UpdateClassroom();
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
        //***************************************************************************************
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
        //********************************************************************************************
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
    }
}
