
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monopolia
{
    internal class field
    {
        public int Id {  get; set; }
        public player Owner { get; set; }
        public Panel Panel { get; set; }
        public string Name { get; set; }
        public int Homes {  get; set; }
        public int priceHome { get; set; }
        public int Price {  get; set; }
        public string Type { get; set; }
        public int Income { get; set; } 
        public field(int id,player pl, Panel panel,int homes,int pricehomes, string name, int price, string type, int income)
        {
            this.Id=id;
            Owner = pl;
            Panel=panel;
            this.Name=name;
            this.Homes = homes;
            this.priceHome = pricehomes;
            this.Price=price;
            Type=type;
            Income=income;
        }

        
    }
}

