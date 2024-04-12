namespace VacationManager.Models.Leave
{
    public class LeaveDetailsViewModel : LeaveViewModel
    {
        public string HalfDay { get; init; } = null!;
        public string Approved { get; init; } = null!;
    }
}
