using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using VacationManager.Data;
using VacationManager.Data.Models;
using VacationManager.Models.Project;
using VacationManager.Models.Team;

namespace VacationManager.Controllers
{
    public class ProjectController : Controller
    {
        private readonly VacationManagerDbContext _data;

        public ProjectController(VacationManagerDbContext context)
        {
            _data = context;
        }
        public async Task<IActionResult> All()
        {
            var projects = await _data
                .Projects
                .Select(p => new ProjectViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Teams = p
                    .Teams
                    .Select(t => new TeamViewModel()
                    {
                        Id = t.Id,
                        Name = t.Name,
                        Leader = t.Leader.UserName
                    })
                })
                .ToListAsync();

            return View(projects);
        }

        public async Task<IActionResult> Create()
        {
            ProjectFormModel teamModel = new ProjectFormModel()
            {
                Teams = GetTeams()
            };

            return View(teamModel);
        }

        private IEnumerable<ProjectTeamModel> GetTeams()
            => _data
            .Teams
            .Select(t => new ProjectTeamModel()
            {
                Id = t.Id,
                Name = t.Name,
            });

        [HttpPost]

        public async Task<IActionResult> Create(ProjectFormModel projectModel)
        {            
            if (ModelState.IsValid)
            {
                projectModel.Teams = GetTeams();

                return View(projectModel);
            }

            Project project = new Project()
            {
                Name = projectModel.Name,
                Description = projectModel.Description,
            };

            await _data.Projects.AddAsync(project);
            await _data.SaveChangesAsync();

            var teams = _data.Teams;

            return RedirectToAction("All", "Project");
        }               

        public async Task<IActionResult> Details(int id)
        {
            var project = await _data
                .Projects
                .Where(p => p.Id == id)
                .Select(p => new ProjectViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                })
                .FirstOrDefaultAsync();

            if (project == null)
            {
                return BadRequest();
            }

            return View(project);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var project = await _data.Projects.FindAsync(id);

            if (project == null)
            {
                return BadRequest();
            }           

            ProjectFormModel projectModel = new ProjectFormModel()
            {
                Name = project.Name,
                Description = project.Description                
            };

            return View(projectModel);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, ProjectFormModel projectModel)
        {
            var project = await _data.Projects.FindAsync(id);

            if (project == null)
            {
                return BadRequest();
            }        

            if (ModelState.IsValid)
            {
                projectModel.Teams = GetTeams();

                return View(projectModel);
            }

            project.Name = project.Name;
            project.Description = projectModel.Description;

            await _data.SaveChangesAsync();
            return RedirectToAction("All", "Project");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var project = await _data.Projects.FindAsync(id);

            if (project == null)
            {
                return BadRequest();
            }            

            ProjectViewModel projectModel = new ProjectViewModel()
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description
            };

            return View(projectModel);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(ProjectViewModel projectModel)
        {
            var project = await _data.Projects.FindAsync(projectModel.Id);

            if (project == null)
            {
                return BadRequest();
            }

            _data.Projects.Remove(project);
            await _data.SaveChangesAsync();
            return RedirectToAction("All", "Project");
        }
    }
}
