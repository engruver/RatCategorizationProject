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


    internal class Controller
    {

        public Controller() { }

        /// <summary>
        /// Event handler for each state of the program
        /// </summary>
        public void StateHandler(State state)
        {
            switch (state)
            {
                case State.STAR:
                    trialCount++;
                    break;
                case State.BOX:
                    break;

            }

        }


        private int trialCount;
        /// <summary>
        /// The number of trials conducted so far in the phase
        /// </summary>
        public int TrialCount { get { return trialCount; } set { trialCount = value; } }

        /// <summary>
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
