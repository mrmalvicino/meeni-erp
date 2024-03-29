﻿using System.ComponentModel;

namespace Entities
{
    public class Person
    {
        // PROPERTIES

        [DisplayName("ID de persona")]
        public int PersonId { get; set; }

        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [DisplayName("Apellido")]
        public string LastName { get; set; }

        // METHODS

        public override string ToString()
        {
            if (FirstName != "" && LastName != "" && FirstName != null && LastName != null)
                return $"{LastName}, {FirstName}";
            else
                return "";
        }
    }
}
