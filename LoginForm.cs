using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Fast_Sushi_2
{
    public partial class LoginForm : Form
    {
        private DataAccess db;
        public LoginForm()
        {
            InitializeComponent();

            //Créer une instance de la classe DataAccess avec nos informations de connexion à la base de données
            db = new DataAccess("192.168.3.30", "slam3", "slam3", "_v6z7DAvWx");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = db.GetConnection();
            if (conn != null)
            {

                string query = "SELECT mot_de_passe FROM utilisateurs WHERE id=37";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string mdp_hashe = reader.GetString("mot_de_passe");
                    mdp_hash.Text = mdp_hashe;
                }
                reader.Close();
            }
            Titre.Text = "Page de connexion au logiciel Fast Sushi";
        }

        private bool CheckCredentials(string nom, string mot_de_passe)
        {
            MySqlConnection connection = db.GetConnection();
            if (connection != null)
            {
                string query = "SELECT COUNT(*) FROM utilisateurs WHERE nom = @nom AND mot_de_passe = @mot_de_passe";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@mot_de_passe", mot_de_passe);

                int count = Convert.ToInt32(command.ExecuteScalar());

                //connection.Close();

                return count > 0;
            }

            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string nom = txtUsername.Text;
            string mot_de_passe = txtPassword.Text;

            // Vérifie les informations d'identification
            if (CheckCredentials(nom, mot_de_passe))
            {
                int utilisateurid = ObtenirUtilisateurId(nom, mot_de_passe);
                if (utilisateurid != null)
                {
                    //on stocke l'id de l'utilisateur qui vient de se connecter dans une variable globale
                    GlobalValues.UtilisateurId = utilisateurid;
                    MessageBox.Show(GlobalValues.UtilisateurId.ToString());
                    //créer une nouvelle instance de la fenêtre de destination
                    Accueil accederAccueil = new Accueil();

                    //on affiche la nouvelle fenêtre et on cache l'actuelle
                    accederAccueil.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("échec de la connexion. veuillez vérifier vos informations d'identification.");
            }
        }
            //Récupération de l'identifiant via le nom et le mot de passe
            private int ObtenirUtilisateurId(string nom, string mot_de_passe)
        {
            MySqlConnection connection = db.GetConnection();
            if (connection != null)
            {
                string query = "SELECT id FROM utilisateurs WHERE nom = @nom AND mot_de_passe = @mot_de_passe";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@mot_de_passe", mot_de_passe);

                object result = command.ExecuteScalar();
                int utilisateurId = result != null ? Convert.ToInt32(result) : 0;

                connection.Close();

                return utilisateurId;
            }

            return 0;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdp_hash_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Titre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}