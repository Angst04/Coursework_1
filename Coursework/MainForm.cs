using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;

using ClassLibrary1;
using System;
using System.Reflection;

namespace Coursework
{
    public partial class MainForm : Form
    {
        private TimeSpan currentTime = TimeSpan.Zero;
        private const int timeMultiplier = 100;

        private Random random = new Random();
        private int[] passengers = new int[6];

        private List<Bus> buses = new List<Bus>();

        public MainForm()
        {
            InitializeComponent();
            InitializePassengerCounts();

            InitializeBuses();

            nowDate.Text = DataBank.NowDate;
            nowDateType.Text = DataBank.NowDateType;
        }

        private void InitializeBuses()
        {
            buses.Add(new Bus("Автобус", TimeSpan.FromHours(1), 60)); // Пример времени отправления: 1:00

        }

        private void UpdateBusProgress(TimeSpan currentTime)
        {
            UpdatePassengerCounts(currentTime); // Обновляем количество пассажиров на остановках

            for (int i = 0; i < buses.Count; i++)
            {
                var bus = buses[i];

                if (currentTime >= bus.DepartureTime)
                {
                    if (!bus.IsAtLastStop())
                    {
                        bus.MoveToNextStop(currentTime);

                        int passengersToBoard = Math.Min(passengers[bus.CurrentStop - 1], 50 - bus.PassengersAmount);

                        passengers[bus.CurrentStop - 1] -= passengersToBoard;
                        bus.PassengersAmount += passengersToBoard;
                        transportAmount.Text = bus.PassengersAmount.ToString() + "/50";
                        UpdatePassengerLabel(i);

                        transportCurrentStop.Text = bus.CurrentStop.ToString();
                    }
                    else
                    {
                        buses.RemoveAt(i);
                    }
                }
            }
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
                UpdatePassengerLabel(i);

                if (now.Minutes % 15 == 0)
                {
                    if (nowDateType.Text == "будний")
                    {
                        if ((now.Hours >= 7 && now.Hours < 10) || (now.Hours >= 18 && now.Hours < 21))
                        {
                            passengers[i] += random.Next(1, 4);
                        }
                        else if (now.Hours < 7 || now.Hours >= 21)
                        {
                            passengers[i] += random.Next(1, 5);
                        }
                        else
                        {
                            passengers[i] += random.Next(0, 5);
                        }
                    }
                    else
                    {
                        if (now.Hours < 7 || now.Hours >= 21)
                        {
                            passengers[i] += random.Next(0, 5);
                        }
                        else
                        {
                            passengers[i] += random.Next(0, 5);
                        }
                    }

                    passengers[i] = Math.Min(passengers[i], 15);
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = TimeSpan.FromSeconds(1);
            currentTime = currentTime.Add(elapsedTime.Multiply(timeMultiplier));

            nowTime.Text = new DateTime(currentTime.Ticks).ToString("HH:mm");

            passengerTimer.Tag = currentTime;

            UpdateBusProgress(currentTime);
        }

        private void passengerTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = (TimeSpan)passengerTimer.Tag;
            UpdatePassengerCounts(currentTime);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Пауза")
            {
                mainTimer.Stop();
                passengerTimer.Stop();
                startButton.Text = "Продолжить";
            }
            else
            {
                mainTimer.Start();
                passengerTimer.Start();
                startButton.Text = "Пауза";
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}