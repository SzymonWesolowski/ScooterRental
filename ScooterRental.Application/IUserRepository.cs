using ScooterRental.Domain;

namespace ScooterRental.Application
{
    public interface IUserRepository
    {
        User[] GetTopTenUsers();
    }
}