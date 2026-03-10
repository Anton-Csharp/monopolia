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
        public Form1()
        {
            InitializeComponent();
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
