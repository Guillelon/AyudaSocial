using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class VolunteerPoll
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Age { get; set; }
        [Required]
        [MaxLength(200)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(200)]
        public string ChatNumber { get; set; }
        [Required]
        [MaxLength(200)]
        public string HaveCar { get; set; }
        [Required]
        [MaxLength(200)]
        public string CanSupportWithMinutes { get; set; }
        [Required]
        [MaxLength(200)]
        public string AreaAddress { get; set; }
        [Required]
        [MaxLength(200)]
        public string TimeToHelp { get; set; }
        [Required]
        [MaxLength(200)]
        public string Profession { get; set; }
        [Required]
        [MaxLength(200)]
        public string Hobbies { get; set; }
        [Required]
        [MaxLength(200)]
        public string WayToHelp { get; set; }
        [Required]
        [MaxLength(200)]
        public string InstagramAccount { get; set; }
        [Required]
        [MaxLength(200)]
        public string AbleToShareInSN { get; set; }
        [Required]
        [MaxLength(200)]
        public string AbleToCollectMoney { get; set; }
        [Required]
        [MaxLength(200)]
        public string Comments { get; set; }

        public VolunteerPoll()
        {
            CreatedDate = DateTime.Now;
        }

    }
}
