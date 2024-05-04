using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RealCustomer : Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TC { get; set; }
        public string Address { get; set; }
        public string CustomerNumber { get; set; }
    }
}
