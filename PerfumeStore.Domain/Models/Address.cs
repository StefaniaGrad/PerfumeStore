using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Domain.Models
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public int Zipcode { get; set; }
    }
}
