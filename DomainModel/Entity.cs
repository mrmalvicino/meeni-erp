using Interfaces;
using System;

namespace DomainModel
{
    public class Entity : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Image Image { get; set; }
        public Address Address { get; set; }
    }
}
