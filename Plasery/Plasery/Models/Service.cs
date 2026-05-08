using Plasery.Models.Base;

namespace Plasery.Models
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string MainImageUrl { get; set; }
        public string IconUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int ServiceCategoryId { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public List<ServiceImage> ServiceImages { get; set; } = new();
        public List<Appointment> Appointments { get; set; } = new();
        public List<DoctorService> DoctorServices { get; set; } = new();
    }
}
