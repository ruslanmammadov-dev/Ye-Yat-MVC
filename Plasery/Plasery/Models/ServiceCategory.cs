using Plasery.Models.Base;

namespace Plasery.Models
{
    public class ServiceCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public List<Service> Services { get; set; } = new();
    }
}
