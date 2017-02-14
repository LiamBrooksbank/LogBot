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

            // Get Token (encapsulate elsewhere later)
            string Token = File.ReadAllText("LogBotInfo.txt");

            MyBot.Responders.Add(new Greeting());

            MyBot.Connect(Token);
            MyBot.Aliases = new List<String>() { "LogBot", "logbot" };

            while (Console.ReadLine() != "close") ;
        }
    }

    /// <summary>
    /// Describes a single session of work on a single project
    /// </summary>
    public class Log
    {
        private Project project;
        private int time; // in hours
        private string description;
    }

    /// <summary>
    /// A specific project
    /// </summary>
    public class Project
    {
        private string name;
        private string description;
    }
}
