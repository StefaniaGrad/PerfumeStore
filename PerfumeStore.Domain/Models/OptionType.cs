using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Domain.Models
{
    public class OptionType : BaseEntity
    {
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
