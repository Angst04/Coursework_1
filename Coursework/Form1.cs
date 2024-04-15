namespace Coursework
{
    public partial class Form1 : Form
    {
        private TimeSpan currentTime = TimeSpan.Zero;
        private const int timeMultiplier = 1;

        private Random random = new Random();
        private int[] passengers = new int[6];

        public Form1()
        {
            InitializeComponent();
            InitializePassengerCounts();
            timer1.Start();
        }

        private void InitializePassengerCounts()
        {
            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = random.Next(0, 5);
                UpdatePassengerLabel(i);
            }
        }

        private void UpdatePassengerLabel(int stopIndex)
        {
            Controls["passCount" + (stopIndex + 1)].Text = passengers[stopIndex].ToString();
        }

        private void UpdatePassengerCounts()
        {
            for (int i = 0; i < passengers.Length; i++)
            {
                if (IsPeakHour())
                {
                    passengers[i] += random.Next(3, 10);
                }
                else
                {
                    passengers[i] += random.Next(1, 3);
                }
                UpdatePassengerLabel(i);
            }
        }

        private bool IsPeakHour()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            return (now >= new TimeSpan(8, 0, 0) && now < new TimeSpan(10, 0, 0)) ||
                   (now >= new TimeSpan(18, 0, 0) && now < new TimeSpan(20, 0, 0));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void nowTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = TimeSpan.FromSeconds(1);
            currentTime = currentTime.Add(elapsedTime.Multiply(timeMultiplier));

            nowTime.Text = new DateTime(currentTime.Ticks).ToString("HH:mm:ss");
            UpdatePassengerCounts();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passCount1_Click(object sender, EventArgs e)
        {

        }
    }
}