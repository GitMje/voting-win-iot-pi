using System;

namespace VoteApp.LogEvents
{
    internal static class LogEventFactory
    {
        public static readonly string LOCATION = "CCC 2018";

        public static LogEvent Get(int pin)
        {
            switch (pin)
            {
                case LikeLogEvent.PIN:
                    return new LikeLogEvent(LOCATION);
                case MehLogEvent.PIN:
                    return new MehLogEvent(LOCATION);
                case DislikeLogEvent.PIN:
                    return new DislikeLogEvent(LOCATION);
                default:
                    throw new NotImplementedException($"LogEvent for {pin} is unknown");
            }
        }

    }
}
