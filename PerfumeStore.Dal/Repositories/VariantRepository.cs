using PerfumeStore.Domain.IRepositories;
using PerfumeStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Dal.Repositories
{
    public class VariantRepository : GenericRepository<Variant>, IVariantRepository
    {
        public VariantRepository(PerfumeStoreContext context) : base(context)
        {
        }
    }
}
