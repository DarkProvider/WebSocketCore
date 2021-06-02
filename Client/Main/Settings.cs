using WebSocketSharp;

namespace Client.Main
{
    internal static class Settings
    {

        // To set up SSL please check the official websocketsharp documentation on sta's GitHub page.

        // Host setup.
        internal static readonly string IP = "127.0.0.1";
        internal static readonly int port = 8880;
        internal static readonly string servicename = "/chat"; // Example: /chat (so it would be yourdomain.com/chat)
        internal static readonly string hostname = $"ws://{IP}:{port}{servicename}";
        internal static WebSocket client = new WebSocket(hostname);

        // Other settings.
        internal static bool BidirectionalCompression = false; // Leaving this disabled is faster but feel free to do experiment with it yourself.

        // Development mode (for logging, etc..)
        internal static bool DevelopmentMode = true;

    }
}