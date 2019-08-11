using System;
using System.Collections.Generic;
using System.Linq;
using ScooterRental.Application;
using ScooterRental.Domain;
using ScooterRental.Persistence.Dtos;

namespace ScooterRental.Persistence
{
    public class RentalRepository : IRentalRepository
    {
        public void AddRental(Rental rental)
        {
            var rentalDto = ModeltoDto(rental);
            using (var context = new RentalContext())
            {
                context.Rentals.Add(rentalDto);
                context.SaveChanges();
            }
        }

        public void EndRental(Guid userId, int scooterId, DateTime now)
        {
            using (var context = new RentalContext())
            {
                var rental = context.Rentals.First(r =>
                    r.UserId == userId.ToString() && r.ScooterId == scooterId && r.RentalEnd == null);
                rental.RentalEnd = now;
                context.SaveChanges();
            }
        }

        public bool UserCanReportDefect(Guid userId, int scooterId)
        {
            using (var context = new RentalContext())
            {
                var rental = context.Rentals.FirstOrDefault(r =>
                    r.ScooterId == scooterId && r.UserId == userId.ToString() &&
                    (r.RentalEnd == null || (DateTime.Now - r.RentalEnd) < new TimeSpan(0, 15, 0)));
                if (rental == null)
                    return false;
                return true;
            }
        }

        public List<(Scooter, TimeSpan)> GetUsageTime()
        {
            var usageTimeList = new List<(Scooter, TimeSpan)>();
            using (var context = new RentalContext())
            {
                var group = context.Rentals.GroupBy(g => g.ScooterId);
                foreach (var scooter in group)
                {
                    TimeSpan totalUsageTime = new TimeSpan(0);

                    foreach (var rental in scooter)
                    {
                        if (rental.RentalEnd != null)
                            totalUsageTime += (DateTime) rental.RentalEnd - rental.RentalStart;
                    }

                    usageTimeList.Add((ScooterDtoToModel(context.Scooters.First(s => s.ScooterId == scooter.Key)),
                        totalUsageTime));
                }

                return usageTimeList;
            }
        }

        private RentalDtoDb ModeltoDto(Rental rental)
        {
            var rentalDto = new RentalDtoDb
            {
                UserId = rental.UserId.ToString(),
                ScooterId = rental.ScooterId,
                RentalId = rental.RentalId.ToString(),
                RentalStart = rental.RentalStart,
                RentalEnd = rental.RentalEnd
            };
            return rentalDto;
        }

        private Rental DtoToModel(RentalDtoDb rentalDto)
        {
            return new Rental(rentalDto.ScooterId, Guid.Parse(rentalDto.UserId), rentalDto.RentalStart,
                rentalDto.RentalEnd, Guid.Parse(rentalDto.RentalId));
        }

        private Scooter ScooterDtoToModel(ScooterDtoDb scooterDto)
        {
            return new Scooter(scooterDto.ScooterId, scooterDto.Rented, scooterDto.Defected);
        }
    }
}