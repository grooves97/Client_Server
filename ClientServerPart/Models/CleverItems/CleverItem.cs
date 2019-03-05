using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientServerPart.Models
{
    public class CleverItem : ICleverItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public bool CurrentStatus { get; set; }  //on\off
        public bool OverallStatus { get; set; } // work\broken
    }
}
