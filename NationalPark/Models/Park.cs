using System.ComponentModel.DataAnnotations;

namespace NationalPark.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Coordinates{ get; set; }
        [Required]
        public string Established { get; set; }
        [Required]
        public string Area { get; set; }
        [Required]
        public string Description { get; set; }
    }
}