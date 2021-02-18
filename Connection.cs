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
using BCrypt.Net;


namespace AppliUtraStock
{
    public partial class Connection : Form
    {
        

            public static bool hashPassword(string password, string correctHash)
            {
                return BCrypt.Net.BCrypt.Verify(password, correctHash);
            }
        

        public Connection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConnexionBdd_Click(object sender, EventArgs e)
        {
            // requete pour insserer un truc via la textbox et un bouton
            MySqlConnection conn = new MySqlConnection("database=tp_gestion_stock; server=localhost; port=3306; user id = root; pwd=");
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@nom", Message.Text);
                command.CommandText = "INSERT INTO utilisateurs (nom) VALUES (@nom)";

                if(command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("inssertion réussie");
                }
                else
                {
                    MessageBox.Show("c'est non");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Connexion échouée ...");
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            SuiviDeCommande f2 = new SuiviDeCommande();
            f2.Show();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=tp_gestion_stock; server=localhost; port=3306; user id = root; pwd=");
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@email", identifiant.Text);
                command.CommandText = "SELECT * FROM utilisateurs WHERE email=@email";
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    hashPassword(MotDePasse.Text, reader.GetString(4));
                    SuiviDeCommande page2 = new SuiviDeCommande();
                    page2.Show();
                }
                else
                {
                    MessageBox.Show("c'est non");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Connexion échouée ...");
            }
        }

        private void MotDePasse_MouseClick(object sender, MouseEventArgs e)
        {
            MotDePasse.SelectAll();
        }
    }
}
