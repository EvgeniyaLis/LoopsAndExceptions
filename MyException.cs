using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
    [Serializable]
    public class InvalidUserException : SystemException
    {
        public InvalidUserException() : base() { }
        public InvalidUserException(string message) : base(message) { }
        public InvalidUserException(string message, Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected InvalidUserException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
