﻿using Discord.Commands;
using System.Collections.Generic;
using System.Linq;

namespace DiscordBot.Events
{
    public class CommandMessageEvent
    {
        public string RemoveStringFromString(string input, string charItem)
        {
            var indexOfChar = input.IndexOf(charItem);
            if(indexOfChar < 0) { return input; }
            var splitIndex = indexOfChar + charItem.Length;
            return input.Substring(0, splitIndex) + (input.Substring(splitIndex)).Replace(charItem, "");
        }

        public string GetMentionedUsername(SocketCommandContext ctx)
        {
            IEnumerable<string> mentionedUser = ctx.Message.MentionedUsers.Select(x => x.Username);
            string user;
            if(mentionedUser.Count() > 1) { user = string.Join(" & ", mentionedUser); } else { user = string.Join(" ", mentionedUser); }
            return user;
        }

        public string CleanMessage(SocketCommandContext ctx, string[] msg)
        {
            IEnumerable<string> mentionedUserId = ctx.Message.MentionedUsers.Select(x => x.Mention);

            string userId = string.Join(" ", mentionedUserId);
            string message = string.Join(" ", msg);

            if(string.IsNullOrWhiteSpace(userId))
            {
                return message;
            }
            else
            {
                userId = RemoveStringFromString(userId, "!");
                message = message.Replace(userId, string.Empty);
                return message;
            }
        }
    }
}