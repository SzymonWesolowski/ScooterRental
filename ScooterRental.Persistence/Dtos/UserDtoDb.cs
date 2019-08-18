using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ScooterRental.Persistence.Dtos
{
    public class UserDtoDb
    {
        [Key]
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}