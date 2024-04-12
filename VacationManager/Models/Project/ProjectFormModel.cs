using VacationManager.Models.Team;

namespace VacationManager.Models.Project
{
    public class ProjectFormModel
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public IEnumerable<ProjectTeamModel> Teams { get; set; } = null!;
    }
}
