using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method just exits the application at the end once the order is processed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
