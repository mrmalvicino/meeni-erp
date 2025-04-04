﻿using Interfaces;

namespace DomainModel.Stakeholders
{
    public class Partner : Stakeholder, IDispensable
    {
        public bool ActivityStatus { get; set; }
        public bool IsClient { get; set; }
        public bool IsSupplier { get; set; }
    }
}
