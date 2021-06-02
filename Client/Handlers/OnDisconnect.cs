using System;
using WebSocketSharp;

namespace Client.Handlers
{
    internal static class OnDisconnect
    {
        internal static void Handle(CloseEventArgs c) // This method runs when you disconnect from the server.
        {
            Console.Write($"Disconnected, code: {c.Code}, reason: {c.Reason}\n");
        }

    }
}