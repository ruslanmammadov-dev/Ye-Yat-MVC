using Plasery.Models.Base;

namespace Plasery.Models
{
    public class Appointment : BaseEntity
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }

}
