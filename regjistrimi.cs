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
using System.Data.SqlClient;

namespace atm
{
    public partial class regjistrimi : Form
    {
        public regjistrimi()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\ATM.mdf;Integrated Security=True;Connect Timeout=30";

        private void RegjistrohuR_Click(object sender, EventArgs e)
        {
            float bilanci = 0.0f;

            // Validate input fields
            if (Emri.Text == "" || Mbiemri.Text == "" || pinR.Text == "" || CVC.Text == "" || ibanR.Text == "")
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat");
                return;
            }


                // Validate numeric inputs
                if (!int.TryParse(pinR.Text, out int pin) || !int.TryParse(CVC.Text, out int cvc))
                {
                    MessageBox.Show("PIN dhe CVC duhet të jenë numra.");
                    return;
                }

                string insertQuery = "INSERT INTO perdoruesit (emri, mbiemri, iban, pin, cvc, bilanci) " +
                                  "VALUES (@Emri, @Mbiemri, @Iban, @Pin, @Cvc, @Bilanci)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     using (SqlCommand command = new SqlCommand(insertQuery, connection))
                     {
                         // Bind form data to SQL parameters
                         command.Parameters.AddWithValue("@Emri", Emri.Text);
                         command.Parameters.AddWithValue("@Mbiemri", Mbiemri.Text);
                         command.Parameters.AddWithValue("@Iban", ibanR.Text);
                         command.Parameters.AddWithValue("@Pin", pin);
                         command.Parameters.AddWithValue("@Cvc", cvc);
                         command.Parameters.AddWithValue("@Bilanci", bilanci);

                         try
                         {
                             connection.Open();
                             int rowsAffected = command.ExecuteNonQuery();
                             MessageBox.Show("Regjistrimi u krye me sukses!");
                             // kycja kycja = new kycja();
                             // kycja.Show();
                             // this.Hide();
                             connection.Close();
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show("Gabim gjatë regjistrimit: " + ex.Message);
                         }
                     }
                 }
            }

        }
    }
