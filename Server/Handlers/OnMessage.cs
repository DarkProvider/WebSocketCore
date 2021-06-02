using System;
using WebSocketSharp;
using WebSocketSharp.Net.WebSockets;

namespace Server.Handlers
{
    internal static class OnMessage
    {
        internal static void Handle(MessageEventArgs m, WebSocketContext session)
        {

            if (m.IsText)
                Console.Write($"Received text: {m.Data}\n");

            if (m.IsBinary)
                Console.Write($"Received binary: {m.Data}\n");

        }

    }
}