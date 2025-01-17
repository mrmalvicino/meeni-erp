using System;

namespace DomainModel
{
    public class Employee : Person
    {
        public DateTime AdmissionDate { get; set; }
        public User User { get; set; }
    }
}
