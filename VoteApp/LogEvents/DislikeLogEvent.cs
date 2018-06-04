namespace VoteApp.LogEvents
{
    internal class DislikeLogEvent : LogEvent
    {
        public const int PIN = 3;
        public const string MOOD = "DISLIKE";

        public DislikeLogEvent(string _location) : base(MOOD, INFO, _location) { }
    }
}
