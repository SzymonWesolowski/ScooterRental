using System;
using System.Collections.Generic;

namespace ScooterRental.Domain
{
    public class User
    {
        public User(Guid userId, string firstName, string lastName, List<Rental> rentals)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Rentals = rentals;
        }

        public Guid UserId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public List<Rental> Rentals { get; }
    }
}