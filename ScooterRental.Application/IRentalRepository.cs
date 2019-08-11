using System;
using System.Collections.Generic;
using ScooterRental.Domain;

namespace ScooterRental.Application
{
    public interface IRentalRepository
    {
        void AddRental(Rental rental);
        void EndRental(Guid userId, int scooterId, DateTime now);
        bool UserCanReportDefect(Guid userId, int scooterId);
        List<(Scooter, TimeSpan)> GetUsageTime();
    }
}