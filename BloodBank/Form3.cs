using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace project2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public List<string> donors = new List<string>();
        int btn = 1;
        int currentPage = 1;
        int page;

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Form3_Load(object sender, System.EventArgs e)
        {
            if(currentPage == page)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            if(currentPage ==1)
            {
                button4.Enabled = false;
                if(currentPage != page)
                {
                    button3.Enabled=true;
                }
            }
            if(currentPage == page)
            {
                button3.Enabled = false;
                button4.Enabled = true;
            }
            if(currentPage == page)
            {
                button2.Enabled = false;
            }

            donors = SaveFiles.list();

            page = donors.Count / 10;

            Save save = new Save(donors[btn], donors[btn +1 ], donors[+2], donors[+3],
                donors[+4], donors[+5], donors[6], donors[+7]);

            label5.Text = save.getID();
            label4.Text = save.getName();
            label13.Text = save.getSurname();
            label14.Text = save.getSocialID();
            label15.Text = save.getPhoneNumber();
            label16.Text = save.getEmail();
            label17.Text = save.getBloodType();
            label18.Text = save.getDonationDate();
            label2.Text = $"{currentPage}/{page}";


        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            btn += 10;
            currentPage++;
            Form3_Load(sender, e);
              
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            btn -= 10;
            currentPage--;
            Form3_Load(sender, e);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string filePath = "donnor.txt";
            List<int> linesToDelete = new List<int>();

            for (int num = currentPage; num <= page + 9; num++)
            {
                linesToDelete.Add(num);
            }

            string tempFilePath = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(filePath))
            using (StreamWriter writer = new StreamWriter(tempFilePath))
            {
                int lineNumber = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    if (!linesToDelete.Contains(lineNumber))
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            File.Delete(filePath); 
            File.Move(tempFilePath, filePath);
            page--;
            Form3_Load(sender, e);
        }
    }
}
