using System;

namespace DomainModel
{
    public class Employee : Person
    {
        public bool ActivityStatus { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}
