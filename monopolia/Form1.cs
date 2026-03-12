using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monopolia
{
    public partial class Form1 : Form
    {
        List<field> GameField = new List<field>();
        List<player> Players = new List<player>();
        public Form1()
        {
            InitializeComponent();
            GameField.Add(new field(1,panel1,"Старт",0,0,"start",0));
            GameField.Add(new field(2, panel2, "", 0, 400, "brown", 100));
            GameField.Add(new field(3, panel3, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(4, panel4, "", 0,600, "brown", 150));
            GameField.Add(new field(5, panel5, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(6, panel6, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(7, panel7, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(8, panel8, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(9, panel9, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(10, panel10, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(11, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(12, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(13, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(14, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(15, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(16, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(17, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(18, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(19, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(20, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(21, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(22, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(23, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(24, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(25, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(26, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(27, panel2, "НАЛОГ", 0, 0, "налог", -1000));
            GameField.Add(new field(28, panel2, "НАЛОГ", 0, 0, "налог", -1000));
          


        }
        public int cube1;
        public int cube2;
        public int result;
        Random rand= new Random();
        
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            cube1 = rand.Next(1,6);
            cube2 = rand.Next(1,6);
            lblDice1.Text = "Кубик 1: " + cube1;
            lblDice2.Text = "Кубик 2: " + cube2;
            result = cube2 + cube1;
            lblDiceResult.Text = "Результат: " + result;
           
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            int position1 = 1;
            position1 += result;

            
        }

        
    }
}
