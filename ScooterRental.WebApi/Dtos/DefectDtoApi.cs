using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScooterRental.WebApi.Dtos
{
    public class DefectDtoApi
    {
        public Guid UserId { get; set; }
        public int ScooterId { get; set; }
        public string DefectDescription { get; set; }
        public bool Resolved { get; set; }
    }
}
