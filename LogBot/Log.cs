using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace LogBot
{
    /// <summary>
    /// Describes a single session of work on a single project
    /// </summary>
    public class Log
    {
        // Variables
        private DateTime date; // Date of log entry
        private User user; // User who worked on project
        private Project project; // Project worked on
        private int hours; // Time spent on project
        private string description; // Description of work done on project

        public Log(User user, Project project, int hours = 8, string description = "")
        {
            this.date = DateTime.Now;
            this.user = user;
            this.project = project;
            this.hours = hours;
            this.description = description;
        }

        public Log(DateTime date, User user, Project project, int hours = 8, string description = "")
        {
            this.date = date;
            this.user = user;
            this.project = project;
            this.hours = hours;
            this.description = description;
        }

        public override string ToString()
        {
            var toReturn = date.ToString() + ',' + user.Name + ',' + project.Name + ',' + hours.ToString() + ',' + description;
            return toReturn;
        }

        // Accessors and Mutators
        public Project Project
        {
            get
            {
                return project;
            }

            set
            {
                project = value;
            }
        }

        public int Time
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
