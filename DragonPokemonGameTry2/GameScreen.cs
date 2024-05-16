using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonPokemonGameTry2
{
    public partial class GameScreen : Form
    {

        int p1Roll;
        int p2Roll;
        int Damage;
        int specialAttack;
        bool isBlocking = false;
        bool turnNumber = false;
        public GameScreen()
        {
            InitializeComponent();

        }
       
        public string[] P1data { get; set; }
        public int[] P1values { get; set; }
        public string[] P2data { get; set; }
        public int[] P2values { get; set; }
        // code above gets the array values from the other form

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            takeInitiative();
            whichplayerTurn(1);
        }

        public int randomRoll()
        {
            Random rnd = new Random();
            return rnd.Next(0, 7);
        }

        public int takeInitiative()
        {
            p1Roll = randomRoll();
            p2Roll = randomRoll();

            if (p1Roll == p2Roll)
            {
                p1Roll = randomRoll();
                p2Roll = randomRoll();
            }
            if (p1Roll > p2Roll)
            {
                return p1Roll;
            }
            else
            {
                return p2Roll;
            }
        }

        public void whichplayerTurn(int playerTurn)
        {
            if (playerTurn == 1)
            {
                LBLPlayername.Text = P1data[0];
                LBLDragonName.Text = P1data[1];
                LBLdragonHealth.Text =P1values[0].ToString();
                LBLDragonAttack.Text = P1values[1].ToString();
                LBLSPATTACK.Text = P1values[2].ToString();
                LBLBlock.Text = P1values[3].ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LBLBlock_Click(object sender, EventArgs e)
        {

        }
    }
}
