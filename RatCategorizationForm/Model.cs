using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatCategorizationForm
{
    public class Model
    {


        /// <summary>
        /// The list of trials and their info
        /// </summary>
        private List<Trial> trials;
        public List<Trial> Trials { get { return trials; } set { trials = value;} }

        public Model()
        {
            trials = new List<Trial>();
        }


    }
}
