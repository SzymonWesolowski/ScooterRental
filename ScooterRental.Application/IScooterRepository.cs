namespace ScooterRental.Application
{
    public interface IScooterRepository
    {
        void RentScooter(int scooterId);
        void EndRental(int scooterId);
        void ReportDefect(int scooterId);
        void DefectResolved(int scooterId);
        int GetNumberOfAvailableScooters();
    }
}