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
    public class PersonneService
    {
        // méthodes de recherche et d'affichage
        public static List<Personne> GetAll()
        {
            List<Personne> liste = null;
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
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
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5),p.Id);
                            p.Categorie = new CategoriePersonne(p.Id,reader.GetString(6),p.Id);
                            p.Coord = new Coordonnees(p.Id,reader.GetString(7), reader.GetString(8), reader.GetString(9),p.Id);
                            p.Adresse = new Adresse(p.Id,reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13),p.Id);
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


            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id
                WHERE A.ville = @Ville";
                    //cmd.Parameters.Add(new SqlParameter("@Ville", ville));
                    cmd.Parameters.AddWithValue("@Ville", ville);
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
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5), p.Id);
                            p.Categorie = new CategoriePersonne(p.Id, reader.GetString(6), p.Id);
                            p.Coord = new Coordonnees(p.Id, reader.GetString(7), reader.GetString(8), reader.GetString(9), p.Id);
                            p.Adresse = new Adresse(p.Id, reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), p.Id);
                            liste.Add(p);
                        }
                    }
                }
            }
            Console.WriteLine("get by ville taille " + liste.Count);

            return liste;

        }
        public static List<Personne> GetByPays(string pays)
        {
            List<Personne> liste = null;
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id
                WHERE A.pays = @Pays";
                   cmd.Parameters.Add(new SqlParameter("@Pays", pays));
                   // cmd.Parameters.AddWithValue("@Pays", pays);
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
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5), p.Id);
                            p.Categorie = new CategoriePersonne(p.Id, reader.GetString(6), p.Id);
                            p.Coord = new Coordonnees(p.Id, reader.GetString(7), reader.GetString(8), reader.GetString(9), p.Id);
                            p.Adresse = new Adresse(p.Id, reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), p.Id);
                            liste.Add(p);
                        }
                    }
                }
            }
            Console.WriteLine("taille GetByPays: " + liste.Count);
            return liste;
        }
        public static List<Personne> GetByName(string nom)
        {
            List<Personne> liste = null;
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id
                WHERE P.nom = @Nom";
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
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5), p.Id);
                            p.Categorie = new CategoriePersonne(p.Id, reader.GetString(6), p.Id);
                            p.Coord = new Coordonnees(p.Id, reader.GetString(7), reader.GetString(8), reader.GetString(9), p.Id);
                            p.Adresse = new Adresse(p.Id, reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), p.Id);
                            liste.Add(p);
                        }
                    }
                }
            }
            return liste;
        }
        public static List<Personne> GetByFname(string prenom)
        {
            List<Personne> liste = null;
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT P.id, nom, prenom,age, PR.titre, nomEntreprise, CP.titre, telephone, fax, email, rue, code_postal,ville,pays
                FROM personne P JOIN profession PR ON PR.id_personne = P.id
				JOIN categoriePersonne CP ON CP.id_personne = P.id
				JOIN coordonnees C ON P.id = C.id_personne
				JOIN adresse A ON A.id_personne = P.id
                WHERE P.prenom = @Prenom";
                    cmd.Parameters.Add(new SqlParameter("@Prenom", prenom));
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
                            p.Profession = new Profession(p.Id, reader.GetString(4), reader.GetString(5), p.Id);
                            p.Categorie = new CategoriePersonne(p.Id, reader.GetString(6), p.Id);
                            p.Coord = new Coordonnees(p.Id, reader.GetString(7), reader.GetString(8), reader.GetString(9), p.Id);
                            p.Adresse = new Adresse(p.Id, reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), p.Id);
                            liste.Add(p);
                        }
                    }
                }
            }
            return liste;
        }

        public static void Edit(Personne p)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE personne SET nom = @Nom, prenom=@Prenom, age=@Age,id_profession =@Id_profession, id_categoriePersonne =@Id_catPers,id_adresse = @Id_addr, id_coordonnees =@Id_coord WHERE id =@Id";
                    cmd.Parameters.AddWithValue("@Nom", p.Nom);
                    cmd.Parameters.AddWithValue("@Prenom", p.Prenom);
                    cmd.Parameters.AddWithValue("@Age", p.Age);
                    cmd.Parameters.AddWithValue("@Id_profession", p.Id_profession);
                    cmd.Parameters.AddWithValue("@Id_catPers", p.Id_categoriePersonne);
                    cmd.Parameters.AddWithValue("@Id_addr", p.Id_adresse);
                    cmd.Parameters.AddWithValue("@Id_coord", p.Id_coordonnees);
                    cmd.Parameters.AddWithValue("@Id", p.Id);

                    // modifié dans les autres tables correspondants à la personne
                    AdresseService.Edit(p.Adresse);
                    CategoriePersonneService.Edit(p.Categorie);
                    CoordonneesService.Edit(p.Coord);
                    ProfessionService.Edit(p.Profession);

                    cmd.ExecuteNonQuery();
                }
            }


        }
        // méthode pour supprimer
        public static void Delete(int id)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from personne where id = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    // delete toute info dans les autres tables avec meme id_personne
                    AdresseService.Delete(id);
                    ContactService.Delete(id);
                    CoordonneesService.Delete(id);
                    ProfessionService.Delete(id);
                    CategoriePersonneService.Delete(id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //méthode pour ajouter
        public static void Add(Personne p)
        {
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into personne(id,nom, prenom, age)" +
                        "values(@Id, @Nom, @Prenom,@Age)";
                    cmd.Parameters.AddWithValue("@Id", p.Id);
                    cmd.Parameters.AddWithValue("@Nom", p.Nom);
                    cmd.Parameters.AddWithValue("@Prenom", p.Prenom);
                    cmd.Parameters.AddWithValue("@Age", p.Age);
                    cmd.ExecuteNonQuery();
                    // appelle methodes add d'autres tables correspondants peronne
                    ContactService.Add(p.Id);
                    AdresseService.Add(p.Adresse);
                    CategoriePersonneService.add(p.Categorie);
                    CoordonneesService.Add(p.Coord);
                    ProfessionService.Add(p.Profession);

                    Console.WriteLine("personne ajouté");
                }
            }
        }

        // get all personne uniquement
        public static List<Personne> GetAllPersonne()
        {
            List<Personne> liste = null;
            //using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            //string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlConnection conn = new SqlConnection(connectionString: @"Data Source=VIEWW7-2013-408\SQLEXPRESS;Initial Catalog=tp_gestionContact;Integrated Security=True;Connect Timeout=5"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM personne";
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
                            liste.Add(p);
                        }
                    }
                }
            }

            return liste;
        }
    }
}
