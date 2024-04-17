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
            mainTimer.Start();
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
                if ((now.Hours >= 7 && now.Hours < 10) || (now.Hours >= 18 && now.Hours < 21))
                {
                    passengers[i] += random.Next(4, 10);
                }
                else if (now.Hours < 7 || now.Hours >= 21)
                {
                    passengers[i] += random.Next(0, 5);
                }
                else
                {
                    passengers[i] += random.Next(0, 5);
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
    }
}