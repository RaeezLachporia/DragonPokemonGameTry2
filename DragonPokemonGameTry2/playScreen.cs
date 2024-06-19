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
        public playScreen(string[] p1Data, int[] p1Values, string[] p2Data, int[] p2Values)
        {
            //pulled the arrays from the previous form into the current one
            InitializeComponent();
            Player1names = p1Data;
            Player2names = p2Data;
            Player1stats = p1Values;
            Player2stats = p2Values;
        }


        public string[] Player1names;
        public string[] Player2names;
        public int[] Player1stats;
        public int[] Player2stats;
        //declaring new variables t be used within the current form 
        int player1Roll;
        int player2Roll;
        int attackDamage;
        int specialDamage;
        bool isblocking = false;
        bool turnNumber = false;
        bool isoncooldown = false;
        private string[] player1names;

        private void playScreen_Load(object sender, EventArgs e)//what happens when the from loads 
        {
            TakeInitiative();
            BTNRest.Hide();
            if (player1Roll > player2Roll)
            {
                playTurns(1);
            }
            else
            {
                playTurns(2);
            }
        }

        public int randomRoll()//rolls dice to see which player goes first 
        {
            Random r = new Random();

            return r.Next(1, 7);
        }

        public int TakeInitiative()//this method determines which player gets to go first 
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

        public void playTurns(int whichplayerTURN) //this method determines who is the active player within the form 
        {
            if (whichplayerTURN == 1)
            {
                GBActivePlayer.Text = "Its your turn";
                LBLplayername.Text = Player1names[0] + " and " + Player1names[1];
                LBLdragonHP.Text = "HP: " + Player1stats[0].ToString();
                LBLEnemyHp.Text = Player2stats[0].ToString();
                GBenemyPlayer.Text = Player2names[0];
                TXTbattlelog.Text = "It is " + Player1names[0] + "'s" + " turn";
            }
            else if (whichplayerTURN == 2)
            {
                GBActivePlayer.Text = "Its your turn ";
                LBLplayername.Text = Player2names[0] + " and " + Player2names[1];
                LBLdragonHP.Text = Player2stats[0].ToString();
                LBLEnemyHp.Text = Player1stats[0].ToString();
                GBenemyPlayer.Text = Player1names[0];
                TXTbattlelog.Text = "It is " + Player2names[0] + "'s" + " turn";
            }
        }
        public void resetTurn()//this method resets the turns and switches between the active players
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

        void attack()//this method controls the attack function linked to the attack button
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
                TXTbattlelog.Text += "\n" + Player2names[0] + "Has taken" + attackDamage + "damage points" + "\n";
            }
            else
            {
                attackDamage = Player2stats[1];
                if (isblocking == true)
                {
                    attackDamage = attackDamage - Player2stats[3];
                    if (attackDamage < 0)
                    {
                        attackDamage = 0;
                    }
                    isblocking = false;
                }

                Player1stats[0] = Player1stats[0] - attackDamage;

                TXTbattlelog.Text += "\n" + Player1names[0] + "Has taken " + attackDamage + "damage points " + "\n";
                if (turnNumber == true)
                {
                    resetTurn();
                    turnNumber = false;
                }
                else
                {
                    playTurns(1);
                    turnNumber = true;
                }
            }
        }

        void block() //method used to tell if a player is blocking and acts accordingly 
        {
            if (player1Roll > player2Roll)
            {
                isblocking = true;
                if (turnNumber == true)
                {
                    turnNumber = false;
                    isblocking = false;
                }

                else
                {
                    playTurns(2);
                    turnNumber = true;
                }
            }
            else
            {
                isblocking = true;

                if (turnNumber == true)
                {
                    resetTurn();
                    turnNumber = false;
                    isblocking = false;
                }
                else
                {
                    playTurns(2);
                    turnNumber = true;
                }
            }


        }

        void SpecialAttack()//this method is used to control the fuctions for the special attack button
        {
            if (player1Roll > player2Roll)
            {
                specialDamage = Player1stats[2];
                Player2stats[0] = Player2stats[0] - specialDamage;

                if (isblocking == true)
                {
                    specialDamage = specialDamage - Player2stats[3];

                    if (specialDamage < 0)
                    {
                        specialDamage = 0;
                    }
                    isblocking = false;
                }
                isblocking = false;

                isoncooldown = true;

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
                TXTbattlelog.Text = (Player1names[0] + " has used their special attack");
            }
            else
            {
                specialDamage = Player2stats[2];
                Player1stats[0] = Player1stats[0] - specialDamage;
                if (isblocking == true)
                {
                    specialDamage = specialDamage - Player2stats[3];
                    if (specialDamage < 0)
                    {
                        specialDamage = 0;
                    }
                    isblocking = false;

                    isoncooldown = true;
                    if (turnNumber == true)
                    {
                        resetTurn();
                        turnNumber = false;
                    }
                    else
                    {
                        playTurns(1);
                        turnNumber = true;
                    }
                    TXTbattlelog.Text = (Player2names[0] + " has used their special attack");
                }
            }
        }

        private void BTNattack_Click(object sender, EventArgs e)
        {
            attack();
        }

        private void BTNspecial_Click(object sender, EventArgs e)
        {
            SpecialAttack();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            block();
        }

        void Victory()
        {
            if (Player1stats[0] <= 0)
            {
                TXTbattlelog.Text = Player2names[0] + " Is the winner of the fight!";
                BTNattack.Enabled = false;
                btnBlock.Enabled = false;
                BTNspecial.Enabled = false;

                this.Hide();
                PlayerInfoScreen pinfo = new PlayerInfoScreen();
                pinfo.Show();
            }
            else if (Player2stats[0] <= 0)
            {
                TXTbattlelog.Text = Player1names[0] + " is the winner of the fight!";
                BTNattack.Enabled = false;
                btnBlock.Enabled = false;
                BTNspecial.Enabled = false;
                this.Hide();
                PlayerInfoScreen pinfo = new PlayerInfoScreen();
                pinfo.Show();
            }
        }

        void Resting(bool isresting)
        {
            if (player1Roll > player2Roll & isresting == true)
            {
                if (isoncooldown == true)
                {
                    BTNRest.Show();
                    btnBlock.Enabled = false;
                    BTNattack.Enabled = false;
                    BTNspecial.Enabled = false;
                }
                else
                {
                    playTurns(2);
                }
            }
            else
            {
                if (isoncooldown == true)
                {
                    BTNRest.Show();
                    btnBlock.Enabled = false;
                    BTNattack.Enabled = false;
                    BTNspecial.Enabled = false;
                }
                else
                {
                    playTurns(1);
                }
            }

        }
    }





}
