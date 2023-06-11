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
    public partial class Form2 : Form
    {
        Random random = new Random();
        List<string> list = new List<string>()
        {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"
        };

        Label firstClicked, secondClicked;
        int seconds = 0;
        public Form2 ()
        {
            InitializeComponent();
            playerName.Text = Form1.firstName;
            livesLeft.Text = Form1.nOfLives;
            Text = Form1.nTiles;
            Text = Form1.boSize;
            Text = Form1.showTime;
            AssignIcons();
        }

        private void AssignIcons()
        {
            Label label;
            int randomNumber;

            for(int i = 0; i<tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomNumber = random.Next(0, list.Count);
                label.Text = list[randomNumber];
                list.RemoveAt(randomNumber);
            }
        }

        int bSize = int.Parse(Form1.boSize.ToString());


        private void backToMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void startPlaying_Click(object sender, EventArgs e)
        {
            seconds = 0;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = seconds++.ToString();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label clickedable = sender as Label;
            
            if(clickedable==null)
                return;
            if (clickedable.ForeColor == Color.Black)
                return;

            if(firstClicked == null)
            {
                firstClicked = clickedable;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedable;
            secondClicked.ForeColor = Color.Black;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            float w = 100f / (831 - 212);
            float h = 100f / 664;

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();


            for (int i = 0; i < bSize; i++) {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, w));
            }
            for (int i = 0; i < bSize; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, h));
            }
            tableLayoutPanel1.ColumnCount = bSize;
            tableLayoutPanel1.RowCount = bSize;
        }
    }
}
