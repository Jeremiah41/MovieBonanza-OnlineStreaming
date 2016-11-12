using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_OnlineStreaming
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

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

        private void ButtonStream_Click(object sender, EventArgs e)
        {
            StreamForm newStreamForm = new StreamForm();
            newStreamForm.Show();
            this.Hide();

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            SelectionForm startForm = new SelectionForm();
            startForm.Show();
            this.Hide();
        }
    }
}
