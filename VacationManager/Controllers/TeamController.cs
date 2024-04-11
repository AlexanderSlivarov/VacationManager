using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VacationManager.Data;
using VacationManager.Models.Team;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using VacationManager.Data.Models;

namespace VacationManager.Controllers
{
    public class TeamController : Controller
    {
        private readonly VacationManagerDbContext _data;

        public TeamController(VacationManagerDbContext context)
        {
            _data = context;
        }
       
        public async Task<IActionResult> Create()
        {
            TeamFormModel teamModel = new TeamFormModel()
            {
                Projects = GetProjects()
            };

            return View(teamModel);
        }

        private IEnumerable<TeamProjectModel> GetProjects()
            => _data
            .Projects
            .Select(p => new TeamProjectModel()
            {
                Id = p.Id,
                Name = p.Name,
            });

        [HttpPost]

        public async Task<IActionResult> Create(TeamFormModel teamModel)
        {
            if (!GetProjects().Any(p => p.Id == teamModel.ProjectId))
            {
                ModelState.AddModelError(nameof(teamModel.ProjectId), "Project does not exist.");
            }

            string currentUserId = GetUserId();

            if (ModelState.IsValid)
            {
                teamModel.Projects = GetProjects();

                return View(teamModel);
            }

            Team team = new Team()
            {
                Name = teamModel.Name,
                ProjectId = teamModel.ProjectId,
                LeaderID = currentUserId,
            };

            await _data.Teams.AddAsync(team);
            await _data.SaveChangesAsync();

            var projects = _data.Projects;

            return RedirectToAction("All", "Project");
        }

        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}

