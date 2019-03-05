using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientServerPart.Models
{
    public class EFItemRepository : IItemRepository
    {
        private ApplicationDBContent context;
        public EFItemRepository(ApplicationDBContent ctx)
        {
            context = ctx;
        }

        public IQueryable<CleverItem> CleverItems => context.CleverItems;
    }
}
