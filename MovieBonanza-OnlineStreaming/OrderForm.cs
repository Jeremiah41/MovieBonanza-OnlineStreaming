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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// If the check box for DVD is checked off this makes the DVDLabel and TextBox Visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxDVD_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDVD.Checked == true)
            {
                LabelDVD.Visible = true;
                TextBoxDVD.Visible = true;
            }
            else
            {
                LabelDVD.Visible = false;
                TextBoxDVD.Visible = false;
            }
        }
        /// <summary>
        /// When the stream button is clicked this creates and sends you to that form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStream_Click(object sender, EventArgs e)
        {
            StreamForm newStreamForm = new StreamForm();
            newStreamForm.Show();
            this.Hide();

        }
        /// <summary>
        /// This exits the application when the ButtonCancel is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This sends you back to the SelectionForm if you want to chose another movie!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            SelectionForm startForm = new SelectionForm();
            startForm.Show();
            this.Hide();
        }
    }
}
