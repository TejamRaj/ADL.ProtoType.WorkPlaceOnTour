using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkPlaceOnTour.BACKEND.Entities
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int WorkplaceId { get; set; }


        public Workplace Workplace { get; set; }

        [ForeignKey("WorkplaceId")]
        [Required]
        public ICollection<Workplace> WorkPlaces { get; set; } = new List<Workplace>();
    }
}