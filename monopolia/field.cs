
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
        public int id {  get; set; }
        public Panel Panel { get; set; }
        public string name { get; set; }
        public int countHomes{ get; set; }
        public int price {  get; set; }
        public string Type { get; set; }
        public int Income { get; set; } 
        public field(int id, Panel panel, string name, int countHomes, int price, string type, int income)
        {
            this.id=id;
            Panel=panel;
            this.name=name;
            this.countHomes=countHomes;
            this.price=price;
            Type=type;
            Income=income;
        }

        public int CheckedClassField()
        {
            if (Type == "brown")
            {
                return Income+500*countHomes;
            }
            if (Type == "pink")
            {
                return Income+700*countHomes;
            }
            if (Type == "blue")
            {
                return Income+850*countHomes;
            }
            if (Type == "chocolate")
            {
                return Income+1000*countHomes;
            }
            if (Type == "red")
            {
                return Income+1100*countHomes;
            }
            if (Type == "yellow")
            {
                return Income+1300*countHomes;
            }
            if (Type == "green")
            {
                return Income+1500*countHomes;
            }
            if (Type == "dark blue")
            {
                return Income+1750*countHomes;
            }
            if (Type == "аэропорт")
            {
                return Income+1000;
            }
            if (Type == "парковка")
            {
                return 0;
            }
            if (Type == "jail")
            {
                return 0;
            }
            if (Type == "налог")
            {
                return -1000;
            }
            if (Type == "шанс")
            {
                return 0;
            }
            return 0;
        }
    }
}
