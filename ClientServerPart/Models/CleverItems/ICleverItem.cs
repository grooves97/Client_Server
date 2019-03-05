using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientServerPart.Models
{
    public interface ICleverItem
    {
        int Id { get; set; }
        string ItemName{ get; set; }        
        bool CurrentStatus { get; set; }  //on\off
        bool OverallStatus { get; set; }   // work\broken
    }
}
