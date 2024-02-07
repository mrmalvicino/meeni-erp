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

        [DisplayName("Es persona")]
        public bool IsPerson { get; set; }

        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [DisplayName("Apellido")]
        public string LastName { get; set; }

        [DisplayName("Organización")]
        public string BusinessName { get; set; }

        [DisplayName("Descripción")]
        public string BusinessDescription { get; set; }

        public string ImageUrl { get; set; }

        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [DisplayName("Teléfono")]
        public Phone Phone { get; set; }

        [DisplayName("Dirección")]
        public Adress Adress { get; set; }

        [DisplayName("CUIL/CUIT")]
        public TaxCode TaxCode { get; set; }

        // CONSTRUCT

        public Individual()
        {
            Phone = new Phone();
            Adress = new Adress();
            TaxCode = new TaxCode();
        }

        // METHODS

        public override string ToString()
        {
            if (this.IsPerson)
                return $"{this.LastName}, {this.FirstName}";
            else
                return this.BusinessName;
        }

        public Individual toIndividual()
        {
            Individual individual;
            individual = new Individual();

            individual.IndividualId = this.IndividualId;
            individual.ActiveStatus = this.ActiveStatus;
            individual.IsPerson = this.IsPerson;
            individual.FirstName = this.FirstName;
            individual.LastName = this.LastName;
            individual.BusinessName = this.BusinessName;
            individual.BusinessDescription = this.BusinessDescription;
            individual.ImageUrl = this.ImageUrl;
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
            obj.IsPerson = individual.IsPerson;
            obj.FirstName = individual.FirstName;
            obj.LastName = individual.LastName;
            obj.BusinessName = individual.BusinessName;
            obj.BusinessDescription = individual.BusinessDescription;
            obj.ImageUrl = individual.ImageUrl;
            obj.Email = individual.Email;
            obj.Phone = individual.Phone;
            obj.Adress = individual.Adress;
            obj.TaxCode = individual.TaxCode;

            return obj;
        }
    }
}
