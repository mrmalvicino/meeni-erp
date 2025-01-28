using System;

namespace DomainModel
{
    public class Employee : Stakeholder
    {
        public bool ActivityStatus { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}
