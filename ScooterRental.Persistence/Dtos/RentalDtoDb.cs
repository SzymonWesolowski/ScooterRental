using System;
using System.Collections.Generic;
using System.Text;

namespace ScooterRental.Persistence.Dtos
{
    public class RentalDtoDb
    {
        public string RentalId { get; set; }
        public int ScooterId { get; set; }
        public string UserId { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime? RentalEnd { get; set; }
    }
}
