﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class BusinessPartner : Individual
    {
        public string PaymentMethod { get; set; }
        public char InvoiceCategory { get; set; }
    }
}
