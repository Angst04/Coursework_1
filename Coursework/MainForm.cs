using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using ClassLibrary1;
using System;

namespace Coursework
{
    public partial class MainForm : Form
    {
        private TimeSpan currentTime = TimeSpan.Zero;
        private const int timeMultiplier = 100;

        private Random random = new Random();
        private int[] passengers = new int[6];

        public MainForm()
        {
            InitializeComponent();
            InitializePassengerCounts();

            nowDate.Text = DataBank.nowDate;
            nowDateType.Text = DataBank.nowDateType;
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}