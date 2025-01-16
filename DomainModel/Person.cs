using System;

namespace DomainModel
{
    public class Person
    {
        public int PersonId { get; set; }
        public string DNI { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
    }
}
