﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Address { get; set; }
        public string CustomerNumber { get; set; }
        

    }
}
