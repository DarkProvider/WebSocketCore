using Client.Framework;
using Client.Main;
using Newtonsoft.Json;

namespace Client.Handlers
{
    internal static class OnConnect
    {

        internal static void Handle() // This method runs when you connect to the server.
        {

            // Remote identification example.
            Structs.RemoteIdentifier RemoteID = new Structs.RemoteIdentifier
            {
                type = "connect",
                username = "Meap",
            };
            Settings.client.Send(JsonConvert.SerializeObject(RemoteID));

            // Direct message (DM) example.
            Structs.DirectMessage DirectMessage = new Structs.DirectMessage
            {
                type = "message",
                from = "Meap",
                to = "Lija",
                message = "This is a direct message!",
            };
            Settings.client.Send(JsonConvert.SerializeObject(DirectMessage));

        }

    }
}