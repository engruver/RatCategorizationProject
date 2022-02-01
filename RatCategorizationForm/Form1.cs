namespace RatCategorizationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 15 seconds.  
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 15000;
            
            button1.Text = "Start";
            button1.Click += new EventHandler(button1_Click);
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            timer1.Stop();
            buttonStar.Enabled = false;
            buttonLeft.Enabled = true;
            buttonRight.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop")
            {
                button1.Text = "Start";
                timer1.Stop();
            }
            else
            {
                buttonLeft.Enabled = false;
                buttonRight.Enabled = false;
                button1.Text = "Stop";
                timer1.Start();
                
            }
        }
    }
}