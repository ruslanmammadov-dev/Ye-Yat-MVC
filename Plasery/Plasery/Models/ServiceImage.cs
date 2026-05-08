using Plasery.Models.Base;

namespace Plasery.Models
{
    public class ServiceImage : BaseEntity
    {
        public string ImageUrl { get; set; }
        public int IsMain { get; set; }
    }
}
