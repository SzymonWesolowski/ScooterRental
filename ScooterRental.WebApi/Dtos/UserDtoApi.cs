using System;

namespace ScooterRental.WebApi.Dtos
{
    public class UserDtoApi
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}