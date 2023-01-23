using AdoEg.BLL.Interface;
using AdoEg.DAL.Entities;
using AdoEg.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoEg.BLL.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepo _projectRepo;
        public ProjectService(IProjectRepo projectRepo)
        {
            _projectRepo = projectRepo;
        }

        public void AddProject(ProjectDetail projectDetail)
        {
           _projectRepo.AddProject(projectDetail);
        }

        public List<ProjectDetail> GetALlProjectDetails()
        {
            return _projectRepo.GetALlProjectDetails();
        }
    }
}
