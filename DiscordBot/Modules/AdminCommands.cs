﻿using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using DiscordBot.Init;

namespace DiscordBot.Modules
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    {
        [Group("clean")]
        public class CleanCommand : ModuleBase
        {
            [Command]
            public async Task CleanAsync()
            {
                
            }

            [Command]
            public async Task CleanAsync(int count)
            {
                var msg = await Context.Channel.GetMessagesAsync(count + 1).Flatten();
                await Context.Channel.DeleteMessagesAsync(msg);
            }

            [Command]
            public async Task CleanAsync(IGuildUser user, int count = 100)
            {

            }
        }

        [Command("ban")]
        public async Task BanAsync(IGuildUser user)
        {

        }

        [Command("reloadimages")]
        public async Task ReloadImageAsync()
        {
            ImageInitialization.Clear();
            ImageInitialization.Init();
            await Context.Channel.SendMessageAsync("Reload Complete!");
        }
    }


}
