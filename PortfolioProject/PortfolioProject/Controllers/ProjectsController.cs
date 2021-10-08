using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioProject.Models;

namespace PortfolioProject.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            PortfolioProject.Services.JSONReader jsonReader = new Services.JSONReader();
            List<ProjectModel> projects = jsonReader.GetProjects();
            return View("Projects",projects);
        }
    }
}
