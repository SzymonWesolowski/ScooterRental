using System;
using System.Collections.Generic;
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

        public List<(Scooter, TimeSpan)> GetUsageTime(int scooterId)
        {
            return _rentalRepository.GetUsageTime();
        }

        public User[] GetTopTenUsers()
        {
            return _userRepository.GetTopTenUsers();
        }
    }
}