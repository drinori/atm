using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace atm
{
    public partial class deponim : Form
    {
        public deponim()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\ATM.mdf;Integrated Security=True;Connect Timeout=30";

        private void button2_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox1.Text);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat");
                return;
            }



        }


    }
}