using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ScooterRental.Persistence.Dtos
{
    public class ScooterDtoDb
    {
        [Key]
        public int ScooterId { get; set; }
        public bool Rented { get; set; }
        public bool Defected { get; set; }
    }
}
