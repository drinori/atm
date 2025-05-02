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

namespace atm
{
    public partial class kyqja : Form
    {
        public kyqja()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\ATM.mdf;Integrated Security=True;Connect Timeout=30";

        private void Kyqu_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM perdoruesit WHERE iban = @Iban AND pin = @Pin";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Iban", textBox1.Text);
                    command.Parameters.AddWithValue("@Pin", textBox2.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // string emri = reader["emri"].ToString();
                        // labelWelcome.Text = "Miresevini, " + emri;
                        // User found, proceed to the next form
                        menu menu = new menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Iban ose PIN i gabuar.");
                    }
                }
            }
        }
    }
}
