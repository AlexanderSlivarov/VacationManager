﻿namespace VacationManager.Data.Models
{
    public class Leave
    {
        public int Id { get; set; }

        public string Type { get; set; } = null!;
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreationDate { get; set; }
        public string HalfDay { get; set; } = null!;
        public string Approved { get; set; } = null!;
        public string ApplicantId { get; set; } = null!;
        public ApplicationUser Applicant { get; set; }
    }
}
