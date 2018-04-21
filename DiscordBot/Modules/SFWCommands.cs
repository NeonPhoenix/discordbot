﻿using Discord;
using Discord.Commands;
using DiscordBot.Init;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Modules
{
    public class SFWCommands : ModuleBase<SocketCommandContext>
    {
        private static EmbedBuilder embed;
        Random ran = new Random();

        private static EmbedBuilder Embed(SocketCommandContext context, IUser usr, string action, string img, string msg)
        {
            if(usr == null)
            {
                embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} " + action + " everyone!" + msg);
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { embed.WithImageUrl(img); }
            }
            else
            {
                embed = new EmbedBuilder().WithTitle($"{context.Message.Author.Username} " + action + $" {usr.Username} " + msg);
                if (Uri.IsWellFormedUriString(img, UriKind.Absolute)) { embed.WithImageUrl(img); }
            }

            return embed;
        }

        [Command("kiss")]
        public async Task KissAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Kiss[ran.Next(0, ImageInitialization.Kiss.Count)];
            var em = Embed(Context, usr, "kisses", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("tickle")]
        public async Task TickleAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Tickle[ran.Next(0, ImageInitialization.Tickle.Count)];
            var em = Embed(Context, usr, "tickles", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pinch")]
        public async Task PinchAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Pinch[ran.Next(0, ImageInitialization.Pinch.Count)];
            var em = Embed(Context, usr, "pinches", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("wave")]
        public async Task WaveAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Wave[ran.Next(0, ImageInitialization.Wave.Count)];
            var em = Embed(Context, usr, "waves at", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("rude")]
        public async Task RudeAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Rude[ran.Next(0, ImageInitialization.Rude.Count)];
            var em = Embed(Context, usr, "flips off", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cake")]
        public async Task CakeAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Cake[ran.Next(0, ImageInitialization.Cake.Count)];
            var em = Embed(Context, usr, "gives cake to", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("cuddle")]
        public async Task CuddleAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Cuddle[ran.Next(0, ImageInitialization.Cuddle.Count)];
            var em = Embed(Context, usr, "cuddles", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("glare")]
        public async Task GlaresAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Glare[ran.Next(0, ImageInitialization.Glare.Count)];
            var em = Embed(Context, usr, "glares at", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("highfive")]
        public async Task HighfiveAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Highfive[ran.Next(0, ImageInitialization.Highfive.Count)];
            var em = Embed(Context, usr, "highfives", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("hug")]
        public async Task HugAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Hug[ran.Next(0, ImageInitialization.Hug.Count)];
            var em = Embed(Context, usr, "hugs", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("poke")]
        public async Task PokeAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Poke[ran.Next(0, ImageInitialization.Poke.Count)];
            var em = Embed(Context, usr, "kisses", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("punch")]
        public async Task PunchAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Punch[ran.Next(0, ImageInitialization.Punch.Count)];
            var em = Embed(Context, usr, "punches", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("pat")]
        public async Task PatAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Pat[ran.Next(0, ImageInitialization.Pat.Count)];
            var em = Embed(Context, usr, "pats", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("slap")]
        public async Task SlapAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Slap[ran.Next(0, ImageInitialization.Slap.Count)];
            var em = Embed(Context, usr, "slaps", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }

        [Command("bite")]
        public async Task BiteAsync(IUser usr = null, string msg = null)
        {
            string img = ImageInitialization.Bite[ran.Next(0, ImageInitialization.Bite.Count)];
            var em = Embed(Context, usr, "bites", img, msg);
            await Context.Channel.SendMessageAsync("", false, em, null).ConfigureAwait(false);
        }
    }
}
