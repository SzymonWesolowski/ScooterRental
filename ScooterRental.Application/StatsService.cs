using System;
using ScooterRental.Domain;

namespace ScooterRental.Application
{
    public class StatsService
    {
        private readonly IScooterRepository _scooterRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRentalRepository _rentalRepository;

        public StatsService(IScooterRepository scooterRepository, IUserRepository userRepository, IRentalRepository rentalRepository)
        {
            _scooterRepository = scooterRepository;
            _userRepository = userRepository;
            _rentalRepository = rentalRepository;
        }

        public int GetNumberOfAvailableScooters()
        {
            return _scooterRepository.GetNumberOfAvailableScooters();
        }

        public TimeSpan GetUsageTime(int scooterId)
        {
            return _rentalRepository.GetUsageTime(scooterId);
        }

        public User[] GetTopTenUsers()
        {
            return _userRepository.GetTopTenUsers();
        }
    }
}