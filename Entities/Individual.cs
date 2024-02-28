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

        public Individual copyToIndividual()
        {
            Individual individual;
            individual = new Individual();

            individual.IndividualId = this.IndividualId;
            individual.ActiveStatus = this.ActiveStatus;
            individual.Email = this.Email;
            individual.Phone = this.Phone;
            individual.Adress = this.Adress;
            individual.TaxCode = this.TaxCode;

            return individual;
        }

        public T copyFromIndividual<T>(Individual individual) where T : Individual, new()
        {
            T obj = new T();

            obj.IndividualId = individual.IndividualId;
            obj.ActiveStatus = individual.ActiveStatus;
            obj.Email = individual.Email;
            obj.Phone = individual.Phone;
            obj.Adress = individual.Adress;
            obj.TaxCode = individual.TaxCode;

            return obj;
        }
    }
}
