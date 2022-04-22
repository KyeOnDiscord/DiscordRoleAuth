using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace DiscordServerBoostAuth
{
    internal class DiscordRichPresence
    {
		public static DiscordRpcClient client;
		//Called when your application first starts.
		//For example, just before your main loop, on OnEnable for unity.

		public static void Initialize()
		{
			/*
			Create a Discord client
			NOTE: 	If you are using Unity3D, you must use the full constructor and define
					 the pipe connection.
			*/
			client = new DiscordRpcClient(Program.DiscordRPCApplicationID);

			//Set the logger
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			//Subscribe to events
			client.OnReady += Program.Received;

			//client.OnPresenceUpdate += (sender, e) =>
			//{
			//	Console.WriteLine("Received Update! {0}", e.Presence);
			//};

			//Connect to the RPC
			client.Initialize();


			
			//Set the rich presence
			//Call this as many times as you want and anywhere in your code.
			//client.SetPresence(new RichPresence()
			//{
			//	Details = "Example Project",
			//	State = "csharp example",
			//	Assets = new Assets()
			//	{
			//		LargeImageKey = "image_large",
			//		LargeImageText = "Lachee's Discord IPC Library",
			//		SmallImageKey = "image_small"
			//	}
			//});
		}
	}
}
