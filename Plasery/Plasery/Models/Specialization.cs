using Plasery.Models.Base;

namespace Plasery.Models
{
    public class Specialization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Doctor> Doctors { get; set; } = new();
    }
}
