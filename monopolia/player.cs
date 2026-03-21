using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monopolia
{
    internal class player
    {
        public int Id {  get; set; } 
        public int Money { get; set; } 
        public bool InJail {  get; set; }
        public bool isBunk {  get; set; }
        public Panel Pnl {  get; set; }
        public List<field> Fields{ get; set; }= new List<field>();
        public int position { get; set; } = 0;
        public player(int id,int money,int pos,Panel pnl,List<field> fields)
        {
           Id = id; 
           Money = money;
           Pnl = pnl;
           position = pos;
           Fields = fields;
        }
    }
}
