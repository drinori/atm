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

        public menu(string emri)
        {
            InitializeComponent();

            labelWelcome.Text = $"Miresevini, {emri}";
        }


        private void qkyqu_Click(object sender, EventArgs e)
        {
            dashboard qkyqu = new dashboard();
            qkyqu.Show();
            this.Hide();
        }

        private void deponim_Click(object sender, EventArgs e)
        {
            deponim deponim = new deponim();
            deponim.Show();
            this.Hide();
        }
    }

}

