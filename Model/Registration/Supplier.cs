﻿using HenriqueV5.Models.Tables;
using System.Collections.Generic;

namespace HenriqueV5.Models.Registration
{
    public class Supplier
    {
        public long? SupplierId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}