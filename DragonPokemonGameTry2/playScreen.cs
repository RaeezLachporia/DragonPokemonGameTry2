using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonPokemonGameTry2
{
    public partial class playScreen : Form
    {
        public playScreen()
        {
            InitializeComponent();
        }


        public string[] Player1names { get; set; }
        public string[] Player2names { get; set; }
        public int[] Player1stats { get; set; }
        public int[] Player2stats { get; set; }

        int player1Roll;
        int player2Roll;
        int attackDamage;
        int specialDamage;
        bool isblocking = false;
        bool turnNumber = false;
        bool isoncooldown = false;
        private string[] player1names;

        private void playScreen_Load(object sender, EventArgs e)
        {
            TakeInitiative();
            playTurns(1);
        }

        public int randomRoll()//rolls dice to see which player goes first 
        {
            Random r = new Random();

            return r.Next(1, 7);
        }

        public int TakeInitiative()
        {
            player1Roll = randomRoll();
            player2Roll = randomRoll();

            if (player1Roll == player2Roll)
            {
                player1Roll = randomRoll();
                player2Roll = randomRoll();
            }
            if (player1Roll > player2Roll)
            {
                return player1Roll;
            }
            else
            {
                return player2Roll;
            }
        }

        public void playTurns(int whichplayerTURN)
        {
            if (whichplayerTURN == 1)
            {
                LBLplayername.Text = Player1names[0] + "and" + Player1names[1];
                LBLdragonHP.Text = Player1stats[0].ToString();
                LBLEnemyHp.Text = Player2stats[0].ToString();
                GBenemyPlayer.Text = Player2names[0];

            }
            else
            {
                LBLplayername.Text = Player2names[0] + "and " + Player2names[1];
                LBLdragonHP.Text = Player2stats[0].ToString();
                LBLEnemyHp.Text = Player1stats.ToString();
                GBenemyPlayer.Text = Player1names[0];
            }
        }
        public void resetTurn()
        {
            TakeInitiative();

            if (player1Roll > player2Roll)
            {
                playTurns(1);
            }
            else
            {
                playTurns(2);
            }
        }

        void attack()
        {
            if (player1Roll > player2Roll)
            {
                attackDamage = Player1stats[1];

                if (isblocking == true)
                {
                    attackDamage = attackDamage - Player1stats[3];
                    if (attackDamage < 0)
                    {
                        attackDamage = 0;
                    }
                    isblocking = false;
                }

                Player2stats[0] = Player2stats[0] - attackDamage;

                if (turnNumber == true)
                {
                    resetTurn();
                    turnNumber = false;

                }
                else
                {
                    playTurns(2);
                    turnNumber = true;
                }
            }
        }

    }


}
