using System.Runtime.Serialization;

namespace VoteApp.LogEvents
{
    [DataContract]
    internal class LogEvent
    {
        public const string INFO = "INFO";
        public const string WARN = "WARN";
        public const string ERROR = "ERROR";

        public LogEvent(string _message, string _level, string _location)
        {
            message = _message;
            level = _level;
            location = _location;
        }

        [DataMember]
        internal string message;

        [DataMember]
        internal string level;

        [DataMember]
        internal string location;
    }
}
