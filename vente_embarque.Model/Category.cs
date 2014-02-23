﻿using System;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Category:EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}