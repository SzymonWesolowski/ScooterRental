using System;
using System.Threading;
using ScooterRental.Domain;

namespace ScooterRental.Application
{
    public class DefectService
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IScooterRepository _scooterRepository;
        private readonly IDefectRepository _defectRepository;

        public DefectService(IRentalRepository rentalRepository, IScooterRepository scooterRepository,
            IDefectRepository defectRepository)
        {
            _rentalRepository = rentalRepository;
            _scooterRepository = scooterRepository;
            _defectRepository = defectRepository;
        }

        public void ReportDefect(Guid userId, int scooterId, string defectDescription)
        {
            if (UserCanReportDefect(userId, scooterId))
            {
                _scooterRepository.ReportDefect(scooterId);
                var defect = new Defect(userId, scooterId, defectDescription, false);
                _defectRepository.AddDefect(defect);
            }
        }

        public void DefectResolved(int scooterId)
        {
            _defectRepository.DefectResolved(scooterId);
            _scooterRepository.DefectResolved(scooterId);
        }

        private bool UserCanReportDefect(Guid userId, int scooterId)
        {
            return _rentalRepository.UserCanReportDefect(userId, scooterId);
        }
    }
}