using System;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;
using C = Client.Framework.Framework;

namespace Client.Main
{
    internal static class Client
    {

        internal static void Main()
        {
            Console.Title = "Client";

            // Disables logging.
            Settings.client.Log.Output = (_, __) => { };

            // Little handler framework to keep things clean.
            Settings.client.OnOpen += (sender, e) => Handlers.OnConnect.Handle();
            Settings.client.OnMessage += (sender, m) => Handlers.OnMessage.Handle(m);
            Settings.client.OnClose += (sender, c) => Handlers.OnDisconnect.Handle(c);

            // Set up compression if enabled in settings.
            if (Settings.BidirectionalCompression)
                Settings.client.Compression = CompressionMethod.Deflate;

            // Attempt to connect.
            Settings.client.Connect();

            // Check if the connection attempt was succesful.
            if (!Settings.client.IsConnected)
            {
                C.Log("Unable to connect to server.");
                Console.ReadKey();
                return;
            }

            Task.Run(() => // Seperate thread to reconnect to the socket server if the connection is lost.
            {
                for (; ; )
                {
                    Thread.Sleep(500); // Sleeps the thread for 500ms.
                    if (!Settings.client.IsConnected)
                    {
                        C.Log("Connection lost! Attempting to reconnect..");
                        Settings.client.Connect();
                        if (Settings.client.IsConnected)
                            C.Log("Successfully reconnected!");
                    }
                }
            }).ConfigureAwait(false);

            Thread.Sleep(-1); // Keeps current thread (the console window) open.
        }
    }
}