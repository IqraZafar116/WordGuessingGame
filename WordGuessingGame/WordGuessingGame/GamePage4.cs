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
    public partial class GamePage4 : Form
    {
        public GamePage4()
        {
            InitializeComponent();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
        }

        private void GamePage4_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            HomePage my = new HomePage();
            my.Show();
        }
    }
}