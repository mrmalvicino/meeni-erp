﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Phone
    {
        public int Country { get; set; }
        public int Area { get; set; }
        public int Number {  get; set; }

        public override string ToString()
        {
            return $"+{Country} ({Area}) {Number}";
        }
    }
}
