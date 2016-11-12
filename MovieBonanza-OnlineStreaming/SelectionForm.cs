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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method creates and sends you to the OrderForm once the next Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This method determines if the ListBoxMovies is selected and makes the next button accessible or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxMovies.Focused == true)
            {
                ButtonNext.Enabled = true;
            }
            else
            {
                ButtonNext.Enabled = false;
            }
        }
    }
}
