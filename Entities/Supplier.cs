﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Supplier : BusinessPartner
    {
        // PROPERTIES

        [DisplayName("Indispensable")]
        public bool IsIndispensable { get; set; }
    }
}
