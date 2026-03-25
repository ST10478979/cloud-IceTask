using System.ComponentModel.DataAnnotations;

namespace MechanicShopp.Models
{
    public class Car
    {

        [Key]
        [Required]
        public int Id { get; set; }

        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string LicensePlate { get; set; }

        public int? VIN { get; set; }
    }
}
