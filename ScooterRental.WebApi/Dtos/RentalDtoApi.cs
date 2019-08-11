using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScooterRental.WebApi.Dtos
{
    public class RentalDtoApi
    {
        public Guid RentalId { get; set; }
        public int ScooterId { get; set; }
        public Guid UserId { get; set; }
        public DateTime RentalStart { get; set; }
        public DateTime? RentalEnd { get; set; }
    }
}
