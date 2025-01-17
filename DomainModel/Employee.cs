using System;

namespace DomainModel
{
    public class Employee : Person
    {
        public DateTime Admission { get; set; }
        public Position Position { get; set; }
        public User User { get; set; }
    }
}
