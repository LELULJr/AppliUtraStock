using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppliUtraStock
{
    public partial class SuiviDeCommande : Form
    {
        public SuiviDeCommande()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=tp_gestion_stock; server=localhost; port=3306; user id = root; pwd=");
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@email", Num.Text);
                command.CommandText = "SELECT email FROM utilisateurs WHERE email = @email";

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string valeur = reader.GetString(0);
                    label2.Text = valeur;
                    label3.Text = valeur;
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Connexion échouée ...");
            }
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            {
                Connection.ActiveForm.Show(); //retour
                this.Close();
            }

        }
    }
}
