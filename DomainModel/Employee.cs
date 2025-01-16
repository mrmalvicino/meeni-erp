using Interfaces;
using System;

namespace DomainModel
{
    public class Employee : Person, IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public DateTime Admission { get; set; }
        public Position Position { get; set; }
        public User User { get; set; }
    }
}
