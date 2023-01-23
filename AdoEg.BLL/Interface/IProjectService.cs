using AdoEg.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoEg.BLL.Interface
{
    public interface IProjectService
    {
        List<ProjectDetail> GetALlProjectDetails();
        void AddProject(ProjectDetail projectDetail);
    }
}
