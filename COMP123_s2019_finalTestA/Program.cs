using COMP123_s2019_finalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_s2019_finalTestA.Objects;
/*
 * Student Name: Ishneet Kaur
 * Student ID: 301045264
 * Description: This is the program.cs file
 */
namespace COMP123_s2019_finalTestA
{
    static class Program
    {
        public static HeroGenerator heroGenerator;
        public static MasterForm masterForm;
        public static SplashForm splashForm;
        public static aboutForm aboutForm;
        public static Hero hero;
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();
            masterForm = new MasterForm();
            splashForm = new SplashForm();
            aboutForm = new aboutForm();
            hero = new Hero();
      
            Application.Run(splashForm);
        }
    }
}
