using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using COMP123_s2019_finalTestA.Objects;
/*
 * Student Name: Ishneet Kaur
 * Student ID: 301045264
 * Description: This is the Hero Generator Form
 */
namespace COMP123_s2019_finalTestA.Views
{
    public partial class HeroGenerator : COMP123_s2019_finalTestA.Views.MasterForm
    {
        Hero hero;
        Random random = new Random();
        public HeroGenerator()
        {
            InitializeComponent();
            hero = new Hero();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex!= 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count -1 )
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }
        public void loadnames()
        {
            //Inputing First Name
            var firstName = File.ReadAllLines("firstNames.txt");
            var firstNameList = new List<string>(firstName);

            //Inputing Last Name
            var lastName = File.ReadAllLines("lastNames.txt");
            var lastNameList = new List<string>(lastName);
        }
        public void GenerateNames()
        {
            //Inputing First Name
            var firstName = File.ReadAllLines("firstNames.txt");
            var firstNameList = new List<string>(firstName);
            Random rand = new Random();
            int index = rand.Next(firstNameList.Count);
            FirstNameDataLabel.Text = firstNameList[index];

            //Inputing Last Name
            var lastName = File.ReadAllLines("lastNames.txt");
            var lastNameList = new List<string>(lastName);
            Random random = new Random();
            int indexs = random.Next(lastNameList.Count);
            LastNameDataLabel.Text = lastNameList[indexs];
        }
        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            loadnames();
            GenerateNames();
        }
    }
}


/*
 public void loadnames()
        {
            //Inputing First Name
            var firstName = File.ReadAllLines("firstNames.txt");
            var firstNameList = new List<string>(firstName);

            //Inputing Last Name
            var lastName = File.ReadAllLines("lastNames.txt");
            var lastNameList = new List<string>(lastName);
        }

        public void GenerateNames()
        {
            //Inputing First Name
            var firstName = File.ReadAllLines("firstNames.txt");
            var firstNameList = new List<string>(firstName);
            Random rand = new Random();
            int index = rand.Next(firstNameList.Count);
            FirstNameDataLabel.Text = firstNameList[index];

            //Inputing Last Name
            var lastName = File.ReadAllLines("lastNames.txt");
            var lastNameList = new List<string>(lastName);
            Random random = new Random();
            int indexs = random.Next(lastNameList.Count);
            LastNameDataLabel.Text = lastNameList[indexs];
        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            loadnames();
            GenerateNames();
        }
    }*/
