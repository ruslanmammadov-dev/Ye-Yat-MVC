using Plasery.Models.Base;

namespace Plasery.Models
{
    public class Doctor : BaseEntity
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ExperiencesYears { get; set; }
        public bool IsActive { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public List<DoctorsSocialLink> SocialLinks { get; set; } = new();
        public List<Appointment> Appointments { get; set; } = new();
        public List<DoctorService> DoctorServices { get; set; } = new();
    }
}
