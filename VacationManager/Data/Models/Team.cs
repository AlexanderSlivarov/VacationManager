namespace VacationManager.Data.Models
{
    public class Team
    {
        public int Id { get; set; }
        public Project? Project { get; set; }
        public int ProjectId { get; set; }      
        public string LeaderID { get; set; } = null!;
        public ApplicationUser Leader { get; set; } = null!;

    }
}
