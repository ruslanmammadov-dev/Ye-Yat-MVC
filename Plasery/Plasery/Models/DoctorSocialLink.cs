using Plasery.Models.Base;

namespace Plasery.Models
{
    public class DoctorsSocialLink : BaseEntity
    {
        public string Url { get; set; }
        public string Platform { get; set; }
        public string Nickname { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
