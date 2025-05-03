using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class menu : Form
    {
        private Label labelWelcome;

        // Constructor for menu class to receive 'emri' and set the label
        public menu(string emri)
        {
            InitializeComponent();

            // Set up the label or any other control to display the welcome message
            labelWelcome.Text = $"Miresevini, {emri}";
        }


        private void qkyqu_Click(object sender, EventArgs e)
        {
            dashboard qkyqu = new dashboard();
            qkyqu.Show();
            this.Hide();
        }
    }


    // Other code for your menu form...
}

