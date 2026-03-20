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
            this.Text = "МОНОПОЛИЯ - Настольная игра";
            InitializeComponent();
            Players.Add(new player(1, 15000, 0, pl1));
            Players.Add(new player(2, 15000, 0, pl2));
            Players.Add(new player(3, 15000, 0, pl4));
            GameField.Add(new field(0, null, panel1, "Старт", 0, 0, "start", 0));
            GameField.Add(new field(1, null, panel2, "Санкт-Петербург", 0, 400, "brown", 50));
            GameField.Add(new field(2, null, panel3, "НАЛОГ", 0, 0, "налог", 0));
            GameField.Add(new field(3, null, panel4, "Красноярск", 0, 600, "brown", 60));
            GameField.Add(new field(4, null, panel5, "Самара", 0, 900, "pink", 70));
            GameField.Add(new field(5, null, panel6, "Чебоксары", 0, 1100, "pink", 75));
            GameField.Add(new field(6, null, panel7, "Пенза", 0, 1200, "pink", 80));
            GameField.Add(new field(7, null, panel8, "ТЮРЬМА", 0, 0, "jail", 0));
            GameField.Add(new field(8, null, panel9, "Челябинск", 0, 1300, "blue", 90));
            GameField.Add(new field(9, null, panel10, "ШАНС", 0, 0, "шанс", 0));
            GameField.Add(new field(10, null, panel11, "Барнаул", 0, 1500, "blue", 100));
            GameField.Add(new field(11, null, panel12, "Пулково", 0, 2000, "аэропорт", 500));
            GameField.Add(new field(12, null, panel13, "Воронеж", 0, 1700, "chocolate", 115));
            GameField.Add(new field(13, null, panel14, "Сыктывкар", 0, 1800, "chocolate", 120));
            GameField.Add(new field(14, null, panel15, "БЕСПЛ. ПАРКОВКА", 0, 0, "парковка", 0));
            GameField.Add(new field(15, null, panel16, "Москва", 0, 2000, "red", 140));
            GameField.Add(new field(16, null, panel17, "Рязань", 0, 2200, "red", 150));
            GameField.Add(new field(17, null, panel18, "Архангельск", 0, 2400, "red", 170));
            GameField.Add(new field(18, null, panel19, "Кольцово", 0, 2000, "аэропорт", 500));
            GameField.Add(new field(19, null, panel20, "Обнинск", 0, 2500, "yellow", 200));
            GameField.Add(new field(20, null, panel21, "Новосибирск", 0, 2800, "yellow", 210));
            GameField.Add(new field(21, null, panel22, "В ТЮРЬМУ", 0, 0, "jail", 0));
            GameField.Add(new field(22, null, panel23, "Курган", 0, 3100, "green", 250));
            GameField.Add(new field(23, null, panel24, "ШАНС", 0, 0, "шанс", 0));
            GameField.Add(new field(24, null, panel25, "Сургут", 0, 3400, "green", 280));
            GameField.Add(new field(25, null, panel26, "Шереметьево", 0, 2000, "аэропорт", 500));
            GameField.Add(new field(26, null, panel27, "Пермь", 0, 4000, "dark blue", 420));
            GameField.Add(new field(27, null, panel28, "Екатеринбург", 0, 4400, "dark blue", 460));



        }
        public int cube1;
        public int cube2;
        public int result;
        Random rand = new Random();

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int crpl = currentPlayer - 1;
            cube1 = rand.Next(1, 7);
            cube2 = rand.Next(1, 7);
            lblDice1.Text = "Кубик 1: " + cube1;
            lblDice2.Text = "Кубик 2: " + cube2;
            result = cube2 + cube1;
            lblDiceResult.Text = "Результат: " + result;
            Players[crpl].position += result;
            if (Players[crpl].position >= 28)
            {
                Players[crpl].position -= 28;
                Players[crpl].Money += 2000;
                lblMoney1.Text = "Деньги: " + Players[0].Money;
                lblMoney2.Text = "Деньги: " + Players[1].Money;
                lblMoney3.Text = "Деньги: " + Players[2].Money;
                lblMoney4.Text = "Деньги: " + Players[3].Money;
            }
            label20.Text = "Название: " + GameField[Players[crpl].position].Name;
            label33.Text = "Кол-во домов: " + GameField[Players[crpl].position].CountHomes;
            label34.Text = "Цена: " + GameField[Players[crpl].position].Price;
            label35.Text = "Прибыль: " + GameField[Players[crpl].position].Income;

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
            if (Players[crpl].position == GameField[2].Id)
            {
                Players[crpl].Money -= 1000;
                lblMoney1.Text = "Деньги: " + Players[0].Money;
                lblMoney2.Text = "Деньги: " + Players[1].Money;
                lblMoney3.Text = "Деньги: " + Players[2].Money;
                lblMoney4.Text = "Деньги: " + Players[3].Money;
            }
            if (Players[crpl].position == GameField[21].Id)
            {
                Players[crpl].position = 7;

            }
            if (Players[crpl].position == GameField[9].Id || Players[crpl].position == GameField[23].Id)
            {
                int card = rand.Next(1, 6);
                switch (card)
                {
                    case 1:
                        Players[crpl].Money += 1000;
                        MessageBox.Show("Вы выиграли в лотерею $1000!");
                        break;
                    case 2:
                        Players[crpl].Money -= 500;
                        MessageBox.Show("Вы платите налог $500");
                        break;
                    case 3:
                        Players[crpl].position = 0;
                        Players[crpl].Money += 2000;
                        MessageBox.Show("Вы идете на старт и получаете 2000!");
                        break;
                    case 4:
                        Players[crpl].position = 7;
                        Players[crpl].InJail = true;
                        MessageBox.Show("Вы отправляетесь в тюрьму!");
                        break;
                    case 5:
                        Players[crpl].Money += 500;
                        MessageBox.Show("Вы получаету дивиденды $500!");
                        break;
                }
            }

            GameField[Players[crpl].position].CheckedClassField();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {

            if (currentPlayer == 4)
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
            int i = Players[crpl].Fields.Count;
            if (Players[crpl].Fields.Find(x => x.Id == Players[crpl].position) != null)
            {
                MessageBox.Show("У вас уже есть это поле");

            }
            else
            {
                if (Players[crpl].Money > 0)
                {
                    Players[crpl].Money -= GameField[Players[crpl].position].Price;
                    GameField[Players[crpl].position].Owner = Players[crpl];
                    Players[crpl].Fields.Add(GameField[Players[crpl].position]);
                }
                else
                {
                    MessageBox.Show("Вы проиграли");

                }

                MessageBox.Show("Вы купили: " + GameField[Players[crpl].position].Name);
            }

            lblMoney1.Text = "Деньги: " + Players[0].Money;
            lblMoney2.Text = "Деньги: " + Players[1].Money;
            lblMoney3.Text = "Деньги: " + Players[2].Money;
            lblMoney4.Text = "Деньги: " + Players[3].Money;
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
            int crpl = currentPlayer--;
            if (Players[crpl].Fields.Find(x => x.Id == Players[crpl].position) != null)
            {
                Players[crpl].Money += Players[crpl].Fields.Find(x => x.Id == Players[crpl].position).Price / 2;
                lblMoney1.Text = "Деньги: " + Players[0].Money;
                lblMoney2.Text = "Деньги: " + Players[1].Money;
                lblMoney3.Text = "Деньги: " + Players[2].Money;
                lblMoney4.Text = "Деньги: " + Players[3].Money;
            }

        }
        private void EndGame()
        {
            var winners = Players.Where(p => !p.isBunk).ToList();
            if (winners.Count == 1)
            {
                MessageBox.Show($"Игра окончена! Победитель: {winners[0].Id}!", "Конец игры",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Игра окончена!", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
