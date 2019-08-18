using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ScooterRental.Persistence.Dtos
{
    public class DefectDtoDb
    {
        [Key]
        public int DefectId { get; set; }
        public string UserId { get; set; }
        public int ScooterId { get; set; }
        public string DefectDescription { get; set; }
        public bool Resolved { get; set; }
    }
}