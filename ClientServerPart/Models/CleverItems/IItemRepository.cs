using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientServerPart.Models
{
    public interface IItemRepository
    {
        // A class that depends on the IItemRepository interface 
        //can obtain Product objects without needing
        //to know the details of how they are stored or how 
        //the implementation class will deliver them.

        //May be it is better to set ICleverItem except CleverItem
        IQueryable<CleverItem> CleverItems { get; }

    }
}
