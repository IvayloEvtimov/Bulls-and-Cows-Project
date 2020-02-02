using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_Cows
{
    class Result
    {
        private int cows;
        private int bulls;

        public Result(int cows,int bulls)
        {
            this.cows = cows;
            this.bulls = bulls;
        }

        public string Cows { get => Convert.ToString(cows); }
        public string Bulls { get => Convert.ToString(bulls); }
    }
}
