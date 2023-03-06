using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodException : Exception
    {
        public enum MoodExceptionType
        {
            NULL_MOOD,
            //EMPTY_MOOD,
        }
        public MoodExceptionType Type;
        public MoodException(MoodExceptionType Type,string message) : base(message) 
        {
            this.Type = Type;
        }        
    }
}
