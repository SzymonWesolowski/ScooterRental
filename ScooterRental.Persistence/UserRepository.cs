using System;
using System.Linq;
using ScooterRental.Application;
using ScooterRental.Domain;
using ScooterRental.Persistence.Dtos;

namespace ScooterRental.Persistence
{
    public class UserRepository : IUserRepository
    {
        public User[] GetTopTenUsers()
        {
            using (var context = new RentalContext())
            {
                var rentals = context.Rentals.GroupBy(r => r.UserId).Select(s => new
                {
                    ClientId = s.Key,
                    RentalCount = s.Count()
                }).OrderByDescending(r => r.RentalCount).Take(10);

                var users = new User[10];
                var counter = 0;
                foreach (var rental in rentals)
                {
                    users[counter++] = DtoToModel(context.Users.First(u => u.UserId == rental.ClientId));
                }

                return users;
            }
        }

        private User DtoToModel(UserDtoDb userDto)
        {
            return new User(Guid.Parse(userDto.UserId), userDto.FirstName, userDto.LastName);
        }
    }
}