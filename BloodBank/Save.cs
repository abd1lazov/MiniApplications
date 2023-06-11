using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Save
    {
        string id;
        string name;
        string surname;
        string socialID;
        string phoneNumber;
        string email;
        string bloodType;
        string donationDate;

        private static List<string> list = new List<string>();

        public Save()
        {
            list.Add("ID");
        }

        public Save(string id, string name, string surname, string socialID, string phoneNumber, 
            string email, string bloodType, string donationDate)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.socialID = socialID;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.bloodType = bloodType;
            this.donationDate = donationDate;
        }

        public Save(string id, string text1, string text2, string text3, string text4, string text5, string text6)
        {
            this.id = id;
        }

        public List<string> listIds()
        {
            return list;
        }

        public string getID() { return id; }
        public string getName() { return name; }
        public string getSurname() { return surname; }
        public string getSocialID() { return socialID; }
        public string getPhoneNumber() { return phoneNumber; }
        public string getEmail() { return email; }
        public string getBloodType() { return bloodType; }
        public string getDonationDate() { return donationDate; }
    }
}
