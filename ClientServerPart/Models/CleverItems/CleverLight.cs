using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientServerPart.Models
{
    public class CleverLight : ICleverItem
    {
        public int Id { get ; set ; }
        public string ItemName { get ; set ; }
        public bool CurrentStatus { get; set; }  //on\off
        public bool OverallStatus { get; set; } // work\broken
        public int Brightness { get; set; }

    }
}
