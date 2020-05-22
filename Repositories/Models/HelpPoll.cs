using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class HelpPoll
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [MaxLength(200)]
        public string WhosHelping { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(200)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(200)]
        public string ChatNumber { get; set; }
        [Required]
        [MaxLength(200)]
        public string HelpNeededImportance { get; set; }
        [Required]
        [MaxLength(200)]
        public string ResidenceType { get; set; }
        [Required]
        [MaxLength(200)]
        public string HowManyEldersInHouseHold { get; set; }
        [Required]
        [MaxLength(200)]
        public string HowManyAdultsInHouseHold { get; set; }
   
        [MaxLength(200)]
        public string AgeRange { get; set; }
        [Required]
        [MaxLength(200)]
        public string HouseHoldHasPublicOfficer { get; set; }
        [Required]
        [MaxLength(200)]
        public string HouseHoldHasIncome { get; set; }
        [Required]
        [MaxLength(200)]
        public string Profession { get; set; }

        public HelpPoll()
        {
            CreatedDate = DateTime.Now;
        }

    }
}
