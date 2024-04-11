using VacationManager.Models.Team;

namespace VacationManager.Models.Project
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; init; } = null!;
        public string Description { get; init; } = null!;
        public IEnumerable<TeamViewModel> Teams { get; set; } = new List<TeamViewModel>();
    }
}
