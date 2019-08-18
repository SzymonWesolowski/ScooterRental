using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ScooterRental.Persistence.Dtos
{
    public class RentalDtoDb
    {
        [Key]
        public string RentalId { get; set; }
        public int ScooterId { get; set; }
        public string UserId { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime? RentalEnd { get; set; }
    }
}
