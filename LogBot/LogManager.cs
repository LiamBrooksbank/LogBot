using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Stores a list of logs and facilitates construction of Log Objects
/// </summary>
namespace LogBot
{
    public class LogManager
    {
        private List<Log> logs = new List<Log>();

        public LogManager()
        {
            ReadLogs();
        }

        public void AddLog(Log log)
        {
            logs.Add(log);
        }

        public void ReadLogs()
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");

            if (!File.Exists("Data/Logs.txt"))
                File.Create("Data/Logs.txt");

            var logData = File.ReadAllLines("Data/Logs.txt");
            for(int i = 0; i < logData.Length; i++)
            {
                var data = logData[i].Split(',');
                logs.Add(new Log(DateTime.Parse(data[0]), new User(data[1]), new Project(data[2], " fix "), int.Parse(data[3]), data[4]));
                Console.WriteLine(logs[logs.Count - 1].ToString());
            }
        }

        public void WriteLogs()
        {
            string[] lines = new string[logs.Count];
            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = logs[i].ToString();
            }

            File.WriteAllLines("Data/Logs.txt", lines);
        }
    }
}
