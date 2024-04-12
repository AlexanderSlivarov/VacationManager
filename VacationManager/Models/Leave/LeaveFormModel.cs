namespace VacationManager.Models.Leave
{
    public class LeaveFormModel
    {
        public string Type { get; set; } = null!;
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreationDate { get; set; }

        public string HalfDay { get; set; } = null!;
        public string Approved { get; set; } = null!;
        public string Applicant { get; set; } = null!;
    }
}
