namespace ScooterRental.Persistence.Dtos
{
    public class DefectDtoDb
    {
        public string UserId { get; set; }
        public int ScooterId { get; set; }
        public string DefectDescription { get; set; }
        public bool Resolved { get; set; }
    }
}