# DiscordRoleAuth
Whitelist users to using an application by their Discord role on a specified server.

The user must have the Discord desktop app open for this to work.

Variables:

`ServerID` - The Server ID the role is in

`RoleIDforBoost` - The whitelisted role ID, this may be a server boosting role or any other role.

`BotToken` - A bot on the server must check if the user has a role. You __**should**__ make a backend api for this because you do not want to expose your Discord token in an application you are distributing. https://discord.com/developers/docs/resources/guild#get-guild-member

`DiscordRPCApplicationID` - This application uses [DiscordRPC](https://www.nuget.org/packages/DiscordRichPresence/) to fetch the current user's ID. You may change this ID if you want to implement rich presence in your app or leave it just to get the current user's ID.
