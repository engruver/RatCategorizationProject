namespace RatCategorizationForm
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches GUI between different states of the program
        /// </summary>
        /// <param name="state"></param>
        public void DisplayState(State state)
        {
            switch (state)
            {
                case State.STAR:
                    break;
                case State.BOX:
                    break;

            }
        }


        private void buttonStar_Click(object sender, EventArgs e)
        {
            starTimer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            starTimer.Start();
        }

        private void starTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}