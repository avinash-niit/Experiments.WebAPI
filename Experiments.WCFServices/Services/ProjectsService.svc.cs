using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Experiments.WCFServices
{
    public class ProjectsService : IProjectsService
    {
        ProjectsContext context = new ProjectsContext();

        public List<Project> GetAllProjects()
        {
            List<Project> projects = null;
            try
            {
                projects = context.Projects.ToList();
            }
            catch (Exception ex)
            {
            }
            return projects;    
        }

        public Project GetProjectById(long id)
        {
            return context.Projects.Find(id);
        }
    }
}
