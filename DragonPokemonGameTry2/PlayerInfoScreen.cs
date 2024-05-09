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
        String[] P1data;
        String[] P2data;
        int[] P1values;
        int[] P2values;

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

        public bool saveP1values()
        {
            bool isp1Saved = false;
            return true;
        }
    }
}
