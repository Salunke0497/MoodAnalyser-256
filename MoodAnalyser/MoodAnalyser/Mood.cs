using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {
        string message;
        public Mood(string message)
        {
            this.message = message;
        }
        //for check Analyse Mood happy or sad
        //UC1 / UC2
        public string AnalyseMood()
        {
            if (message.Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }        
    }
}
