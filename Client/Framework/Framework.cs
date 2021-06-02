using Client.Main;
using System;

namespace Client.Framework
{
    internal static class Framework
    {

        internal static void Log(string message)
        {
            if (Settings.DevelopmentMode)
                Console.Write(message + "\n");
        }

    }
}