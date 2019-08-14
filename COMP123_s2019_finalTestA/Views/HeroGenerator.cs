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
        /// <summary>
        /// this is the event handler for the back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// this is the event handler fot the next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
        /// <summary>
        /// this is the event handler for the generatename button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }
        public void loadnames()
        {
            //creates firstname list
            var firstName = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            var firstNameList = new List<string>(firstName);

            //creates lastname list
            var lastName = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            var lastNameList = new List<string>(lastName);
        }
        /// <summary>
        /// this method randomly picks up first and last names from the list
        /// </summary>
        public void GenerateNames()
        {

            var firstName = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            var firstNameList = new List<string>(firstName);
            Random rand = new Random();
            int fname = rand.Next(firstNameList.Count);
            FirstNameDataLabel.Text = firstNameList[fname];


            var lastName = File.ReadAllLines(@"..\..\Data\lastNames.txt");
            var lastNameList = new List<string>(lastName);
            Random random = new Random();
            int lname = random.Next(lastNameList.Count);
            LastNameDataLabel.Text = lastNameList[lname];
        }
        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            loadnames();
            GenerateNames();
            LoadPowers();
        }

        /// <summary>
        /// this methodly randomly assigns value for each ability
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GenerateAbilities()
        {
            Random rand = new Random();
            FightingDataLabel.Text = (rand.Next(1, 50)).ToString();
            AgilityDataLabel.Text = (rand.Next(1, 50)).ToString();
            StrengthDataLabel.Text = (rand.Next(1, 50)).ToString();
            EnduranceDataLabel.Text = (rand.Next(1, 50)).ToString();
            ReasonDataLabel.Text = (rand.Next(1, 50)).ToString();
            IntuitionDataLabel.Text = (rand.Next(1, 50)).ToString();
            PsycheDataLabel.Text = (rand.Next(1, 50)).ToString();
            PopularityDataLabel.Text = (rand.Next(1, 50)).ToString();
        }
        /// <summary>
        /// this is the event handler that calls the GenerateAbility Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }
        /// <summary>
        /// this is the event handler to show the about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }
        /// <summary>
        /// this is the event handler to show the about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }
        /// <summary>
        /// This is the event handler to open a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            using (StreamReader inputStream = new StreamReader(File.Open("hero.txt", FileMode.Open)))
            { 
                //reading data from a file
                Program.hero.FirstName =  inputStream.ReadLine();
                //cleanup
                inputStream.Close();
                inputStream.Dispose();
                FirstNameDataLabel.Text = Program.hero.FirstName;
            }

        }
        
        /// <summary>
        /// this is the event handler to save the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
               saveFileDialog1.Title = "Save File";
               saveFileDialog1.ShowDialog();
               using (StreamWriter outputString = new StreamWriter(File.Open("HERO.txt", FileMode.Create)))
               {
                   outputString.WriteLine(Program.hero);
                   outputString.Close();
                   outputString.Dispose();
               }
        }
        /// <summary>
        /// this is the event handler for the form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeroGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this method loads powers text file to powers list
        /// </summary>
        public void LoadPowers()
        {
            var powers = File.ReadAllLines(@"..\..\Data\powers.txt");
            var powersList = new List<string>(powers);
            
        }
        /// <summary>
        /// this meth0d generates random powers
        /// </summary>
        public void GenerateRandomPowers()
        {
            var powers = File.ReadAllLines(@"..\..\Data\powers.txt");
            var powersList = new List<string>(powers);
            Random r = new Random();
            int ind1 = random.Next(powersList.Count);
            Power1DataLabel.Text = powersList[ind1];
            int ind2 = random.Next(powersList.Count);
            Power2DataLabel.Text = powersList[ind2];
            int ind3 = random.Next(powersList.Count);
            Power3DataLabel.Text = powersList[ind3];
            int ind4 = random.Next(powersList.Count);
            Power4DataLabel.Text = powersList[ind4];
        }
        /// <summary>
        /// this is the event handler to call the methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneratePowerButton_Click(object sender, EventArgs e)
        {
            LoadPowers();
            GenerateRandomPowers();
        }
    }
}


