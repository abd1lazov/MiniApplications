using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class SaveFiles
    {
        public static void file(Save person, string imagePath)
        {
            FileStream fileStream = new FileStream("Donnor.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStream);

            
            sw.WriteLine(person.getID());
            sw.WriteLine(person.getName());
            sw.WriteLine(person.getSurname());
            sw.WriteLine(person.getSocialID());
            sw.WriteLine(person.getPhoneNumber());
            sw.WriteLine(person.getEmail());
            sw.WriteLine(person.getBloodType());
            sw.WriteLine(person.getDonationDate());
            sw.WriteLine(imagePath);

            sw.Close();
            fileStream.Close();
        }
        public static List<string> list()
        {
            List<string> list = new List<string>();

            using (StreamReader sr = new StreamReader("Donnor.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            return list;
        }
    }
}
