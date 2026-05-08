using Plasery.Models.Base;

namespace Plasery.Models
{
    public class Patient : BaseEntity
    {
        public int UserId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Appointment> Appointments { get; set; }
    }

}
