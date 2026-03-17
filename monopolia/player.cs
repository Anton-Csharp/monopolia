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
        public int Money { get; set; } 
        public List<field> Fields{ get; set; }= new List<field>();
        public int position { get; set; } = 0;
        public player(int id,int money,int pos,List<field> fields)
        {
           Id = id; 
           Money = money;
           position = pos;
           Fields = fields;
        }
    }
}
