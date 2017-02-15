using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBot
{
    public class User
    {
        private string name;

        public User(string name)
        {
            this.Name = name;
        }

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
    }
}
