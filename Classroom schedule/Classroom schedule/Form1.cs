﻿using Shared.Interfaces.Business;
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
    public partial class Form1 : Form
    {
        private readonly ISchedulingBusiness schedulingBusiness;
        private readonly IPeriodBusiness periodBusiness;
        private readonly IClassroomBusiness classroomBusiness;
        public Form1(ISchedulingBusiness schedulingBusiness, IPeriodBusiness periodBusiness, IClassroomBusiness classroomBusiness)
        {
            this.schedulingBusiness = schedulingBusiness;
            this.periodBusiness = periodBusiness;
            this.classroomBusiness = classroomBusiness;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main(schedulingBusiness, periodBusiness, classroomBusiness);
            m.Show();
        }
    }
}
