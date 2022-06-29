using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Domain.Models
{
    public class Variant : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public ICollection<OptionValue> OptionValues { get; set; }
    }
}
