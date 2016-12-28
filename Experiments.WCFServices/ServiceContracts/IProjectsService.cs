using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Experiments.WCFServices
{
    [ServiceContract]
    public interface IProjectsService
    {
        [OperationContract]
        List<Project> GetAllProjects();

        [OperationContract]
        Project GetProjectById(long id);
    }
}
