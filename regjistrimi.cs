using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace atm
{
    public partial class regjistrimi : Form
    {
        public regjistrimi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void RegjistrohuR_Click(object sender, EventArgs e)
        {
            float bilanci = 0.0f;

            if (Emri.Text == "" || Mbiemri.Text == "" || pinR.Text == "" || CVC.Text == "" || ibanR.Text == "")
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into perdoruesit values('" + Emri.Text + "','" + Mbiemri.Text + "','" + ibanR.Text + "','" + pinR.Text + "," + CVC.Text + "," + bilanci + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Regjistrimi u krye me sukses");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
