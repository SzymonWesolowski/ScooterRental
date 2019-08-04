using System;
using JetBrains.Annotations;

namespace ScooterRental.Domain
{
    public class Rental
    {
        public Rental(int scooterId, Guid userId, DateTime rentalStart, DateTime? rentalEnd, Guid rentalId)
        {
            ScooterId = scooterId;
            UserId = userId;
            RentalStart = rentalStart;
            RentalEnd = rentalEnd;
            RentalId = rentalId;
        }

        public Guid RentalId { get; }
        public int ScooterId { get; }
        public Guid UserId { get; }
        public DateTime RentalStart { get; }
        public DateTime? RentalEnd { get; }
    }
}