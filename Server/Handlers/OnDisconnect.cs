using System;
using WebSocketSharp;
using WebSocketSharp.Net.WebSockets;

namespace Server.Handlers
{
    internal static class OnDisconnect
    {
        internal static void Handle(CloseEventArgs c, WebSocketContext session)
        {
            Console.Write($"A session has disconnected, code: {c.Code}, reason: {c.Reason}\n");
        }

    }
}