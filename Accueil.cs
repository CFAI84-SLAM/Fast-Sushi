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

namespace Fast_Sushi_2
{
    public partial class Accueil : Form
    {
        private DataAccess db;
        public Accueil()
        {
            InitializeComponent();

            //Créer une instance de la classe DataAccess avec nos informations de connexion à la base de données
            db = new DataAccess("192.168.3.30", "slam3", "slam3", "_v6z7DAvWx");

            //On stocke l'id de l'utilisateur connecté
            int utilisateurId = GlobalValues.UtilisateurId;

            string RecupInfos(int id)
            {
                MySqlConnection conn = db.GetConnection();
                if (conn != null)
                {
                    string query = "SELECT * FROM utilisateurs WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //Récupère les infos de l'utilisateur
                            string nom = reader.GetString("nom");
                            string prenom = reader.GetString("prenom");

                            string NomPrenom = $"{nom}\n{prenom}";

                            return NomPrenom;
                        }
                    }
                }

                return string.Empty;//Retourne chaîne vide si aucune info trouvée
            }

            MessageBox.Show(RecupInfos(utilisateurId));

            Utilisateur.Text = "Vous êtes connectés en tant que : " + RecupInfos(utilisateurId);
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void Utilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
