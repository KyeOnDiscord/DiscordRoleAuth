using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
namespace DiscordServerBoostAuth
{
    public class ServerBoostAuth
    {
        private string ServerID { get; set; }
        private string BoostingRoleID { get; set; }
        private WebClient web;

        public ServerBoostAuth(string serverid, string roleid, string bottoken)
        {
            ServerID = serverid;
            BoostingRoleID = roleid;
            web = new WebClient() { Proxy = null };
            web.Headers.Add($"Authorization:Bot {bottoken}");
        }

        public bool IsServerBoosting(ulong userid)
        {
            string data = web.DownloadString($"https://discord.com/api/v9/guilds/{ServerID}/members/{userid}");
            string[] roles = JsonConvert.DeserializeObject<GuildMember.Root>(data).roles;
            if (roles.Contains(BoostingRoleID))//https://stackoverflow.com/a/13257521/12897035
                return true;
            else
                return false;
        }
    }
}
