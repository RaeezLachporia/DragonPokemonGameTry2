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
    public partial class playScreen : Form
    {
        public playScreen()
        {
            InitializeComponent();
        }
        public string[] player1names {  get; set; }
        public string[] player2names { get; set; }
        public int[] player1stats { get; set; }
        public int [] player2stats { get; set; }
        private void playScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
