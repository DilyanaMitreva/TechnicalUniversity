using System;

namespace CourseWorkEntities.Exceptions
{
    public class TextBoxException : Exception
    {
        public TextBoxException(string message) : base(message)
        {
        }

        public TextBoxException(string message, Exception inner)
            : base(message, inner)
        {
        }
        
    }
}