using System;

namespace ScooterRental.Domain
{
    public class Scooter
    {
        public Scooter(int scooterId, bool rented, bool damaged)
        {
            ScooterId = scooterId;
            Rented = rented;
            Damaged = damaged;
        }
        public int ScooterId { get; }
        public bool Rented { get; }
        public bool Damaged { get; }
    }
}
