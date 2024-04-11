using System.ComponentModel.DataAnnotations;

namespace VacationManager.Models.Team
{
    public class TeamFormModel
    {
        [Required]
        public string Name { get; set; } = null!;

        public int ProjectId { get; set; }
        public IEnumerable<TeamProjectModel> Projects { get; set; } = null!;
    }
}
