namespace Client.Framework
{
    internal static class Structs
    {

        internal struct RemoteIdentifier
        {
            public string type;
            public string username;
        }

        internal struct DirectMessage
        {
            public string type;
            public string from;
            public string to;
            public string message;
        }

    }
}