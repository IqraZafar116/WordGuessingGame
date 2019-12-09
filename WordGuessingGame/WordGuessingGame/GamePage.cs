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
    public partial class GamePage : Form
    {
        private string dashdoword;
        private string randword;
        List<char> userInputList = new List<char>();
        private int counter = 0;
        void updateRandWord()
        {

            foreach (char x in userInputList)
            {
                char[] dashArray = dashdoword.ToCharArray();
                for (int i = 0; i < randword.Length; i++)
                {
                    if (randword[i] == x)
                    {
                        dashArray[i] = x;
                    }
                }
                dashdoword = "";
                dashdoword = new string(dashArray);
            }
        }
        public GamePage()
        {
            InitializeComponent();
        }

        public GamePage(string dashdoword)
        {
            InitializeComponent();
            this.dashdoword = dashdoword;
        }

        public GamePage(string dashdoword, string randword) : this(dashdoword)
        {
            this.randword = randword;
        }

        private void GamePage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            label1.Text = dashdoword;
            //MessageBox.Show(randword);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
        }

        private void button_click(object sender, EventArgs e)
        {
            string preWordDashed = dashdoword;
            Button button = (Button)sender;
            userInputList.Add(Convert.ToChar(button.Text.ToUpper()));
            updateRandWord();
            string AfterWordDashed = dashdoword;
            label1.Text = dashdoword;
            if (preWordDashed != AfterWordDashed)
                button.BackColor = Color.Green;
            else
            {
                button.BackColor = Color.Red;
                counter = counter + 1;
                if (counter < imageList1.Images.Count)
                {
                    pictureBox1.Image = imageList1.Images[counter];
                }
                else
                {
                    MessageBox.Show(randword);
                    GamePage4 losePage = new GamePage4();
                    losePage.Show();
                    this.Close();
                }
            }
            if (counter == imageList1.Images.Count)
            {
                GamePage3 gamepage = new GamePage3();
                gamepage.Show();
                this.Close();
            }
        }
    }
}
