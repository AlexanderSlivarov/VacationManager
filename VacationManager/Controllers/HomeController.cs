﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using VacationManager.Data;
using VacationManager.Models;

namespace VacationManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly VacationManagerDbContext _data;

        public HomeController(VacationManagerDbContext context)
        {
            _data = context;
        }
        public IActionResult Index()
        {
            var teamProjects = _data
                .Projects
                .Select(p => p.Name)
                .Distinct();

            var teamsCounts = new List<HomeProjectModel>();

            foreach (var projectName in teamProjects)
            {
                var teamsInProject = _data.Teams.Where(t => t.Project.Name == projectName).Count();
                teamsCounts.Add(new HomeProjectModel()
                {
                    ProjectName = projectName,
                    TeamsCount = teamsInProject
                });
            }                   

            var homeModel = new HomeViewModel()
            {
                AllTeamsCount = _data.Teams.Count(),
                ProjectsWithTeamsCount = teamsCounts,                
            };

            return View(homeModel);
        }       
    }
}