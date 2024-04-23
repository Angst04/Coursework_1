using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using ClassLibrary1;
using System;

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

            DayOfWeek todayDate = monthCalendar.TodayDate.DayOfWeek;
            DayOfWeek dayOfWeek = todayDate;
            string typeOfDay;

            if (dayOfWeek.ToString() == "Saturday" || dayOfWeek.ToString() == "Sunday") typeOfDay = "выходной";
            else typeOfDay = "будний";

            nowDate.Text = monthCalendar.TodayDate.ToString("d");
            nowDateType.Text = typeOfDay;
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

        private void pauseButton_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            passengerTimer.Stop();
            startButton.Text = "Продолжить";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            passengerTimer.Stop();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                passCount1.Visible = false;
                pictureBox1.Visible = false;
                labelNum1.Visible = false;
            }
            else
            {
                passCount1.Visible = true;
                pictureBox1.Visible = true;
                labelNum1.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                passCount2.Visible = false;
                pictureBox2.Visible = false;
                labelNum2.Visible = false;
            }
            else
            {
                passCount2.Visible = true;
                pictureBox2.Visible = true;
                labelNum2.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                passCount3.Visible = false;
                pictureBox3.Visible = false;
                labelNum3.Visible = false;
            }
            else
            {
                passCount3.Visible = true;
                pictureBox3.Visible = true;
                labelNum3.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                passCount4.Visible = false;
                pictureBox4.Visible = false;
                labelNum4.Visible = false;
            }
            else
            {
                passCount4.Visible = true;
                pictureBox4.Visible = true;
                labelNum4.Visible = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox5.Checked)
            {
                passCount5.Visible = false;
                pictureBox5.Visible = false;
                labelNum5.Visible = false;
            }
            else
            {
                passCount5.Visible = true;
                pictureBox5.Visible = true;
                labelNum5.Visible = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox6.Checked)
            {
                passCount6.Visible = false;
                pictureBox6.Visible = false;
                labelNum6.Visible = false;
            }
            else
            {
                passCount6.Visible = true;
                pictureBox6.Visible = true;
                labelNum6.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                passengers[0] = 0;
                passCount1.Text = "0";
            }
            else if (radioButton2.Checked)
            {
                passengers[1] = 0;
                passCount2.Text = "0";
            }
            else if (radioButton3.Checked)
            {
                passengers[2] = 0;
                passCount3.Text = "0";
            }
            else if (radioButton4.Checked)
            {
                passengers[3] = 0;
                passCount4.Text = "0";
            }
            else if (radioButton5.Checked)
            {
                passengers[4] = 0;
                passCount5.Text = "0";
            }
            else if (radioButton6.Checked)
            {
                passengers[5] = 0;
                passCount6.Text = "0";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}