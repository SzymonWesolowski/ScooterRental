using ScooterRental.Domain;

namespace ScooterRental.Application
{
    public interface IDefectRepository
    {
        void AddDefect(Defect defect);
        void DefectResolved(int scooterId);
    }
}