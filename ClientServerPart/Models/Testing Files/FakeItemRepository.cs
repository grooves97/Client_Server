using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientServerPart.Models
{
    public class FakeItemRepository : IItemRepository
    {
        public IQueryable<CleverItem> CleverItems => new List<CleverItem>
        {
            //The AsQueryable method is used to convert the fixed collection of objects to an IQueryable < CleverItem >
            new CleverItem {ItemName = "Lamp In The Hall", CurrentStatus= false, OverallStatus = true},
            new CleverItem {ItemName = "Lamp In The Garden",CurrentStatus= true, OverallStatus = true},
            new CleverItem {ItemName = "Lamp In The Restroom",CurrentStatus= false, OverallStatus = false}
        }.AsQueryable<CleverItem>();

    }
}
