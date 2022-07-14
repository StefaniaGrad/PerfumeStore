using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Domain.Models
{
    public class OptionValueVariant
    {
        public Guid OptionValueId { get; set; }
        public OptionValue OptionValue { get; set; }
        public Guid VariantId { get; set; }
        public Variant Variant { get; set; }
    }
}
