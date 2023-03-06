using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.MoodException;

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
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodException(MoodExceptionType.EMPTY_MOOD, "Message should not be empty");
                }

                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
                
            }
            catch (NullReferenceException)
            {
                //return "happy";
                throw new MoodException(MoodExceptionType.NULL_MOOD, "Message should not be null");

            }
        }        
    }
}
