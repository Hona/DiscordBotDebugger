using System.Linq;
using DSharpPlus;
using DSharpPlus.Entities;

namespace DiscordBotDebugger.Web.Helpers
{
    public static class DiscordExtensions
    {
        public static DiscordChannel FindChannel(this DiscordClient discordClient, ulong id)
            => discordClient.Guilds
                .SelectMany(x => x.Value.Channels.Values)
                .FirstOrDefault(x => x != null && x.Id == id);
    }
}