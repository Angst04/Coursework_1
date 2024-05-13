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

            CreateBusForms();

            nowDate.Text = DataBank.NowDate;
            nowDateType.Text = DataBank.NowDateType;
        }

        private void InitializeBuses()
        {
            buses.Add(new Bus("Автобус", TimeSpan.FromHours(1), 60));
            buses.Add(new Bus("Маршрутка", TimeSpan.FromHours(2), 35));
            buses.Add(new Bus("Автобус", TimeSpan.FromHours(3), 40));
        }

        private void CreateBusForms()
        {
            int ct = 0;
            foreach (var bus in buses)
            {
                int total = 50;
                if (bus.Type == "Маршрутка") total = 25;

                Panel transportPanel = new Panel();
                System.Windows.Forms.ProgressBar transportProgressBar = new System.Windows.Forms.ProgressBar();
                Label transportCurrentStop = new Label();
                System.Windows.Forms.Button transportChangeButton = new System.Windows.Forms.Button();
                Label transportAmount = new Label();
                Label transportDeparture = new Label();
                Label transportType = new Label();

                transportPanel.Name = $"transportPanel_{ct}";
                transportPanel.BackColor = Color.FromArgb(255, 224, 192);
                transportPanel.Location = new Point(3, 3);
                transportPanel.Size = new Size(839, 44);
                transportPanel.TabIndex = 3;

                transportProgressBar.Location = new Point(401, 10);
                transportProgressBar.Name = $"transportProgressBar_{ct}";
                transportProgressBar.Size = new Size(262, 23);
                transportProgressBar.TabIndex = 5;

                transportCurrentStop.AutoSize = true;
                transportCurrentStop.Location = new Point(287, 14);
                transportCurrentStop.Name = $"transportCurrentStop_{ct}";
                transportCurrentStop.Size = new Size(13, 15);
                transportCurrentStop.TabIndex = 4;
                transportCurrentStop.Text = bus.CurrentStop.ToString();

                transportChangeButton.Location = new Point(743, 10);
                transportChangeButton.Name = $"transportChangeButton_{ct}";
                transportChangeButton.Size = new Size(75, 23);
                transportChangeButton.TabIndex = 3;
                transportChangeButton.Text = "Изменить";
                transportChangeButton.UseVisualStyleBackColor = true;

                transportAmount.AutoSize = true;
                transportAmount.Location = new Point(188, 14);
                transportAmount.Name = $"transportAmount_{ct}";
                transportAmount.Size = new Size(30, 15);
                transportAmount.TabIndex = 2;
                transportAmount.Text = bus.PassengersAmount.ToString() + "/" + total.ToString();

                transportDeparture.AutoSize = true;
                transportDeparture.Location = new Point(97, 14);
                transportDeparture.Name = $"transportDeparture_{ct}";
                transportDeparture.Size = new Size(34, 15);
                transportDeparture.TabIndex = 1;
                transportDeparture.Text = DateTime.Today.Add(bus.DepartureTime).ToString("HH:mm");


                transportType.AutoSize = true;
                transportType.Location = new Point(11, 14);
                transportType.Name = $"transportType_{ct}";
                transportType.Size = new Size(52, 15);
                transportType.TabIndex = 0;
                transportType.Text = bus.Type;

                transportPanel.Controls.Add(transportProgressBar);
                transportPanel.Controls.Add(transportCurrentStop);
                transportPanel.Controls.Add(transportChangeButton);
                transportPanel.Controls.Add(transportAmount);
                transportPanel.Controls.Add(transportDeparture);
                transportPanel.Controls.Add(transportType);

                flowLayoutPanel1.Controls.Add(transportPanel);
                ct++;
            }
        }

        private void UpdateBusProgress(TimeSpan currentTime)
        {
            UpdatePassengerCounts(currentTime);

            for (int i = 0; i < buses.Count; i++)
            {
                var bus = buses[i];

                string progressBarName = $"transportProgressBar_{i}";
                string currentStopName = $"transportCurrentStop_{i}";
                string changeButtonName = $"transportChangeButton_{i}";
                string amountLabelName = $"transportAmount_{i}";
                string departureLabelName = $"transportDeparture_{i}";
                string typeName = $"transportType_{i}";

                TimeSpan timeToNextStop = bus.DepartureTime - currentTime;

                System.Windows.Forms.ProgressBar transportProgressBar = flowLayoutPanel1.Controls.Find(progressBarName, true).FirstOrDefault() as System.Windows.Forms.ProgressBar;
                Label transportCurrentStop = flowLayoutPanel1.Controls.Find(currentStopName, true).FirstOrDefault() as Label;
                System.Windows.Forms.Button transportChangeButton = flowLayoutPanel1.Controls.Find(changeButtonName, true).FirstOrDefault() as System.Windows.Forms.Button;
                Label transportAmount = flowLayoutPanel1.Controls.Find(amountLabelName, true).FirstOrDefault() as Label;
                Label transportDeparture = flowLayoutPanel1.Controls.Find(departureLabelName, true).FirstOrDefault() as Label;
                Label transportType = flowLayoutPanel1.Controls.Find(typeName, true).FirstOrDefault() as Label;

                int progressValue = (int)((timeToNextStop.TotalMinutes / bus.TimeBetweenStops) * 100);
                testLabel.Text = progressValue.ToString();

                if (progressValue <= 100)
                {
                    
                    transportProgressBar.Value = progressValue;
                }

                // transportType.Text = bus.Type.ToString();

                if (currentTime >= bus.DepartureTime)
                {
                    if (!bus.IsAtLastStop())
                    {
                        bus.MoveToNextStop(currentTime);

                        int total = 50;
                        if (bus.Type == "Маршрутка") total = 25;

                        int passengersToBoard = Math.Min(passengers[bus.CurrentStop - 1], total - bus.PassengersAmount);

                        passengers[bus.CurrentStop - 1] -= passengersToBoard;
                        bus.PassengersAmount += passengersToBoard;
                        transportAmount.Text = bus.PassengersAmount.ToString() + "/" + total.ToString();
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

                if (now.Minutes % 20 == 0)
                {
                    if (nowDateType.Text == "будний")
                    {
                        if ((now.Hours >= 7 && now.Hours < 10) || (now.Hours >= 18 && now.Hours < 21))
                        {
                            passengers[i] += random.Next(3, 7);
                        }
                        else if (now.Hours < 7 || now.Hours >= 21)
                        {
                            passengers[i] += random.Next(1, 5);
                        }
                        else
                        {
                            passengers[i] += random.Next(0, 2);
                        }
                    }
                    else
                    {
                        if (now.Hours < 7 || now.Hours >= 21)
                        {
                            passengers[i] += random.Next(0, 4);
                        }
                        else
                        {
                            passengers[i] += random.Next(0, 2);
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

        // убрать этот таймер
        private void passengerTimer_Tick(object sender, EventArgs e)
        {
            //TimeSpan currentTime = (TimeSpan)passengerTimer.Tag;
            //UpdatePassengerCounts(currentTime);
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