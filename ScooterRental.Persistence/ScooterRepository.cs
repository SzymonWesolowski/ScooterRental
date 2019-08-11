using System.Linq;
using ScooterRental.Application;

namespace ScooterRental.Persistence
{
    public class ScooterRepository : IScooterRepository
    {
        public void RentScooter(int scooterId)
        {
            using (var context = new RentalContext())
            {
                var scooter = context.Scooters.First(s => s.ScooterId == scooterId);
                scooter.Rented = true;
                context.SaveChanges();
            }
        }

        public void EndRental(int scooterId)
        {
            using (var context = new RentalContext())
            {
                var scooter = context.Scooters.First(s => s.ScooterId == scooterId);
                scooter.Rented = false;
                context.SaveChanges();
            }
        }

        public void ReportDefect(int scooterId)
        {
            using (var context = new RentalContext())
            {
                var scooter = context.Scooters.First(s => s.ScooterId == scooterId);
                scooter.Defected = true;
                context.SaveChanges();
            }
        }

        public void DefectResolved(int scooterId)
        {
            using (var context = new RentalContext())
            {
                var scooter = context.Scooters.First(s => s.ScooterId == scooterId);
                scooter.Rented = false;
                context.SaveChanges();
            }
        }

        public int GetNumberOfAvailableScooters()
        {
            using (var context = new RentalContext())
            {
                var availableScooters = context.Scooters.Where(s => s.Defected == false && s.Rented == false);
                return availableScooters.Count();
            }
        }
    }
}