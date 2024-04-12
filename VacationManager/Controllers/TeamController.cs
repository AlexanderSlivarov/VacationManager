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
    [Authorize]
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

        public async Task<IActionResult> Details(int id)
        {
            var team = await _data
                .Teams
                .Where(t => t.Id == id)
                .Select(t => new TeamDetailsViewModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    Project = t.Project.Name,
                    Leader = t.Leader.UserName
                })
                .FirstOrDefaultAsync();

            if (team == null)
            {
                return BadRequest();
            }

            return View(team);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var team = await _data.Teams.FindAsync(id);

            if (team == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();
            if (currentUserId != team.LeaderID)
            {
                return Unauthorized();
            }

            TeamFormModel teamModel = new TeamFormModel()
            {
                Name = team.Name,                
                ProjectId = team.ProjectId,
                Projects = GetProjects()
            };

            return View(teamModel);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, TeamFormModel teamModel)
        {
            var team = await _data.Teams.FindAsync(id);

            if (team == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();
           
            if (currentUserId != team.LeaderID)
            {
                return Unauthorized();
            }

            if (!GetProjects().Any(b => b.Id == teamModel.ProjectId))
            {
                ModelState.AddModelError(nameof(teamModel.ProjectId), "Board does not exist.");
            }

            if (ModelState.IsValid)
            {
                teamModel.Projects = GetProjects();

                return View(teamModel);
            }

            team.Name = teamModel.Name;            
            team.ProjectId = teamModel.ProjectId;

            await _data.SaveChangesAsync();
            return RedirectToAction("All", "Project");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var team = await _data.Teams.FindAsync(id);

            if (team == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != team.LeaderID)
            {
                return Unauthorized();
            }

            TeamViewModel teamModel = new TeamViewModel()
            {
                Id = team.Id,
                Name = team.Name
            };

            return View(teamModel);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(TeamViewModel teamModel)
        {
            var team = await _data.Teams.FindAsync(teamModel.Id);

            if (team == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (currentUserId != team.LeaderID)
            {
                return Unauthorized();
            }

            _data.Teams.Remove(team);
            await _data.SaveChangesAsync();
            return RedirectToAction("All", "Project");
        }
    }
}

