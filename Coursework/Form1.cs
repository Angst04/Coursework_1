using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework
{
    public partial class Form1 : Form
    {
        private TimeSpan currentTime = TimeSpan.Zero;
        private const int timeMultiplier = 100;

        private Random random = new Random();
        private int[] passengers = new int[6];

        public Form1()
        {
            InitializeComponent();
            InitializePassengerCounts();
        }

        private void InitializePassengerCounts()
        {
            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = 0;
                UpdatePassengerLabel(i);
            }
        }

        private void UpdatePassengerLabel(int stopIndex)
        {
            Controls["passCount" + (stopIndex + 1)].Text = passengers[stopIndex].ToString();
        }

        private void UpdatePassengerCounts(TimeSpan now)
        {
            for (int i = 0; i < passengers.Length; i++)
            {
                if (nowDateType.Text == "будний")
                {
                    if ((now.Hours >= 7 && now.Hours < 10) || (now.Hours >= 18 && now.Hours < 21))
                    {
                        passengers[i] += random.Next(4, 12);
                    }
                    else if (now.Hours < 7 || now.Hours >= 21)
                    {
                        passengers[i] += random.Next(0, 7);
                    }
                    else
                    {
                        passengers[i] += random.Next(0, 7);
                    }
                }
                else
                {
                    if (now.Hours < 7 || now.Hours >= 21)
                    {
                        passengers[i] += random.Next(0, 2);
                    }
                    else
                    {
                        passengers[i] += random.Next(0, 6);
                    }
                }

                UpdatePassengerLabel(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = TimeSpan.FromSeconds(1);
            currentTime = currentTime.Add(elapsedTime.Multiply(timeMultiplier));

            nowTime.Text = new DateTime(currentTime.Ticks).ToString("HH:mm");

            passengerTimer.Tag = currentTime;
        }

        private void passengerTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = (TimeSpan)passengerTimer.Tag;
            UpdatePassengerCounts(currentTime);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            mainTimer.Start();
            passengerTimer.Start();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;
            DayOfWeek dayOfWeek = selectedDate.DayOfWeek;
            string typeOfDay;

            if (dayOfWeek.ToString() == "Saturday" || dayOfWeek.ToString() == "Sunday") typeOfDay = "выходной";
            else typeOfDay = "будний";

            nowDate.Text = selectedDate.ToString("d");
            nowDateType.Text = typeOfDay;
        }
    }
}