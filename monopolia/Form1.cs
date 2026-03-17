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
       
        List<field> pl1 = new List<field>();
        List<field> pl2 = new List<field>();
        List<field> pl3 = new List<field>();
        List<field> pl4 = new List<field>();
        List<field> GameField = new List<field>();
        List<player> Players = new List<player>();
        public int currentPlayer = 1;
        public Form1()
        {
            
            InitializeComponent();
            Players.Add(new player(1, 15000, 0, pl1));
            Players.Add(new player(2, 15000, 0, pl2));
            Players.Add(new player(3, 15000, 0, pl3));
            Players.Add(new player(4, 15000, 0, pl4));
            GameField.Add(new field(1,panel1,"Старт",0,0,"start",0));
            GameField.Add(new field(2, panel2, "", 0, 400, "brown", 50));
            GameField.Add(new field(3, panel3, "", 0, 0, "налог", 0));
            GameField.Add(new field(4, panel4, "", 0,600, "brown", 60));
            GameField.Add(new field(5, panel5, "", 0, 900, "pink", 70));
            GameField.Add(new field(6, panel6, "", 0, 1100, "pink", 75));
            GameField.Add(new field(7, panel7, "", 0, 1200 ,"pink", 80));
            GameField.Add(new field(8, panel8, "", 0, 0, "jail", 0));
            GameField.Add(new field(9, panel9, "", 0, 1300, "blue", 90));
            GameField.Add(new field(10, panel10, "", 0, 0, "шанс", 0));
            GameField.Add(new field(11, panel11, "", 0, 1500, "blue", 100));
            GameField.Add(new field(12, panel12, "", 0, 2000, "аэропорт", 500));
            GameField.Add(new field(13, panel13, "", 0, 1700, "chocolate", 115));
            GameField.Add(new field(14, panel14, "", 0, 1800, "chocolate", 120));
            GameField.Add(new field(15, panel15, "", 0, 0, "парковка", 0));
            GameField.Add(new field(16, panel16, "", 0, 2000, "red", 140));
            GameField.Add(new field(17, panel17, "", 0, 2200, "red", 150));
            GameField.Add(new field(18, panel18, "", 0, 2400, "red", 170));
            GameField.Add(new field(19, panel19, "", 0, 2000, "аэропорт", 500));
            GameField.Add(new field(20, panel20, "", 0, 2500, "yellow", 200));
            GameField.Add(new field(21, panel21, "", 0, 2800, "yellow", 210));
            GameField.Add(new field(22, panel22, "", 0, 0, "jail", 0));
            GameField.Add(new field(23, panel23, "", 0, 3100, "green", 250));
            GameField.Add(new field(24, panel24, "", 0, 0, "шанс", 0));
            GameField.Add(new field(25, panel25, "", 0,3400, "green", 280));
            GameField.Add(new field(26, panel26, "", 0, 2000, "аэропорт", 500));
            GameField.Add(new field(27, panel27, "", 0, 4000, "dark blue", 420));
            GameField.Add(new field(28, panel28, "", 0, 4400, "dark blue", 460));
          


        }
        public int cube1;
        public int cube2;
        public int result;
        Random rand= new Random();
        
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int crpl = currentPlayer - 1;
            cube1 = rand.Next(1,7);
            cube2 = rand.Next(1,7);
            lblDice1.Text = "Кубик 1: " + cube1;
            lblDice2.Text = "Кубик 2: " + cube2;
            result = cube2 + cube1;
            lblDiceResult.Text = "Результат: " + result;
            Players[crpl].position += result;
            if (Players[crpl].position >= 28)
            {
                Players[crpl].position -= 28;
                Players[crpl].Money += 2000;
                lblMoney1.Text ="Деньги: "+ Players[0].Money;
                lblMoney2.Text ="Деньги: "+ Players[1].Money;
                lblMoney3.Text ="Деньги: "+ Players[2].Money;
                lblMoney4.Text ="Деньги: "+ Players[3].Money;
            }
            if (currentPlayer == 1)
            {
                GameField[Players[crpl].position].Panel.Controls.Add(pnlToken1);
            }
            if (currentPlayer == 2)
            {
                GameField[Players[crpl].position].Panel.Controls.Add(pnlToken2);
            }
            if (currentPlayer == 3)
            {
                GameField[Players[crpl].position].Panel.Controls.Add(pnlToken3);
            }
            if (currentPlayer == 4)
            {
                GameField[Players[crpl].position].Panel.Controls.Add(pnlToken4);
            }
            GameField[Players[crpl].position].CheckedClassField();
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
            int crpl = currentPlayer - 1;
            Players[crpl].Money -= GameField[Players[crpl].position].Price;
            Players[crpl].Fields.Add(GameField[Players[crpl].position]);
            lblMoney1.Text ="Деньги: "+ Players[0].Money;
            lblMoney2.Text ="Деньги: "+ Players[1].Money;
            lblMoney3.Text ="Деньги: "+ Players[2].Money;
            lblMoney4.Text ="Деньги: "+ Players[3].Money;
        }

        private void btnBuildHouse_Click(object sender, EventArgs e)
        {
            int crpl = currentPlayer--;
            for (int i = 0; i < Players[crpl].Fields.Count; i++)
            {
                if (GameField[Players[crpl].position].Id == Players[crpl].Fields[i].Id)
                {
                    Players[crpl].Money -= 1000;
                    GameField[Players[crpl].position].CountHomes++;
                    Players[crpl].Fields[i].Panel.Controls.Add(panel29);
                }
            }
            
        }

        private void zalog_Click(object sender, EventArgs e)
        {

        }
    }
}
