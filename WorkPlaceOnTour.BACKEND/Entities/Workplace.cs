using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkPlaceOnTour.BACKEND.Entities
{
    public class Workplace: AuditableEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkplaceId { get; set; }


        public Guid TourId { get; set; }
       
        [ForeignKey("TourId")]
        public TourDestination TourDestination { get; set; }

        public string Address { get; set; }

        public int rate { get; set; }

    
        public string WorkplacePhotoUrl { get; set; }
    }
}