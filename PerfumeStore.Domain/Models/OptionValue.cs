using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Domain.Models
{
    public class OptionValue : BaseEntity
    {
        public string Name { get; set; }
        public Guid OptionTypeId { get; set; }
        public OptionType OptionType { get; set; }
        public ICollection<OptionValueVariant> Variants { get; set; }
    }
}
