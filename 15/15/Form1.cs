using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace _15
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUserData();
        }

        private const string filePath = "userInfo.dat";
        private UserInfo user;


        private void SaveUserData()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(user.FirstName);
                writer.Write(user.LastName);
                writer.Write(user.Age);
                writer.Write(user.Email);
            }
        }

        private void LoadUserData()
        {
            if (File.Exists(filePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    user = new UserInfo();
                    user.FirstName = reader.ReadString();
                    user.LastName = reader.ReadString();
                    user.Age = reader.ReadInt32();
                    user.Email = reader.ReadString();
                }

                // Display loaded user data
                firstNameTextBox.Text = user.FirstName;
                lastNameTextBox.Text = user.LastName;
                ageNumericUpDown.Value = user.Age;
                emailTextBox.Text = user.Email;
            }
            else
            {
                user = new UserInfo();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save user data when closing the form
            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.Age = (int)ageNumericUpDown.Value;
            user.Email = emailTextBox.Text;
            SaveUserData();
        }


        public class UserInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }

    }
}
