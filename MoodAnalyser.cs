using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser()
        {
            this.message = null;
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }

        public string analyseMood(string message)
        {
            if(message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }


    }
}
