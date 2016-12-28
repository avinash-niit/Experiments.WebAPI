using AutoMapper;
using Experiments.WCFServices.Models;
using Experiments.WCFServices.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using DC = Experiments.WCFServices.DataContracts;

namespace Experiments.WCFServices.Services
{
    public class ProjectsService : IProjectsService
    {
        ProjectsContext context = new ProjectsContext();

        public List<DC.Project> GetAllProjects()
        {
            List<DC.Project> projects = null;
            List<Project> dbProjects = context.Projects.ToList();
            projects = Mapper.Map<List<DC.Project>>(dbProjects);
            return projects;
        }

        public DC.Project GetProjectById(long id)
        {
            Project project = context.Projects.Find(id);
            return Mapper.Map<DC.Project>(project);
        }
    }
}
