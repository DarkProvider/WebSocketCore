using System;
using WebSocketSharp.Net.WebSockets;

namespace Server.Handlers
{
    internal static class OnConnect
    {

        internal static void Handle(WebSocketContext session)
        {
            Console.Write("A session has connected!\n");

            // Send a plain text message to the client after they connect.
            session.WebSocket.Send("Hello! Thank you for connecting :)");
        }

    }
}