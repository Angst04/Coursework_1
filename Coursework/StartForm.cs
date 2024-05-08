using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;
            DayOfWeek dayOfWeek = selectedDate.DayOfWeek;
            string typeOfDay;

            if (dayOfWeek.ToString() == "Saturday" || dayOfWeek.ToString() == "Sunday") typeOfDay = "выходной";
            else typeOfDay = "будний";

            DataBank.nowDate = selectedDate.ToString("d");
            DataBank.nowDateType = typeOfDay;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
