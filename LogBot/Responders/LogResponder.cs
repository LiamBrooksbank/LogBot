using MargieBot;
using System.Text;
using System;

namespace LogBot
{
    public class LogResponder : IResponder
    {
        LogManager logManager = new LogManager();

        public bool CanRespond(ResponseContext context)
        {
            var message = context.Message.Text;
            if (message.Split(' ').Length > 1)
                return message.Split(' ')[1].Equals("log")
                    && context.Message.MentionsBot;
            else
                return false;
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            var log = context.Message.Text;

            string[] projectAndHours;
            if (log.Contains("&lt;"))
                projectAndHours = log.Substring(0, log.IndexOf("&lt;") - 1).Split(' ');
            else
                projectAndHours = log.Split(' ');

            string description = " ";
            if(log.Contains("&lt;") && log.Contains("&gt;"))
                description = log.Substring(log.IndexOf("&lt;") + "&lt;".Length, log.IndexOf("&gt;") - log.IndexOf("&lt;") - "&gt;".Length);

            if (projectAndHours.Length != 4)
                return new BotMessage() { Text = "Format incorrect" };

            Log toAdd = new Log(new User(context.Message.User.FormattedUserID)
                , new Project(projectAndHours[2], " ")
                , int.Parse(projectAndHours[3])
                , description);

            logManager.AddLog(toAdd);
            logManager.WriteLogs();

            var builder = new StringBuilder();
            builder.Append("Added Log: ").Append(toAdd.ToString());
            return new BotMessage() { Text = builder.ToString() };
        }
    }
}
