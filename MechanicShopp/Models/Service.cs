using System.ComponentModel.DataAnnotations;

namespace MechanicShopp.Models
{
    public class Service
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public int LabourHours { get; set; }

        [Required]
        public string MechanicName { get; set; }


    }
}
