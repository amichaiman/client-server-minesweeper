using System;
using System.Runtime.Serialization;

namespace MineSweeperClient
{
    [Serializable]
    internal class InvalidBoardParameters : Exception
    {
        public InvalidBoardParameters()
        {
        }

        public InvalidBoardParameters(string message) : base(message)
        {
        }

        public InvalidBoardParameters(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidBoardParameters(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}