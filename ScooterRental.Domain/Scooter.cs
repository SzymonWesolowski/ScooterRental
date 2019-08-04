using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace ScooterRental.Domain
{
    public class Scooter
    {
        public Scooter(int scooterId, bool rented, bool defected)
        {
            ScooterId = scooterId;
            Rented = rented;
            Defected = defected;
        }
        public int ScooterId { get; }
        public bool Rented { get;  }
        public bool Defected { get; }

    }
}
