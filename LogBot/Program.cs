using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using MargieBot;
using System.Text;

namespace LogBot
{
    public class Program
    {
        public static void Main(string[] args)
        { 

            var MyBot = new Bot();

            MyBot.Responders.Add(new Greeting());
            MyBot.Responders.Add(new LogResponder());
            MyBot.Responders.Add(new HelpResponder());

            MyBot.Aliases = new List<String>() { "LogBot", "logbot" };

            // Get Token (encapsulate elsewhere later)
            string Token = File.ReadAllText("Data/LogBotInfo.txt");
            MyBot.Connect(Token);


            while (Console.ReadLine() != "close") ;
        }
    }
}
