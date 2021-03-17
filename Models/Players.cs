using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApimodelbase.Models
{
    public class Players
    {
        public int PId   { get; set; }
        public string PName { get; set; }
        public DateTime PDob { get; set; }
        public string PTeam { get; set; }
    }
}
