using System;
using System.Threading.Tasks;
using AntDesign;
using DSharpPlus;
using DSharpPlus.Entities;

namespace DiscordBotDebugger.Web.Services
{
    public interface IDiscordBotService
    {
        public string Token { get; set; }
        public DiscordIntents PresenceIntents { get; set; }
        public DiscordClient Client { get; set; }
        public event EventHandler ClientSet;
        public DiscordChannel SelectedChannel { get; set; }
        public event EventHandler ChannelSet;
        
        public event EventHandler<DiscordMessage> MessageSent;
        public void RegisterSentMessage(DiscordMessage message);
    }
}