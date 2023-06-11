using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        OpenFileDialog openFile = new OpenFileDialog();
        string path;


        private void BackToMain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Save saveClass = new Save();
            bool bl = false;
            string id = "";
            while(!bl)
            {
                while(id.Length<11)
                {
                    id = id + Convert.ToString(random.Next(10));
                }
                if(!saveClass.listIds().Contains(id))
                {
                    bl = true;
                    saveClass.listIds().Add(id);
                }
            }

            Save donnors = new Save(id, nameBox.Text, surnameBox.Text, socialIdBox.Text,
                phoneNumberBox.Text, emailBox.Text, bloodTypeBox.Text, date.Text);

            SaveFiles.file(donnors, path);
            MessageBox.Show("Its ok");

            nameBox.Text = string.Empty;
            surnameBox.Text = string.Empty;
            socialIdBox.Text = string.Empty;
            phoneNumberBox.Text = string.Empty;
            emailBox.Text = string.Empty;
            

        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
            string imagePath = openFile.FileName.ToString();
            string imagePath1 = imagePath.ToString();
            string imagePath2 = imagePath1.Substring(imagePath1.LastIndexOf("\\"));
            string imagePath3 = imagePath2.Remove(0, 1);
        }

       
    }
}
