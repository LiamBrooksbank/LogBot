using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MargieBot;
using System.Text;

namespace LogBot
{
    public class HelpResponder : IResponder
    {
        public bool CanRespond(ResponseContext context)
        {
            return context.Message.Text.ToLower().Contains("help")
                && context.Message.MentionsBot;
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            var builder = new StringBuilder();
            builder.AppendLine("log format: logbot log Project Hours <Description>");
            builder.AppendLine("\t Eg => logbot log Design 8 <Came up with a design>");
            return new BotMessage() { Text = builder.ToString()};
        }
    }
}
