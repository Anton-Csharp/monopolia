
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
        public Panel Panel { get; set; }
        public string Name { get; set; }
        public int CountHomes{ get; set; }
        public int Price {  get; set; }
        public string Type { get; set; }
        public int Income { get; set; } 
        public field(int id, Panel panel, string name, int countHomes, int price, string type, int income)
        {
            this.Id=id;
            Panel=panel;
            this.Name=name;
            this.CountHomes=countHomes;
            this.Price=price;
            Type=type;
            Income=income;
        }

        public int CheckedClassField()
        {
            if (Type == "brown")
            {
                return Income+500*CountHomes;
            }
            if (Type == "pink")
            {
                return Income+700*CountHomes;
            }
            if (Type == "blue")
            {
                return Income+850*CountHomes;
            }
            if (Type == "chocolate")
            {
                return Income+1000*CountHomes;
            }
            if (Type == "red")
            {
                return Income+1100*CountHomes;
            }
            if (Type == "yellow")
            {
                return Income+1300*CountHomes;
            }
            if (Type == "green")
            {
                return Income+1500*CountHomes;
            }
            if (Type == "dark blue")
            {
                return Income+1750*CountHomes;
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
