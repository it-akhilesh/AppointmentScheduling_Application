namespace AppointmentScheduling.Models.ViewModels
{
    public class AppointmentVM
    {
        public int? Id { get; set; } = null;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public int Duration { get; set; } = 0;
        public string DoctorId { get; set; } = string.Empty;
        public string PatientId { get; set; } = string.Empty;
        public bool IsDoctorApproved { get; set; } = false;
        public string AdminId { get; set; } = string.Empty;
        public string DoctorName { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;
        public string AdminName { get; set; }=string.Empty;
        public bool IsForClient { get; set; }= false;
    }
}
