using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Student Name: Ishneet Kaur
 * Student ID: 301045264
 * Description: This is the Splash Form
 */

namespace COMP123_s2019_finalTestA.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;

            Program.heroGenerator.Show();
            this.Hide();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
