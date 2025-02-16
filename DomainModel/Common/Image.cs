﻿using Interfaces;
using System;

namespace DomainModel.Common
{
    [Serializable]
    public class Image : IIdentifiable
    {
        public int Id { get; set; }
        public string URL { get; set; }
    }
}
