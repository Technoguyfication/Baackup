using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaackupShared
{
    [Serializable]
    public class ConfigNonexistentException : Exception
    {
        public ConfigNonexistentException() { }
        public ConfigNonexistentException(string message) : base(message) { }
        public ConfigNonexistentException(string message, Exception inner) : base(message, inner) { }
        protected ConfigNonexistentException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }


    [Serializable]
    public class ConfigInvalidException : Exception
    {
        public ConfigInvalidException() { }
        public ConfigInvalidException(string message) : base(message) { }
        public ConfigInvalidException(string message, Exception inner) : base(message, inner) { }
        protected ConfigInvalidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }

    [Serializable]
    public class ConfigResetException : Exception
    {
        public ConfigResetException() { }
        public ConfigResetException(string message) : base(message) { }
        public ConfigResetException(string message, Exception inner) : base(message, inner) { }
        protected ConfigResetException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
