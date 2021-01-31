using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;

namespace DiscordBotDebugger.Web.Services
{
    public class DiscordBotService : IDiscordBotService
    {
        private DiscordClient _client;
        private DiscordChannel _selectedChannel;
        public string Token { get; set; }
        public DiscordIntents PresenceIntents { get; set; }

        public DiscordClient Client
        {
            get => _client;
            set
            {
                _client = value;
                ClientSet?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ClientSet;

        public DiscordChannel SelectedChannel
        {
            get => _selectedChannel;
            set
            {
                _selectedChannel = value;
                ChannelSet?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ChannelSet;
        public event EventHandler<DiscordMessage> MessageSent;

        public void RegisterSentMessage(DiscordMessage message) => MessageSent?.Invoke(this, message);
    }
}