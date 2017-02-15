using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBot
{

    /// <summary>
    /// A specific project
    /// </summary>
    public class Project
    {
        private string name;
        private string description;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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

        public Project(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
