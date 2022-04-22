namespace DiscordServerBoostAuth
{
    public class GuildMember
    {
        public class User
        {
            public string username { get; set; }
            public string avatar { get; set; }
            public string discriminator { get; set; }
            public int public_flags { get; set; }
        }

        public class Root
        {
            public string[] roles { get; set; }
            public object nick { get; set; }
            public object avatar { get; set; }
            public object premium_since { get; set; }
            public bool is_pending { get; set; }
            public bool pending { get; set; }
            public User user { get; set; }
        }
    }
}
