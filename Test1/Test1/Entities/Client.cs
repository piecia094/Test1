﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceCreator.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nip { get; set; }
        public virtual Address Klient { get; set; }


    }
}
