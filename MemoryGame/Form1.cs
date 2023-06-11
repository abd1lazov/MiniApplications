using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string name = "", diff = "", firstName = "", nOfLives = "", boSize = "", showTime = "", nTiles = "";
        private void startGame_Click(object sender, EventArgs e)
        {
            firstName = nameBox.Text;
            nOfLives = liveSize.Text;
            boSize = boardSize.Text;
            showTime = showSize.Text;
            nTiles = numberSize.Text;

            int bSize = int.Parse(boardSize.Text);
            int numberOfTiles = int.Parse(numberSize.Text);
           
            if (nameBox.Text.Length == 0 || (bSize * bSize) < numberOfTiles)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                name = Convert.ToString(nameBox.Text);
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void difficultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            diff = Convert.ToString(difficultyBox.Text);
            if (diff == "Easy")
            {
                boardSize.Text = "3";
                boardSize.Enabled = false;
                numberSize.Text = "5";
                numberSize.Enabled = false;
                liveSize.Text = "3";
                liveSize.Enabled = false;
                showSize.Text = "3";
                showSize.Enabled = false;
            }
            else if (diff == "Medium")
            {
                boardSize.Text = "6";
                boardSize.Enabled = false;
                numberSize.Text = "4";
                numberSize.Enabled = false;
                liveSize.Text = "2";
                liveSize.Enabled = false;
                showSize.Text = "2";
                showSize.Enabled = false;
            }
            else if (diff == "Hard") {
                boardSize.Text = "9";
                boardSize.Enabled = false;
                numberSize.Text = "3";
                numberSize.Enabled = false;
                liveSize.Text = "1";
                liveSize.Enabled = false;
                showSize.Text = "1";
                showSize.Enabled = false;
                numberSize.Text = "7";
            }
            else
            {
                boardSize.Text = "";
                boardSize.Enabled = true;
                numberSize.Text = "";
                numberSize.Enabled = true;
                liveSize.Text = "";
                liveSize.Enabled = true;
                showSize.Text = "";
                showSize.Enabled = true;
                numberSize.Text = "";
                numberSize.Enabled = true;
            }
        }
    }
}
