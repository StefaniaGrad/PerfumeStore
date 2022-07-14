using PerfumeStore.Domain.IRepositories;
using PerfumeStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeStore.Dal.Repositories
{
    public class OptionValueRepository : GenericRepository<OptionValue>, IOptionValueRepository
    {
        public OptionValueRepository(PerfumeStoreContext context) : base(context)
        {
        }
    }
}
