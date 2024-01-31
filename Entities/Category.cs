﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        // PROPERTIES

        [DisplayName("ID de categoría")]
        public int Id { get; set; }

        [DisplayName("Área")]
        public string Area { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Experiencia")]
        public string Seniority { get; set; }

        // METHODS

        public override string ToString()
        {
            return Title + " " + Seniority;
        }
    }
}
