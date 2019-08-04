using System;

namespace ScooterRental.Domain
{
    public class Rental
    {
        public Rental(int scooterId, Guid userId, DateTime rentalStart, DateTime rentalEnd)
        {
            ScooterId = scooterId;
            UserId = userId;
            RentalStart = rentalStart;
            RentalEnd = rentalEnd;
        }

        public int ScooterId { get; }
        public Guid UserId { get; }
        public DateTime RentalStart { get; }
        public DateTime? RentalEnd { get; }
    }
}