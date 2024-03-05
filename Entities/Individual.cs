using System;
using System.ComponentModel;

namespace Entities
{
    public class Individual
    {
        // PROPERTIES

        [DisplayName("ID de individuo")]
        public int IndividualId { get; set; }

        [DisplayName("Está activo")]
        public bool ActiveStatus { get; set; }

        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [DisplayName("Nacimiento")]
        public DateTime Birth {  get; set; }

        [DisplayName("CUIL/CUIT")]
        public TaxCode TaxCode { get; set; }

        [DisplayName("Dirección")]
        public Adress Adress { get; set; }

        [DisplayName("Teléfono")]
        public Phone Phone { get; set; }

        [DisplayName("Persona")]
        public Person Person { get; set; }

        [DisplayName("Organización")]
        public Organization Organization { get; set; }

        // CONSTRUCT

        public Individual()
        {
            Birth = new DateTime();
            Phone = new Phone();
            Adress = new Adress();
            TaxCode = new TaxCode();
            Person = new Person();
            Organization = new Organization();
        }

        // METHODS

        public override string ToString()
        {
            if (this.isPerson())
                return Person.ToString();
            else
                return Organization.ToString();
        }

        public bool isPerson()
        {
            if (Person.FirstName != "" && Person.LastName != "" && Person.FirstName != null && Person.LastName != null)
                return true;
            return false;
        }
    }
}
