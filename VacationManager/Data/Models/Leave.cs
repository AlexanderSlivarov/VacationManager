namespace VacationManager.Data.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreationDate { get; set; }
        public bool HalfDay { get; set; }
        public bool Approved { get; set; }
        public string ApplicantId { get; set; } = null!;
        public ApplicationUser Applicant { get; set; }
    }
}
