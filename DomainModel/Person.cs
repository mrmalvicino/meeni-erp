using Interfaces;
using System;

namespace DomainModel
{
    public class Person : IIdentifiable
    {
        public int Id { get; set; }
        public string CUIL { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Image ProfileImage { get; set; }
        public Address Address { get; set; }
    }
}
