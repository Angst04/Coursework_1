using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;

using ClassLibrary1;
using System;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Coursework
{
    public partial class MainForm : Form
    {
        private TimeSpan currentTime = TimeSpan.Zero;
        private const int timeMultiplier = 30;

        private Random random = new Random();
        private int[] passengers = new int[6];

        private List<Bus> buses = new List<Bus>();

        private int busRemains = 3;
        private int minibusRemains = 3;

        public MainForm()
        {
            InitializeComponent();
            InitializePassengerCounts();

            InitializeBuses();
            CreateBusForms();

            nowDate.Text = DataBank.NowDate;
            nowDateType.Text = DataBank.NowDateType;


            busRemainsLabel.Text = busRemains.ToString();
            minibusRemainsLabel.Text = minibusRemains.ToString();
        }

        private void InitializeBuses()
        {
            buses.Add(new Bus("Автобус", TimeSpan.FromHours(1)));
            buses.Add(new Bus("Маршрутка", TimeSpan.FromHours(2)));
            buses.Add(new Bus("Автобус", TimeSpan.FromHours(3)));
        }

        private void BusForm(int ct, dynamic bus)
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
            transportChangeButton.Text = "Убрать";
            transportChangeButton.UseVisualStyleBackColor = true;
            transportChangeButton.Click += transportChangeButtons_Click;

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
        }

        private void CreateBusForms()
        {
            flowLayoutPanel1.Controls.Clear();

            int ct = 0;
            foreach (var bus in buses)
            {
                BusForm(ct, bus);
                ct++;
            }
        }

        private void UpdateBusProgress(TimeSpan currentTime)
        {
            UpdatePassengerCounts(currentTime);

            for (int i = buses.Count - 1; i >= 0; i--)
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

                if (transportProgressBar != null && progressValue <= 100 && progressValue >= 0)
                {
                    transportProgressBar.Value = progressValue;
                }

                int total = 50;
                if (bus.Type == "Маршрутка") total = 25;
                if (currentTime >= bus.DepartureTime)
                {
                    if (!bus.IsAtLastStop())
                    {
                        bus.MoveToNextStop(currentTime);

                        int passengersToBoard = Math.Min(passengers[bus.CurrentStop - 1], total - bus.PassengersAmount);

                        passengers[bus.CurrentStop - 1] -= passengersToBoard;
                        bus.PassengersAmount += passengersToBoard;
                        UpdatePassengerLabel(i);
                    }
                    else
                    {
                        bus.DepartureTime = currentTime.Add(TimeSpan.FromMinutes(60));
                        bus.CurrentStop = 1;
                        bus.PassengersAmount = 0;
                        transportDeparture.Text = DateTime.Today.Add(bus.DepartureTime).ToString("HH:mm");
                    }
                    transportCurrentStop.Text = bus.CurrentStop.ToString();
                    transportAmount.Text = bus.PassengersAmount.ToString() + "/" + total.ToString();
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
            if (stopIndex >= 0 && stopIndex < passengers.Length)
            {
                Controls["passCount" + (stopIndex + 1)].Text = passengers[stopIndex].ToString();
            }
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
                            passengers[i] += random.Next(0, 2);
                        }
                        else
                        {
                            passengers[i] += random.Next(0, 5);
                        }
                    }
                    else
                    {
                        if (now.Hours < 9 || now.Hours >= 21)
                        {
                            passengers[i] += random.Next(0, 3);
                        }
                        else
                        {
                            passengers[i] += random.Next(0, 5);
                        }
                    }

                    passengers[i] = Math.Min(passengers[i], 20);
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = TimeSpan.FromSeconds(1);
            currentTime = currentTime.Add(elapsedTime.Multiply(timeMultiplier));

            nowTime.Text = new DateTime(currentTime.Ticks).ToString("HH:mm");

            UpdateBusProgress(currentTime);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Пауза")
            {
                mainTimer.Stop();
                startButton.Text = "Продолжить";
            }
            else
            {
                mainTimer.Start();
                startButton.Text = "Пауза";
            }
        }

        public void AddNewBus(string type, int timeBetweenStops)
        {
            int currentStop = 1;
            if (radioButton2.Checked) currentStop = 2;
            else if (radioButton3.Checked) currentStop = 3;
            else if (radioButton4.Checked) currentStop = 4;
            else if (radioButton5.Checked) currentStop = 5;
            else if (radioButton6.Checked) currentStop = 6;

            buses.Add(new Bus(type, TimeSpan.FromHours(currentTime.TotalHours).Add(TimeSpan.FromMinutes(timeBetweenStops)), timeBetweenStops, currentStop));

            int ct = buses.Count() - 1;
            var bus = buses[ct];
            BusForm(ct, bus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type;
            int timeBetweenStops;
            if (busRemains > 0 && radioButton12.Checked)
            {
                type = "Автобус";
                timeBetweenStops = 45;
                busRemains--;
                busRemainsLabel.Text = busRemains.ToString();
                if (busRemains == 0) busRemainsLabel.ForeColor = Color.Red;
                AddNewBus(type, timeBetweenStops);
            }
            else if (minibusRemains > 0 && radioButton11.Checked)
            {
                type = "Маршрутка";
                timeBetweenStops = 30;
                minibusRemains--;
                minibusRemainsLabel.Text = minibusRemains.ToString();
                if (minibusRemains == 0) minibusRemainsLabel.ForeColor = Color.Red;
                AddNewBus(type, timeBetweenStops);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "Выбранный транспорт не доступен. Обратите внимание на доступный транспорт",
                "Предупреждение");
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();

            DialogResult result = MessageBox.Show(
            "Вы уверены, что хотите завершить смену? Это действие вернёт вас в стартовое меню",
            "Предупреждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                Application.Restart();
            else if (startButton.Text == "Пауза")
            {
                mainTimer.Start();
            }

            this.TopMost = true;
        }

        private void transportChangeButtons_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            string buttonName = clickedButton.Name;
            int index = int.Parse(buttonName.Split('_').Last());

            if (index >= 0 && index < buses.Count)
            {
                if (buses[index].Type == "Автобус")
                {
                    busRemains++;
                    busRemainsLabel.Text = busRemains.ToString();
                    if (busRemains > 0) busRemainsLabel.ForeColor = Control.DefaultForeColor;
                }
                else
                {
                    minibusRemains++;
                    minibusRemainsLabel.Text = minibusRemains.ToString();
                    if (minibusRemains > 0) busRemainsLabel.ForeColor = Control.DefaultForeColor;
                }

                buses.RemoveAt(index);

                CreateBusForms();
            }
        }
    }
}