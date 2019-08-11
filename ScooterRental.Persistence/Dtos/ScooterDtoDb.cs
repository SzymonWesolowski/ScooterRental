using System;
using System.Collections.Generic;
using System.Text;

namespace ScooterRental.Persistence.Dtos
{
    public class ScooterDtoDb
    {
        public int ScooterId { get; set; }
        public bool Rented { get; set; }
        public bool Defected { get; set; }
    }
}
