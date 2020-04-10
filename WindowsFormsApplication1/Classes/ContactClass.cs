using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class ContactClass
    {
        // Ici je vais créer les Get et les SET
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Numero { get; set; }
        public string Adresse { get; set; }
        public int Genre { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        // On va récuper les élement de la base de donnée 

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Employe";
              //SqlCommand cmd = new SqlCommand(sql, cmd);
              //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
               //dapter.Fill(dt);
            }
            catch (Exeption)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Insertion des données

        public bool Insert(ContactClass c)
        {
            //Création du type par défault des données  ( Vrai ou faux )
            bool isSuccess = false;

            //Connection à la base de données 
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // On va créer la requete qui nous permet d'inserer des donnée dans la base de données .
                string sql = "INSERT INTO Employe (Nom,Prenom,Numero,Adresse) VALUES(@Nom,@Prenom,@Numero,@Adresse) ";

                //Création d'une commande SQL
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Création des paramètre pour l'ajout des données
                cmd.Parameters.AddWithValue("@Nom", c.Nom);
                cmd.Parameters.AddWithValue("@Prenom", c.Prenom);
                cmd.Parameters.AddWithValue("@Numero", c.Numero);
                cmd.Parameters.AddWithValue("@Adresse", c.Adresse);

                //On ouvre la connection 

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exeption)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
        //Création de la méthode pour Modifier les donnée de la base de données . 

        public bool Update(ContactClass c)
        {
            //Création de la valeur par défault (Vrai ou Faux ) 
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //On va créer la requete qui permet de modifier les élement de la base 
                string sql = "UPDATE Employe SET Nom=@Nom,Prenom=@Prenom,Numero=@Numero,Adresse=@Adresse WHERE Identifiant=@Identifiant";

                //Création de la SQL Commande 

                SqlCommand cmd = new SqlCommand(sql, conn);
                // Création des paramètre pour ajouter les valeurs 
                cmd.Parameters.AddWithValue("@Nom", c.Nom);
                cmd.Parameters.AddWithValue("@Prenom", c.Prenom);
                cmd.Parameters.AddWithValue("@Numero", c.Numero);
                cmd.Parameters.AddWithValue("@Adresse", c.Adresse);
               
                cmd.Parameters.AddWithValue("@Identifiant", c.Identifiant);

                // On ouvre la connection avec la base de données
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exeption)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //On va créer maintenant la méthode qui permet de supprimer 

        public bool Delete(ContactClass  c)
        {
            bool isSuccess = false;
            //On créer la connection 
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //On créer la requete qui permet de supprimer

                string sql = "DELETE FROM Employe WHERE Identifiant=@Identifiant";

                //On créer la commande SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Identifiant", c.Identifiant);
                //On ouvre la connection 
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exeption )
            {

            }
            finally
            {
                //On ferme la connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
