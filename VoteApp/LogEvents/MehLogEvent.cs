namespace VoteApp.LogEvents
{
    internal class MehLogEvent : LogEvent
    {
        public const int PIN = 5;
        public const string MOOD = "MEH";

        public MehLogEvent(string _location) : base(MOOD, INFO, _location) { }
    }
}
