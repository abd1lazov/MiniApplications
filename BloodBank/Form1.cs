using System;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void AllRecords_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
