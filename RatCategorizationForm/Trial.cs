using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatCategorizationForm
{
    internal class Trial
    {
        private bool starSuccess;
        /// <summary>
        /// Variable indicating whether or not the Star tap was a success
        /// </summary>
        public bool StarSuccess { get { return starSuccess; } set { starSuccess = value; } }

        private bool whiteBoxSuccess;
        /// <summary>
        /// Variable indicating whether or not the White Box tap was a success
        /// </summary>
        public bool WhiteBoxSuccess { get { return starSuccess; } set { starSuccess = value; } }

    }
}
