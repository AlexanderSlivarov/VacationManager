using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VacationManager.Data;
using VacationManager.Models.Project;

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
                    .Select(t => new Models.Team.TeamViewModel()
                    {
                        Id = t.Id,
                        Name = t.Name,
                        Leader = t.Leader.UserName
                    })
                })
                .ToListAsync();

            return View(projects);
        }
    }
}
