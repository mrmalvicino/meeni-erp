﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Warehouse
    {
        // PROPERTIES

        [DisplayName("ID de depósito")]
        public int Id { get; set; }

        [DisplayName("Está activo")]
        public bool ActiveStatus { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Dirección")]
        public Adress Adress { get; set; }

        // CONSTRUCT

        public Warehouse()
        {
            Adress = new Adress();
        }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}
