namespace VoteApp.LogEvents
{
    internal class LikeLogEvent : LogEvent
    {
        public const int PIN = 1;
        public const string MOOD = "LIKE";

        public LikeLogEvent(string _location) : base (MOOD, INFO, _location) {}
    }
}
