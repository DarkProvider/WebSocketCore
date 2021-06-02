using System;
using WebSocketSharp;

namespace Client.Handlers
{
    internal static class OnMessage
    {
        internal static void Handle(MessageEventArgs e) // This method runs when you receive data from the server.
        {

            if (e.IsText)
                Console.Write($"Received text: {e.Data}\n");

            if (e.IsBinary)
                Console.Write($"Received binary: {e.Data}\n");

        }

    }
}