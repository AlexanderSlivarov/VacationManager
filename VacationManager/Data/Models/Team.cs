namespace VacationManager.Data.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Project? Project { get; set; }
        public int ProjectId { get; set; }      
        public string LeaderID { get; set; } = null!;
        public ApplicationUser Leader { get; set; } = null!;
    }
}
