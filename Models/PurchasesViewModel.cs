﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSoftwareSite.Models
{
    public class PurchasesViewModel
    {
        public List<DateTime> DateTime { get; set; }
        public string ImageLink { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public List<string> ActivationCode { get; set; }
        public int ProductId { get; set; }
    }
}

