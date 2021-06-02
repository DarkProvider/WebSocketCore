using System.Net;
using WebSocketSharp.Server;

namespace Server.Main
{
    internal static class Settings
    {

        // To set up SSL please check the official websocketsharp documentation on sta's GitHub page.

        // Host setup.
        internal static readonly int port = 8880;
        internal static readonly string servicename = "/chat"; // Example: /chat (so it would be yourdomain.com/chat)
        internal static readonly string hostname = $"ws://{IPAddress.Any}:{port}{servicename}";
        internal static WebSocketServer server = new WebSocketServer(port);

    }
}