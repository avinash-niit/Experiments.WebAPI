using Experiments.ServiceConsumer.ProjectService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments.ServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectsServiceClient client = new ProjectsServiceClient();
            List<Project> projects = client.GetAllProjects();
        }
    }
}
