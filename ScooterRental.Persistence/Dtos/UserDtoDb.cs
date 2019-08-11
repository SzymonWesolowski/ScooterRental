using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ScooterRental.Persistence.Dtos
{
    public class UserDtoDb
    {
        
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}