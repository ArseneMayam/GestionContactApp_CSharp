using EntitiesLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //{}
    class PersonneService
    {
        // méthodes de recherche et d'affichage
        public static List<Personne> GetAll()
        {
            List<Personne> liste = null;
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<Personne>();
                        while (reader.Read())
                        {
                            Personne p = new Personne();
                            p.Id = reader.GetInt32(0);
                            p.Nom = reader.GetString(1);
                            p.Prenom = reader.GetString(2);
                            p.Age = reader.GetInt32(3);
                            p.Profession = new Profession(p.Id,reader.GetString(4),reader.GetString(5));
                            p.Categorie = new CategoriePersonne(reader.GetString(6));
                            p.Coord = new Coordonnees(reader.GetString(7), reader.GetString(8), reader.GetString(9));
                            p.Adresse = new Adresse(reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13));
                            liste.Add(p);
                        }
                    }
                }
            }

            return liste;
        }
        public static List<Personne> GetByVille(string ville)
        {
            List<Personne> liste = null;
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id
                WHERE A.ville = '@Ville'";
                    cmd.Parameters.Add(new SqlParameter("@Ville", ville));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<Personne>();
                        while (reader.Read())
                        {
                            Personne p = new Personne();
                            p.Id = reader.GetInt32(0);
                            p.Nom = reader.GetString(1);
                            p.Prenom = reader.GetString(2);
                            p.Age = reader.GetInt32(3);
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5));
                            p.Categorie = new CategoriePersonne(reader.GetString(6));
                            p.Coord = new Coordonnees(reader.GetString(7), reader.GetString(8), reader.GetString(9));
                            p.Adresse = new Adresse(reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13));
                            liste.Add(p);
                        }
                    }
                }
            }
            return liste;
        }
        public static List<Personne> GetByPays(string pays)
        {
            List<Personne> liste = null;
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id
                WHERE A.ville = '@Pays'";
                    cmd.Parameters.Add(new SqlParameter("@Pays", pays));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<Personne>();
                        while (reader.Read())
                        {
                            Personne p = new Personne();
                            p.Id = reader.GetInt32(0);
                            p.Nom = reader.GetString(1);
                            p.Prenom = reader.GetString(2);
                            p.Age = reader.GetInt32(3);
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5));
                            p.Categorie = new CategoriePersonne(reader.GetString(6));
                            p.Coord = new Coordonnees(reader.GetString(7), reader.GetString(8), reader.GetString(9));
                            p.Adresse = new Adresse(reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13));
                            liste.Add(p);
                        }
                    }
                }
            }
            return liste;
        }
        public static List<Personne> GetByName(string nom)
        {
            List<Personne> liste = null;
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id
                WHERE A.ville = '@Nom'";
                    cmd.Parameters.Add(new SqlParameter("@Nom", nom));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        liste = new List<Personne>();
                        while (reader.Read())
                        {
                            Personne p = new Personne();
                            p.Id = reader.GetInt32(0);
                            p.Nom = reader.GetString(1);
                            p.Prenom = reader.GetString(2);
                            p.Age = reader.GetInt32(3);
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5));
                            p.Categorie = new CategoriePersonne(reader.GetString(6));
                            p.Coord = new Coordonnees(reader.GetString(7), reader.GetString(8), reader.GetString(9));
                            p.Adresse = new Adresse(reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13));
                            liste.Add(p);
                        }
                    }
                }
            }
            return liste;
        }
        // méthode pour modifier
        public static void Edit(Personne p) {
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE personne SET nom ='@Nom', prenom='@Prenom', age='@Age',id_profession ='@Id_profession', id_categoriePersonne ='@Id_catPers',id_adresse = '@Id_addr', id_coordonnees ='@Id_coord' WHERE id ='@Id'";
                    cmd.Parameters.AddWithValue("@Nom", p.Nom);
                    cmd.Parameters.AddWithValue("@Prenom", p.Prenom);
                    cmd.Parameters.AddWithValue("@Age", p.Age);
                    cmd.Parameters.AddWithValue("@Id_profession", p.Id_profession);
                    cmd.Parameters.AddWithValue("@Id_catPers", p.Id_categoriePersonne);
                    cmd.Parameters.AddWithValue("@Id_addr", p.Id_adresse);
                    cmd.Parameters.AddWithValue("@Id_coord", p.Id_coordonnees);
                    // modifié dans les autres tables correspondants à la personne
                    AdresseService.Edit(p.Adresse);
                    // categorie personne
                    CoordonneesService.Edit(p.Coord);
                    ProfessionService.Edit(p.Profession);

                    cmd.ExecuteNonQuery();
                }
            }


        }
        // méthode pour supprimer
        public static void Delete(int id)
        {
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True;Connect Timeout=30"))
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from personne where id = '@Id'";
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    cmd.ExecuteNonQuery();
                    // delete toute info dans les autres tables avec meme id_personne
                    AdresseService.Delete(id);
                    ContactService.Delete(id);
                    CoordonneesService.Delete(id);
                    ProfessionService.Delete(id);
                }
            }
        }
    }
}
