namespace VacationManager.Models.Leave
{
    public class LeaveViewModel
    {
        public int Id { get; init; }
        public string Type { get; init; } = null!;
        public DateTime DateFrom { get; init; }
        public DateTime DateTo { get; init; }
        public DateTime CreationDate { get; set; }
        public string Applicant { get; init; } = null!;
    }
}
