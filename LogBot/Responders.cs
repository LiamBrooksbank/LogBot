using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MargieBot;
using System.Text;

namespace LogBot
{
    public class Greeting : IResponder
    {
        public bool CanRespond(ResponseContext context)
        {
            return context.Message.Text.ToLower().Contains("hey")
                && context.Message.MentionsBot;
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            var builder = new StringBuilder();
            builder.Append("Hey! ").Append(context.Message.User.FormattedUserID);
            return new BotMessage() { Text = builder.ToString() };
        }
    }
}
