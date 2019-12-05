using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessingGame
{
    public partial class GamePage3 : Form
    {
        public GamePage3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePage gamepage = new GamePage();
            gamepage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
