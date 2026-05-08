using Plasery.Models.Base;

namespace Plasery.Models
{
    public class DoctorService : BaseEntity
    {
        public int DoctorId { get; set; }
        public int ServiceId { get; set; }
        public Doctor Doctor { get; set; }
        public Service Service { get; set; }
    }
}
