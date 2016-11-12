using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// App name: Movie Bonanza
/// Author's Name: Jeremiah Hughes
/// Student ID: 200318676
/// App Creation Date: 2016/11/11
/// App Description:This is a movie streaming app that lets you decide on a movie to watch with the availability to buy.(Not COmpletly functional)
/// </summary>
namespace MovieBonanza_OnlineStreaming
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method shows the Splash screen for 3 seconds, creates the SelectionForm Hiding the splash screen and showing the selectionForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            
            SplashFormTimer.Enabled = false;

            SelectionForm startForm = new SelectionForm();
            startForm.Show();
            this.Hide();
        }
    }
}
