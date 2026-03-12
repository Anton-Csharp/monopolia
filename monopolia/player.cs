using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopolia
{
    internal class player
    {
        public int id {  get; set; }
        public int money {  get; set; }
        public List<field> fields { get; set; }
    }
}
