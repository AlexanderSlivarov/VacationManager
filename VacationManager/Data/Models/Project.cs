namespace VacationManager.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}
