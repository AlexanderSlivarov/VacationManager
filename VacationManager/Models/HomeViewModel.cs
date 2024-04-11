namespace VacationManager.Models
{
    public class HomeViewModel
    {
        public int AllTeamsCount { get; init; }
        public List<HomeProjectModel> ProjectsWithTeamsCount { get; set; } = null!;

        public int UserTeamsCount { get; init; }
    }
}
