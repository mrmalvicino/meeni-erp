﻿using Interfaces;

namespace DomainModel
{
    public class Client : Person, IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
    }
}
