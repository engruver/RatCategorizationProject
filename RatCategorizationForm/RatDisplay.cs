namespace RatCategorizationForm
{
    public partial class RatDisplay : Form
    {

        /// <summary>
        /// The controller of the Rat Display
        /// </summary>
        Controller controller;

        public RatDisplay(Controller con)
        {
            controller = con;
            InitializeComponent();
            buttonStar.Enabled = false;
            buttonLeft.Enabled = false;
            buttonRight.Enabled = false;
        }

        /// <summary>
        /// Switches GUI between different states of the program
        /// </summary>
        /// <param name="state"></param>
        public void DisplayState(State state, bool left)
        {
            switch (state)
            {
                case State.STAR:
                    starTimer.Start();
                    buttonStar.Enabled = true;
                    buttonLeft.Enabled = false;
                    buttonRight.Enabled = false;
                    break;
                case State.BOX:
                    starTimer.Stop();
                    boxTimer.Start();
                    buttonStar.Enabled = false;
                    if(left)
                        buttonLeft.Enabled = true;
                    else
                        buttonRight.Enabled = true;
                    break;

            }
        }

        /// <summary>
        /// Event handler for when the star button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStar_Click(object sender, EventArgs e)
        {
            controller.CurrentTrial.StarSuccess = true;
            DisplayState(State.BOX, controller.BoxPositionRandomizer());
        }

        //test button
        private void button1_Click(object sender, EventArgs e)
        {
            controller.StateHandler(State.STAR);
        }

        /// <summary>
        /// Event handler for when the Star Timer runs out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void starTimer_Tick(object sender, EventArgs e)
        {
            controller.CurrentTrial.StarSuccess = false;
            controller.StateHandler(State.BOX);
        }

        /// <summary>
        /// Event handler for when the Box Timer runs out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxTimer_Tick(object sender, EventArgs e)
        {
            controller.CurrentTrial.WhiteBoxSuccess = false;
            controller.StateHandler(State.STAR);
        }

        /// <summary>
        /// Event handler for clicking the right button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            controller.CurrentTrial.WhiteBoxSuccess = true;
            controller.StateHandler(State.STAR);

        }

        /// <summary>
        /// Event handler for clicking the left button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            controller.CurrentTrial.WhiteBoxSuccess = true;
            controller.StateHandler(State.STAR);
        }
    }
}