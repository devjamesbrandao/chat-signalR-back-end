using System;

namespace SignalRChat
{
    public class UserConnection
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string User { get; set; }
        public string Room { get; set; }
    }
}
