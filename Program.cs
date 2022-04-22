using System;
using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Message;

namespace DiscordServerBoostAuth
{
    class Program
    {

        const string ServerID = "0";//The server id of the server with the role
        const string RoleIDforBoost = "0";//The role which is required, does not have to be a server booster role.
        const string BotToken = "";//Requires a discord bot in the server to check roles. Make a backend api to hide this. Do NOT put a Discord Token inside an application which will be distributed.

        //Discord RPC stuff
        public const string DiscordRPCApplicationID = "966865682081914920";//Leave this in here, its an empty RPC, if you want your application to have Discord RPC then change this to your own
        
        static void Main()
        {
            DiscordRichPresence.Initialize();
            while (true)
            {
                //Make the program wait and not close
            }
        }

        public static void Received(object sender, ReadyMessage readyMsg)
        {
            Console.WriteLine("Checking if you are server boosting...");

            ServerBoostAuth auth = new ServerBoostAuth(ServerID, RoleIDforBoost, BotToken);

            bool serverboosting = auth.IsServerBoosting(readyMsg.User.ID);

            if (serverboosting)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Welcome {readyMsg.User.Username}#{readyMsg.User.Discriminator}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please boost the server to access this program");
            }
        }
    }
}
