﻿using System.ComponentModel;

namespace Entities
{
    public class Item
    {
        // PROPERTIES

        [DisplayName("ID de item")]
        public int ItemId { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [DisplayName("Costo")]
        public decimal Cost { get; set; }

        [DisplayName("Rubro")]
        public Category Category { get; set; }
    }
}
