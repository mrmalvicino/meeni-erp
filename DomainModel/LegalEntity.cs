using Interfaces;
using System;

namespace DomainModel
{
    public class LegalEntity : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreationDate { get; set; }
        public Image LogoImage { get; set; }
        public Address Address { get; set; }
    }
}
