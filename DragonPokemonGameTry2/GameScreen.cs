﻿using System;
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
    public partial class GameScreen : Form
    {
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

        }
    }
}
