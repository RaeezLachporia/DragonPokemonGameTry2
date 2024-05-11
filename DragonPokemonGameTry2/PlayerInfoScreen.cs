using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonPokemonGameTry2
{
    public partial class PlayerInfoScreen : Form
    {
        String[] P1data = new string[2];
        String[] P2data = new string[2];
        int[] P1values = new int[4];
        int[] P2values = new int[4];

        //ice dragon constants
        const String ICE_DRAG_NAME = " ";
        const int ICE_DRAG_HP = 30;
        const int ICE_DRAG_ATTACK = 4;
        const int ICE_DRAG_SPECIAL = 9;
        const int ICE_DRAG_BLOCK = 5;

        //fire dragon constants
        const String FIRE_DRAG_NAME = " ";
        const int FIRE_DRAG_HP = 20;
        const int FIRE_DRAG_ATTACK = 5;
        const int FIRE_DRAG_SPECIAL = 12;
        const int FIRE_DRAG_BLOCK = 4;

        //wind dragon constants
        const String WIND_DRAG_NAME = " ";
        const int WIND_DRAG_HP = 40;
        const int WIND_DRAG_ATTACK = 3;
        const int WIND_DRAG_SPECIAL = 7;
        const int WIND_DRAG_BLOCK = 5;

        //earth dragon constants
        const String EARTH_DRAG_NAME = " ";
        const int EARTH_DRAG_HP = 50;
        const int EARTH_DRAG_ATTACK = 2;
        const int EARTH_DRAG_SPECIAL = 5;
        const int EARTH_DRAG_BLOCK = 6;
        public PlayerInfoScreen()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GBP1details_Enter(object sender, EventArgs e)
        {

        }

        private void BTNP1Details_Click(object sender, EventArgs e)
        {
            saveP1values();
        }

        public void saveP1values()
        {
            if (checkboxP1fire.Checked == true)
            {
                P1data[0] = TXTPlayer1Name.Text;
                P1data[1] = TXTPlayer1DragonName.Text;

                P1values[0] = FIRE_DRAG_HP;
                P1values[1] = FIRE_DRAG_ATTACK;
                P1values[2] = FIRE_DRAG_SPECIAL;
                P1values[3] = FIRE_DRAG_BLOCK;
            }
            else if (checkBoxP1Water.Checked == true)
            {
                P1data[0] = TXTPlayer1Name.Text;
                P1data[1] = TXTPlayer1DragonName.Text;

                P1values[0] = ICE_DRAG_HP;
                P1values[1] = ICE_DRAG_ATTACK;
                P1values[2] = ICE_DRAG_SPECIAL;
                P1values[3] = ICE_DRAG_BLOCK;
            }
            else if (checkBoxP1Wind.Checked == true)
            {
                P1data[0] = TXTPlayer1Name.Text;
                P1data[1] = TXTPlayer1DragonName.Text;

                P1values[0] = WIND_DRAG_HP;
                P1values[1] = WIND_DRAG_ATTACK;
                P1values[2] = WIND_DRAG_SPECIAL;
                P1values[3] = WIND_DRAG_BLOCK;
            }
            else if (checkBoxP1Earth.Checked == true)
            {
                P1data[0] = TXTPlayer1Name.Text;
                P1data[1] = TXTPlayer1DragonName.Text;

                P1values[0] = EARTH_DRAG_HP;
                P1values[1] = EARTH_DRAG_ATTACK;
                P1values[2] = EARTH_DRAG_SPECIAL;
                P1values[3] = EARTH_DRAG_BLOCK;
            }
        }
        public void saveP2values()
        {
            if (checkBoxP2Fire.Checked == true)
            {
                P2data[0] = TXTPlayer2Name.Text;
                P2data[1] = TXTPlayer2DragonName.Text;

                P2values[0] = FIRE_DRAG_HP;
                P2values[1] = FIRE_DRAG_ATTACK;
                P2values[2] = FIRE_DRAG_SPECIAL;
                P2values[3] = FIRE_DRAG_BLOCK;
            }
            else if (checkBoxP2Water.Checked == true)
            {
                P2data[0] = TXTPlayer2Name.Text;
                P2data[1] = TXTPlayer2DragonName.Text;

                P2values[0] = ICE_DRAG_HP;
                P2values[1] = ICE_DRAG_ATTACK;
                P2values[2] = ICE_DRAG_SPECIAL;
                P2values[3] = ICE_DRAG_BLOCK;
            }
            else if (checkBoxP2Wind.Checked == true)
            {
                P2data[0] = TXTPlayer2Name.Text;
                P2data[1] = TXTPlayer2DragonName.Text;

                P2values[0] = WIND_DRAG_HP;
                P2values[1] = WIND_DRAG_ATTACK;
                P2values[2] = WIND_DRAG_SPECIAL;
                P2values[3] = WIND_DRAG_BLOCK;
            }
            else if (checkBoxP2Earth.Checked == true)
            {
                P2data[0] = TXTPlayer2Name.Text;
                P2data[1] = TXTPlayer2DragonName.Text;

                P2values[0] = EARTH_DRAG_HP;
                P2values[1] = EARTH_DRAG_ATTACK;
                P2values[2] = EARTH_DRAG_SPECIAL;
                P2values[3] = EARTH_DRAG_BLOCK;
            }
        }

        private void BTNP2Details_Click(object sender, EventArgs e)
        {
            saveP2values();
        }
    }
}
