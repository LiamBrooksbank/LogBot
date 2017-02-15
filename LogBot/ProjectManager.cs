using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBot
{
    public class ProjectManager
    {
        private List<Project> projects = new List<Project>();

        public bool ContainsProject(Project project)
        {
            return projects.Contains(project);
        }

        public bool AddProject(Project project)
        {
            if (!ContainsProject(project))
            {
                projects.Add(project);
                return true;
            }
            else
                return false;
        }
    }
}
