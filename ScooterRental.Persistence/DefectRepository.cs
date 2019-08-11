using System.Linq;
using ScooterRental.Application;
using ScooterRental.Domain;
using ScooterRental.Persistence.Dtos;

namespace ScooterRental.Persistence
{
    public class DefectRepository : IDefectRepository
    {
        public void AddDefect(Defect defect)
        {
            using (var context = new RentalContext())
            {
                var defectDto = modelToDto(defect);
                context.Defects.Add(defectDto);
                context.SaveChanges();
            }
        }

        public void DefectResolved(int scooterId)
        {
            using (var context = new RentalContext())
            {
                var defect = context.Defects.First(d => d.ScooterId == scooterId && d.Resolved == false);
                defect.Resolved = true;
                context.SaveChanges();

            }
        }

        private DefectDtoDb modelToDto(Defect defect)
        {
            var defectDto = new DefectDtoDb
            {
                UserId = defect.UserId.ToString(),
                ScooterId = defect.ScooterId,
                DefectDescription = defect.DefectDescription,
                Resolved = defect.Resolved
            };
            return defectDto;
        }
    }
}