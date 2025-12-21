using System;

namespace STUDENTMGMTSYSTEMAPP
{
    public class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message) { }
    }
}
