using System;
using System.Collections.Generic;

namespace ScooterRental.Domain
{
    public class User
    {
        public User(Guid userId, string firstName, string lastName)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
        }

        public Guid UserId { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}