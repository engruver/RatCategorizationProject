using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatCategorizationForm
{

    /// <summary>
    /// The current state of the program
    /// </summary>
    public enum State
    {
        STAR,
        BOX
    }


    public class Controller
    {
        private int trialCount;
        /// <summary>
        /// The number of trials conducted so far in the phase
        /// </summary>
        public int TrialCount { get { return trialCount; } set { trialCount = value; } }

        /// <summary>
        /// Information about the current trial
        /// </summary>
        private Trial currentTrial;
        public Trial CurrentTrial { get { return currentTrial; } set { currentTrial = value; } }    


        /// <summary>
        /// The rat display as the view for this controller
        /// </summary>
        RatDisplay view;

        /// <summary>
        /// The model
        /// </summary>
        Model model;

        public Controller(Model mo) 
        {
            model = mo;
        }

        /// <summary>
        /// Event handler for each state of the program
        /// </summary>
        public void StateHandler(State state)
        {
            switch (state)
            {
                case State.STAR:
                    if(currentTrial != null)model.Trials.Add(currentTrial);
                    trialCount++;
                    view.DisplayState(state, BoxPositionRandomizer());
                    currentTrial = new Trial();
                    break;
                case State.BOX:
                    view.DisplayState(state,BoxPositionRandomizer());
                    break;

            }

        }

        /// <summary>
        /// Initializes the rat display for the controller
        /// </summary>
        /// <param name="vw"></param>
        public void InitializeView(RatDisplay vw)
        {
            view = vw;
        }

        /// Triggers the dispenser event WIP
        /// </summary>
        public void Dispense()
        {

        }

        /// <summary>
        /// Randomly selects which side the White Box will display on (left or right)
        /// </summary>
        /// <returns></returns>
        public bool BoxPositionRandomizer()
        {
            return true;
        }


    }
}
