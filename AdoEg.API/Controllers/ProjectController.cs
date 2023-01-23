using AdoEg.BLL.Interface;
using AdoEg.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdoEg.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet]
        public IActionResult GetAllProjects()
        {
            return Ok(_projectService.GetALlProjectDetails());  
        }
        [HttpPost]
        public IActionResult AddProjects(ProjectDetail projectDetail)
        {
            _projectService.AddProject(projectDetail);
            return Ok();
        }
    }
}
