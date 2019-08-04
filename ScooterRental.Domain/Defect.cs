using System;

namespace ScooterRental.Domain
{
    public class Defect
    {
        public Defect(Guid userId, int scooterId, string defectDescription, bool resolved)
        {
            UserId = userId;
            ScooterId = scooterId;
            DefectDescription = defectDescription;
            Resolved = resolved;
        }

        public Guid UserId { get; }
        public int ScooterId { get; }
        public string DefectDescription { get; }
        public bool Resolved { get; }
    }
}