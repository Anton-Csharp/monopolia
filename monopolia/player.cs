using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopolia
{
    internal class player
    {
        public int Id {  get; set; }
        public int Money {  get; set; }
        public List<field> Fields { get; set; }
        public int position { get; set; }
        public player(int id,int money,int pos,List<field> fields)
        {
            id = Id;
            pos = position;
            money = Money;
            fields = Fields;
        }
    }
}
