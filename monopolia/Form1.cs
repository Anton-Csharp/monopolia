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
        public int position1 = 0;
        public int position2 = 0;
        public int position3 = 0;
        public int position4 = 0;
        List<field> pl1 = new List<field>();
        List<field> pl2 = new List<field>();
        List<field> pl3 = new List<field>();
        List<field> pl4 = new List<field>();
        List<field> GameField = new List<field>();
        List<player> Players = new List<player>();
        public int currentPlayer = 1;
        public Form1()
        {
            Players.Add(new player(1,15000,0,pl1));
            Players.Add(new player(2, 15000,0, pl2));
            Players.Add(new player(3, 15000,0, pl3));
            Players.Add(new player(4, 15000,0, pl4));
            InitializeComponent();
            GameField.Add(new field(1,panel1,"Старт",0,0,"start",0));
            GameField.Add(new field(2, panel2, "", 0, 400, "brown", 100));
            GameField.Add(new field(3, panel3, "", 0, 0, "налог", -1000));
            GameField.Add(new field(4, panel4, "", 0,600, "brown", 150));
            GameField.Add(new field(5, panel5, "", 0, 0, "налог", -1000));
            GameField.Add(new field(6, panel6, "", 0, 0, "налог", -1000));
            GameField.Add(new field(7, panel7, "", 0, 0, "налог", -1000));
            GameField.Add(new field(8, panel8, "", 0, 0, "налог", -1000));
            GameField.Add(new field(9, panel9, "", 0, 0, "налог", -1000));
            GameField.Add(new field(10, panel10, "", 0, 0, "налог", -1000));
            GameField.Add(new field(11, panel11, "", 0, 0, "налог", -1000));
            GameField.Add(new field(12, panel12, "", 0, 0, "налог", -1000));
            GameField.Add(new field(13, panel13, "", 0, 0, "налог", -1000));
            GameField.Add(new field(14, panel14, "", 0, 0, "налог", -1000));
            GameField.Add(new field(15, panel15, "", 0, 0, "налог", -1000));
            GameField.Add(new field(16, panel16, "", 0, 0, "налог", -1000));
            GameField.Add(new field(17, panel17, "", 0, 0, "налог", -1000));
            GameField.Add(new field(18, panel18, "", 0, 0, "налог", -1000));
            GameField.Add(new field(19, panel19, "", 0, 0, "налог", -1000));
            GameField.Add(new field(20, panel20, "", 0, 0, "налог", -1000));
            GameField.Add(new field(21, panel21, "", 0, 0, "налог", -1000));
            GameField.Add(new field(22, panel22, "", 0, 0, "налог", -1000));
            GameField.Add(new field(23, panel23, "", 0, 0, "налог", -1000));
            GameField.Add(new field(24, panel24, "", 0, 0, "налог", -1000));
            GameField.Add(new field(25, panel25, "", 0, 0, "налог", -1000));
            GameField.Add(new field(26, panel26, "", 0, 0, "налог", -1000));
            GameField.Add(new field(27, panel27, "", 0, 0, "налог", -1000));
            GameField.Add(new field(28, panel28, "", 0, 0, "налог", -1000));
          


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
            if (currentPlayer == 1)
            {
                Players[currentPlayer].position += result;
                GameField[position1].Panel.Controls.Add(pnlToken1);
            }
            if (currentPlayer == 2)
            {
                Players[currentPlayer].position += result;
                GameField[position2].Panel.Controls.Add(pnlToken2);
            }
            if (currentPlayer == 3)
            {
                Players[currentPlayer].position += result;
                GameField[position3].Panel.Controls.Add(pnlToken3);
            }
            if (currentPlayer == 4)
            {
                Players[currentPlayer].position += result;
                GameField[position4].Panel.Controls.Add(pnlToken4);
            }
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            
            if (currentPlayer==4)
            {
                currentPlayer = 1;
                lblCurrentPlayer.Text = "Текущий игрок: \r\n" + currentPlayer;
            }
            else
            {
                currentPlayer++;
                lblCurrentPlayer.Text = "Текущий игрок: \r\n" + currentPlayer;
            }
        }

        private void btnBuyProperty_Click(object sender, EventArgs e)
        {
            int crpl = currentPlayer--;
            Players[crpl].Money -= GameField[Players[crpl].position].price;
            Players[crpl].Fields.Add(GameField[Players[crpl].position]);
        }

        private void btnBuildHouse_Click(object sender, EventArgs e)
        {
            int crpl = currentPlayer--;

            
            

           
        }

        private void zalog_Click(object sender, EventArgs e)
        {

        }
    }
}
