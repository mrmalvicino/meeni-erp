using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Individual
    {
        // PROPERTIES

        public int Id { get; set; }
        [DisplayName("Activo")]
        public bool ActiveStatus { get; set; }
        [DisplayName("Persona")]
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
        public LegalId LegalId { get; set; }

        // CONSTRUCT

        public Individual()
        {
            Phone = new Phone();
            Adress = new Adress();
            LegalId = new LegalId();
            ActiveStatus = true;
        }
    }
}
