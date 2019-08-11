using System;
using JetBrains.Annotations;
using ScooterRental.Domain;

namespace ScooterRental.Application
{
    public interface IRentalService
    {
        Guid RentScooter(Guid userId, int scooterId);
        void EndRental(Guid userId, int scooterId);
    }

    public class RentalService : IRentalService
    {
        private readonly IScooterRepository _scooterRepository;
        private readonly IRentalRepository _rentalRepository;

        public RentalService(IScooterRepository scooterRepository, IRentalRepository rentalRepository)
        {
            _scooterRepository = scooterRepository;
            _rentalRepository = rentalRepository;
        }

        public Guid RentScooter(Guid userId, int scooterId)
        {
            _scooterRepository.RentScooter(scooterId);
            var rental = new Rental(scooterId, userId, DateTime.Now, null, Guid.NewGuid());
            _rentalRepository.AddRental(rental);
            return rental.RentalId;
        }

        public void EndRental(Guid userId, int scooterId)
        {
            _rentalRepository.EndRental(userId, scooterId, DateTime.Now);
            _scooterRepository.EndRental(scooterId);
        }
    }
}
