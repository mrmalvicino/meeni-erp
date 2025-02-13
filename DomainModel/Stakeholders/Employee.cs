using Interfaces;
using System;

namespace DomainModel.Stakeholders
{
    public class Employee : Stakeholder, IDispensable
    {
        public bool ActivityStatus { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}
