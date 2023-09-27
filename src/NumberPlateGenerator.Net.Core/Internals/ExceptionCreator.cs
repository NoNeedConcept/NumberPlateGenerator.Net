using System;

namespace NumberPlateGenerator.Net.Core
{
    public static class ExceptionCreator
    { 
        public static Exception CreateArgumentOutOfRange(string message) => new ArgumentOutOfRangeException(message);

        public static Exception CreateArgumentNull(string message) => new ArgumentNullException(message);
    }
}
